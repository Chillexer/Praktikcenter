var bodyParser     = require("body-parser"),
    express        = require("express"),
    mysql          = require('mysql'),
    app            = express();

app.set("view engine", "ejs"); //denne her function gør så view engine er ejs
app.set("views", __dirname + "/views"); //sætter html filens standard mappe
app.use(express.static(__dirname + "/public")); //sætter alle link og src filers standard destination

app.get("/", function (req, res) { //Denne her function henter dataene fra databasen når en bruger prøver at komme ind på siden og så sender dataene videre til brugeren
    var con = mysql.createConnection({ //opretter et object som bruges til at oprette forbindelse til serveren
        host: "192.168.0.37",
        user: "frederik",
        password: "Passw0rd"
        });
    con.query("SELECT * FROM Nominerede.Film;", function (err, result) {
        con.end();
        if(err){
            res.send("Der er sket en fejl, prøv igen senere");
            return;
        }
        res.render("index",{result: result});
    });
});

app.listen(80, "192.168.0.143", function () { //Denne her function er den der gør at man kan forbinde til webserveren
    console.log("Server has started!!!");
});
