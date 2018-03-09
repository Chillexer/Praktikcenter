using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SqlServerSome
{
    public partial class MainWindow : Window
    {
        private static  CprSql cp = new CprSql("WIN-10GEGFGBT6V\\TECCPR", "Tec", "sa", "Foss2812", "WIN-10GEGFGBT6V\\SQL", "TecS", "sa", "Foss2812");
        public MainWindow()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateGrid();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            cp.CreateUser(nameBox.Text, lastNameBox.Text, Convert.ToInt32(ageBox.Text), Convert.ToInt32(cprBox.Text));
            UpdateGrid();
            nameBox.Text = "";
            lastNameBox.Text = "";
            cprBox.Text = "";
            ageBox.Text = "";
        }

        private void UpdateGrid()
        {
            DataGridUsers.ItemsSource = cp.GetUser().DefaultView;
        }
    }

    class CprSql
    {
        private ConnectionAndCmd userCon;
        private ConnectionAndCmd cprCon;

        public CprSql(string serverName, string catalogName, string userName, string password, string serverName2, string catalogName2, string userName2, string password2)
        {
            userCon = new ConnectionAndCmd(serverName, catalogName, userName, password);
            cprCon = new ConnectionAndCmd(serverName2, catalogName2, userName2, password2);
        }

        public DataTable GetUser()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Fornavn", typeof(string));
            dt.Columns.Add("Efternavn", typeof(string));
            dt.Columns.Add("Fødselsdag", typeof(int));
            dt.Columns.Add("Cpr", typeof(int));

            JoinTables(dt, GetData(userCon, "SELECT * FROM Personer"), GetData(cprCon, "SELECT * FROM PersonNummer"));

            return dt;
        }

        private DataTable JoinTables(DataTable resultDT, DataTable table1, DataTable table2)
        {
            var result = from dataRows1 in table1.AsEnumerable()
                         join dataRows2 in table2.AsEnumerable()
                         on dataRows1.Field<int>("PerId") equals dataRows2.Field<int>("PerId")

                         select resultDT.LoadDataRow(new object[]
                         {
                             dataRows1.Field<string>("Fornavn"),
                             dataRows1.Field<string>("Efternavn"),
                             dataRows1.Field<int>("Fdag"),
                             dataRows2.Field<int>("CprNum"),
                         }, false);
            result.CopyToDataTable();

            return resultDT;
        }

        private DataTable GetData(ConnectionAndCmd myCon, string command)
        {
            DataTable dt = new DataTable();

            myCon.OpenConnection();
            dt = myCon.NewQuery(command);
            myCon.CloseConnection();

            return dt;
        }


        public void CreateUser(string name, string lastname, int age, int cpr)
        {
            userCon.OpenConnection();
            int id = userCon.GetId($"INSERT INTO Personer OUTPUT INSERTED.PerId VALUES ('{name}', '{lastname}', {age});");
            userCon.CloseConnection();

            InsertCpr(id, cpr);
        }

        private void InsertCpr(int id, int cpr)
        {
            cprCon.OpenConnection();
            cprCon.NewQuery($"INSERT INTO PersonNummer VALUES ({id}, {cpr})");
            cprCon.CloseConnection();
        }
    }

    class ConnectionAndCmd
    {
        SqlConnection con;
        SqlCommand cmd;

        public ConnectionAndCmd(string serverName, string catalogName, string userName, string password)
        {
            con = new SqlConnection($"Data Source={serverName}; Initial Catalog={catalogName}; User id={userName}; Password={password}");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }


        public DataTable NewQuery(string command)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = command;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public int GetId(string command)
        {
            cmd.CommandText = command;
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void OpenConnection()
        {
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }
    }
}

