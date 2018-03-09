namespace GeoTema
{
    class Brugere
    {
        private static Connection db = new Connection();

        public static void Opret_bruger(string username, string password, string valg)
        {
            switch (valg)
            {
                case "Administrator":
                    Administrator(username, password);
                    break;
                case "Superbruger":
                    Superbruger(username, password);
                    break;
                case "Standard bruger":
                    Standard_bruger(username, password);
                    break;
            }
        }

        private static void Administrator(string username, string password)
        {
            string cmd = "if NOT EXISTS(select * from sys.server_principals " +
                "where name = '" + username + "' ) " +
                "Begin " +
                //Laver et login
                "CREATE LOGIN [" + username + "] WITH PASSWORD = '" + password + "';" +
                //Giver personen sysadmin rettigheder for serveren
                "ALTER SERVER ROLE sysadmin ADD MEMBER [" + username + "];" +
                "End";

            db.Send(cmd);
        }

        private static void Superbruger(string username, string password)
        {
            string cmd = "if NOT EXISTS(select * from sys.server_principals " +
                "where name = '" + username + "' ) " +
                "Begin " +
                //Laver et login
                "CREATE LOGIN [" + username + "] WITH PASSWORD = '" + password + "';" +
                //Tilføjer personen til en database
                "CREATE USER [" + username + "] FOR LOGIN [" + username + "];" +
                //Giver personen rettigheder for databasen
                "ALTER ROLE db_datareader ADD MEMBER [" + username + "];" +
                "ALTER ROLE db_datawriter ADD MEMBER [" + username + "];" +
                "End";

            db.Send(cmd);
        }

        private static void Standard_bruger(string username, string password)
        {
            string cmd = "if NOT EXISTS(select * from sys.server_principals " +
                "where name = '" + username + "' ) " +
                "Begin " +
                //Laver et login
                "CREATE LOGIN [" + username + "] WITH PASSWORD = '" + password + "';" +
                //Tilføjer personen til en database
                "CREATE USER [" + username + "] FOR LOGIN [" + username + "];" +
                //Giver personen rettigheder for databasen
                "ALTER ROLE db_datareader ADD MEMBER [" + username + "];" +
                "End";

            db.Send(cmd);
        }

        public static void Nulstil(string user)
        {
            db.Send($"ALTER LOGIN {user} WITH PASSWORD = 'Passw0rd'");
        }
    }
}