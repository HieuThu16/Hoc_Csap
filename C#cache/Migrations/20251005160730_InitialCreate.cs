using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Northwind.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    ContactName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    ContactTitle = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Region = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 24, nullable: true),
                    Fax = table.Column<string>(type: "TEXT", maxLength: 24, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Fax", "Phone", "PostalCode", "Region" },
                values: new object[,]
                {
                    { "ALFKI", "Obere Str. 57", "Berlin", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Germany", "030-0076545", "030-0074321", "12209", null },
                    { "ANATR", "Avda. de la Constitución 2222", "México D.F.", "Ana Trujillo Emparedados y helados", "Ana Trujillo", "Owner", "Mexico", "(5) 555-3745", "(5) 555-4729", "05021", null },
                    { "ANTON", "Mataderos 2312", "México D.F.", "Antonio Moreno Taquería", "Antonio Moreno", "Owner", "Mexico", null, "(5) 555-3932", "05023", null },
                    { "AROUT", "120 Hanover Sq.", "London", "Around the Horn", "Thomas Hardy", "Sales Representative", "UK", "(171) 555-6750", "(171) 555-7788", "WA1 1DP", null },
                    { "BERGS", "Berguvsvägen 8", "Luleå", "Berglunds snabbköp", "Christina Berglund", "Order Administrator", "Sweden", "0921-12 34 67", "0921-12 34 65", "S-958 22", null },
                    { "BLAUS", "Forsterstr. 57", "Mannheim", "Blauer See Delikatessen", "Hanna Moos", "Sales Representative", "Germany", "0621-08924", "0621-08460", "68306", null },
                    { "BLONP", "24, place Kléber", "Strasbourg", "Blondesddsl père et fils", "Frédérique Citeaux", "Marketing Manager", "France", "88.60.15.32", "88.60.15.31", "67000", null },
                    { "BOLID", "C/ Araquil, 67", "Madrid", "Bólido Comidas preparadas", "Martín Sommer", "Owner", "Spain", "(91) 555 91 99", "(91) 555 22 82", "28023", null },
                    { "BONAP", "12, rue des Bouchers", "Marseille", "Bon app'", "Laurence Lebihan", "Owner", "France", "91.24.45.41", "91.24.45.40", "13008", null },
                    { "BOTTM", "23 Tsawassen Blvd.", "Tsawassen", "Bottom-Dollar Markets", "Elizabeth Lincoln", "Accounting Manager", "Canada", "(604) 555-3745", "(604) 555-4729", "T2F 8M4", "BC" },
                    { "BSBEV", "Fauntleroy Circus", "London", "B's Beverages", "Victoria Ashworth", "Sales Representative", "UK", null, "(171) 555-1212", "EC2 5NT", null },
                    { "CACTU", "Cerrito 333", "Buenos Aires", "Cactus Comidas para llevar", "Patricio Simpson", "Sales Agent", "Argentina", "(1) 135-4892", "(1) 135-5555", "1010", null },
                    { "CENTC", "Sierras de Granada 9993", "México D.F.", "Centro comercial Moctezuma", "Francisco Chang", "Marketing Manager", "Mexico", "(5) 555-7293", "(5) 555-3392", "05022", null },
                    { "CHOPS", "Hauptstr. 29", "Bern", "Chop-suey Chinese", "Yang Wang", "Owner", "Switzerland", null, "0452-076545", "3012", null },
                    { "COMMI", "Av. dos Lusíadas, 23", "São Paulo", "Comércio Mineiro", "Pedro Afonso", "Sales Associate", "Brazil", null, "(11) 555-7647", "05432-043", "SP" },
                    { "CONSH", "Berkeley Gardens 12 Brewery", "London", "Consolidated Holdings", "Elizabeth Brown", "Sales Representative", "UK", "(171) 555-9199", "(171) 555-2282", "WX1 6LT", null },
                    { "DRACD", "Walserweg 21", "Aachen", "Drachenblut Delikatessen", "Sven Ottlieb", "Order Administrator", "Germany", "0241-059428", "0241-039123", "52066", null },
                    { "DUMON", "67, rue des Cinquante Otages", "Nantes", "Du monde entier", "Janine Labrune", "Owner", "France", "40.67.89.89", "40.67.88.88", "44000", null },
                    { "EASTC", "35 King George", "London", "Eastern Connection", "Ann Devon", "Sales Agent", "UK", "(171) 555-3373", "(171) 555-0297", "WX3 6FW", null },
                    { "ERNSH", "Kirchgasse 6", "Graz", "Ernst Handel", "Roland Mendel", "Sales Manager", "Austria", "7675-3426", "7675-3425", "8010", null },
                    { "FAMIA", "Rua Orós, 92", "São Paulo", "Familia Arquibaldo", "Aria Cruz", "Marketing Assistant", "Brazil", null, "(11) 555-9857", "05442-030", "SP" },
                    { "FISSA", "C/ Moralzarzal, 86", "Madrid", "FISSA Fabrica Inter. Salchichas S.A.", "Diego Roel", "Accounting Manager", "Spain", "(91) 555 55 93", "(91) 555 94 44", "28034", null },
                    { "FOLIG", "184, chaussée de Tournai", "Lille", "Folies gourmandes", "Martine Rancé", "Assistant Sales Agent", "France", "20.16.10.17", "20.16.10.16", "59000", null },
                    { "FOLKO", "Åkergatan 24", "Bräcke", "Folk och fä HB", "Maria Larsson", "Owner", "Sweden", null, "0695-34 67 21", "S-844 67", null },
                    { "FRANK", "Berliner Platz 43", "München", "Frankenversand", "Peter Franken", "Marketing Manager", "Germany", "089-0877451", "089-0877310", "80805", null },
                    { "FRANR", "54, rue Royale", "Nantes", "France restauration", "Carine Schmitt", "Marketing Manager", "France", "40.32.21.20", "40.32.21.21", "44000", null },
                    { "FRANS", "Via Monte Bianco 34", "Torino", "Franchi S.p.A.", "Paolo Accorti", "Sales Representative", "Italy", "011-4988261", "011-4988260", "10100", null },
                    { "FURIB", "Jardim das rosas n. 32", "Lisboa", "Furia Bacalhau e Frutos do Mar", "Lino Rodriguez", "Sales Manager", "Portugal", "(1) 354-2535", "(1) 354-2534", "1675", null },
                    { "GALED", "Rambla de Cataluña, 23", "Barcelona", "Galería del gastrónomo", "Eduardo Saavedra", "Marketing Manager", "Spain", "(93) 203 4561", "(93) 203 4560", "08022", null },
                    { "GODOS", "C/ Romero, 33", "Sevilla", "Godos Cocina Típica", "José Pedro Freyre", "Sales Manager", "Spain", null, "(95) 555 82 82", "41101", null },
                    { "GOURL", "Av. Brasil, 442", "Campinas", "Gourmet Lanchonetes", "André Fonseca", "Sales Associate", "Brazil", null, "(11) 555-9482", "04876-786", "SP" },
                    { "GREAL", "2732 Baker Blvd.", "Eugene", "Great Lakes Food Market", "Howard Snyder", "Marketing Manager", "USA", null, "(503) 555-7555", "97403", "OR" },
                    { "GROSR", "5ª Ave. Los Palos Grandes", "Caracas", "GROSELLA-Restaurante", "Manuel Pereira", "Owner", "Venezuela", "(2) 283-3397", "(2) 283-2951", "1081", "DF" },
                    { "HANAR", "Rua do Paço, 67", "Rio de Janeiro", "Hanari Carnes", "Mario Pontes", "Accounting Manager", "Brazil", "(21) 555-8765", "(21) 555-0091", "05454-876", "RJ" },
                    { "HILAA", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "HILARIÓN-Abastos", "Carlos Hernández", "Sales Representative", "Venezuela", "(5) 555-1948", "(5) 555-1340", "5022", "Táchira" },
                    { "HUNGC", "City Center Plaza 516 Main St.", "Elgin", "Hungry Coyote Import Store", "Yoshi Latimer", "Sales Representative", "USA", "(503) 555-2376", "(503) 555-6874", "97827", "OR" },
                    { "HUNGO", "8 Johnstown Road", "Cork", "Hungry Owl All-Night Grocers", "Patricia McKenna", "Sales Associate", "Ireland", "2967 3333", "2967 542", null, "Co. Cork" },
                    { "ISLAT", "Garden House Crowther Way", "Cowes", "Island Trading", "Helen Bennett", "Marketing Manager", "UK", null, "(198) 555-8888", "PO31 7PJ", "Isle of Wight" },
                    { "KOENE", "Maubelstr. 90", "Brandenburg", "Königlich Essen", "Philip Cramer", "Sales Associate", "Germany", null, "0555-09876", "14776", null },
                    { "LACOR", "67, avenue de l'Europe", "Versailles", "La corne d'abondance", "Daniel Tonini", "Sales Representative", "France", "30.59.85.11", "30.59.84.10", "78000", null },
                    { "LAMAI", "1 rue Alsace-Lorraine", "Toulouse", "La maison d'Asie", "Annette Roulet", "Sales Manager", "France", "61.77.61.11", "61.77.61.10", "31000", null },
                    { "LAUGB", "1900 Oak St.", "Vancouver", "Laughing Bacchus Wine Cellars", "Yoshi Tannamuri", "Marketing Assistant", "Canada", "(604) 555-7293", "(604) 555-3392", "V3F 2K1", "BC" },
                    { "LAZYK", "12 Orchestra Terrace", "Walla Walla", "Lazy K Kountry Store", "John Steel", "Marketing Manager", "USA", "(509) 555-6221", "(509) 555-7969", "99362", "WA" },
                    { "LEHMS", "Magazinweg 7", "Frankfurt a.M.", "Lehmanns Marktstand", "Renate Messner", "Sales Representative", "Germany", "069-0245874", "069-0245984", "60528", null },
                    { "LETSS", "87 Polk St. Suite 5", "San Francisco", "Let's Stop N Shop", "Jaime Yorres", "Owner", "USA", null, "(415) 555-5938", "94117", "CA" },
                    { "LILAS", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "LILA-Supermercado", "Carlos González", "Accounting Manager", "Venezuela", "(9) 331-7256", "(9) 331-6954", "3508", "Lara" },
                    { "LINOD", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "LINO-Delicateses", "Felipe Izquierdo", "Owner", "Venezuela", "(8) 34-93-93", "(8) 34-56-12", "4980", "Nueva Esparta" },
                    { "LONEP", "89 Chiaroscuro Rd.", "Portland", "Lonesome Pine Restaurant", "Fran Wilson", "Sales Manager", "USA", "(503) 555-9646", "(503) 555-9573", "97219", "OR" },
                    { "MAGAA", "Via Ludovico il Moro 22", "Bergamo", "Magazzini Alimentari Riuniti", "Giovanni Rovelli", "Marketing Manager", "Italy", "035-640231", "035-640230", "24100", null },
                    { "MAISD", "Rue Joseph-Bens 532", "Bruxelles", "Maison Dewey", "Catherine Dewey", "Sales Agent", "Belgium", "(02) 201 24 68", "(02) 201 24 67", "B-1180", null },
                    { "MEREP", "43 rue St. Laurent", "Montréal", "Mère Paillarde", "Jean Fresnière", "Marketing Assistant", "Canada", "(514) 555-8055", "(514) 555-8054", "H1J 1C3", "Québec" },
                    { "MORGK", "Heerstr. 22", "Leipzig", "Morgenstern Gesundkost", "Alexander Feuer", "Marketing Assistant", "Germany", null, "0342-023176", "04179", null },
                    { "NORTS", "South House 300 Queensbridge", "London", "North/South", "Simon Crowther", "Sales Associate", "UK", "(171) 555-2530", "(171) 555-7733", "SW7 1RZ", null },
                    { "OCEAN", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", "Océano Atlántico Ltda.", "Yvonne Moncada", "Sales Agent", "Argentina", "(1) 135-5535", "(1) 135-5333", "1010", null },
                    { "OLDWO", "2743 Bering St.", "Anchorage", "Old World Delicatessen", "Rene Phillips", "Sales Representative", "USA", "(907) 555-2880", "(907) 555-7584", "99508", "AK" },
                    { "OTTIK", "Mehrheimerstr. 369", "Köln", "Ottiliens Käseladen", "Henriette Pfalzheim", "Owner", "Germany", "0221-0765721", "0221-0644327", "50739", null },
                    { "PARIS", "265, boulevard Charonne", "Paris", "Paris spécialités", "Marie Bertrand", "Owner", "France", "(1) 42.34.22.77", "(1) 42.34.22.66", "75012", null },
                    { "PERIC", "Calle Dr. Jorge Cash 321", "México D.F.", "Pericles Comidas clásicas", "Guillermo Fernández", "Sales Representative", "Mexico", "(5) 545-3745", "(5) 552-3745", "05033", null },
                    { "PICCO", "Geislweg 14", "Salzburg", "Piccolo und mehr", "Georg Pipps", "Sales Manager", "Austria", "6562-9723", "6562-9722", "5020", null },
                    { "PRINI", "Estrada da saúde n. 58", "Lisboa", "Princesa Isabel Vinhos", "Isabel de Castro", "Sales Representative", "Portugal", null, "(1) 356-5634", "1756", null },
                    { "QUEDE", "Rua da Panificadora, 12", "Rio de Janeiro", "Que Delícia", "Bernardo Batista", "Accounting Manager", "Brazil", "(21) 555-4545", "(21) 555-4252", "02389-673", "RJ" },
                    { "QUEEN", "Alameda dos Canàrios, 891", "São Paulo", "Queen Cozinha", "Lúcia Carvalho", "Marketing Assistant", "Brazil", null, "(11) 555-1189", "05487-020", "SP" },
                    { "QUICK", "Taucherstraße 10", "Cunewalde", "QUICK-Stop", "Horst Kloss", "Accounting Manager", "Germany", null, "0372-035188", "01307", null },
                    { "RANCH", "Av. del Libertador 900", "Buenos Aires", "Rancho grande", "Sergio Gutiérrez", "Sales Representative", "Argentina", "(1) 123-5556", "(1) 123-5555", "1010", null },
                    { "RATTC", "2817 Milton Dr.", "Albuquerque", "Rattlesnake Canyon Grocery", "Paula Wilson", "Assistant Sales Representative", "USA", "(505) 555-3620", "(505) 555-5939", "87110", "NM" },
                    { "REGGC", "Strada Provinciale 124", "Reggio Emilia", "Reggiani Caseifici", "Maurizio Moroni", "Sales Associate", "Italy", "0522-556722", "0522-556721", "42100", null },
                    { "RICAR", "Av. Copacabana, 267", "Rio de Janeiro", "Ricardo Adocicados", "Janete Limeira", "Assistant Sales Agent", "Brazil", null, "(21) 555-3412", "02389-890", "RJ" },
                    { "RICSU", "Grenzacherweg 237", "Genève", "Richter Supermarkt", "Michael Holz", "Sales Manager", "Switzerland", null, "0897-034214", "1203", null },
                    { "ROMEY", "Gran Vía, 1", "Madrid", "Romero y tomillo", "Alejandra Camino", "Accounting Manager", "Spain", "(91) 745 6210", "(91) 745 6200", "28001", null },
                    { "SANTG", "Erling Skakkes gate 78", "Stavern", "Santé Gourmet", "Jonas Bergulfsen", "Owner", "Norway", "07-98 92 47", "07-98 92 35", "4110", null },
                    { "SAVEA", "187 Suffolk Ln.", "Boise", "Save-a-lot Markets", "Jose Pavarotti", "Sales Representative", "USA", null, "(208) 555-8097", "83720", "ID" },
                    { "SEVES", "90 Wadhurst Rd.", "London", "Seven Seas Imports", "Hari Kumar", "Sales Manager", "UK", "(171) 555-5646", "(171) 555-1717", "OX15 4NB", null },
                    { "SIMOB", "Vinbæltet 34", "København", "Simons bistro", "Jytte Petersen", "Owner", "Denmark", "31 13 35 57", "31 12 34 56", "1734", null },
                    { "SPECD", "25, rue Lauriston", "Paris", "Spécialités du monde", "Dominique Perrier", "Marketing Manager", "France", "(1) 47.55.60.20", "(1) 47.55.60.10", "75016", null },
                    { "SPLIR", "P.O. Box 555", "Lander", "Split Rail Beer & Ale", "Art Braunschweiger", "Sales Manager", "USA", "(307) 555-6525", "(307) 555-4680", "82520", "WY" },
                    { "SUPRD", "Boulevard Tirou, 255", "Charleroi", "Suprêmes délices", "Pascale Cartrain", "Accounting Manager", "Belgium", "(071) 23 67 22 21", "(071) 23 67 22 20", "B-6000", null },
                    { "THEBI", "89 Jefferson Way Suite 2", "Portland", "The Big Cheese", "Liz Nixon", "Marketing Manager", "USA", null, "(503) 555-3612", "97201", "OR" },
                    { "THECR", "55 Grizzly Peak Rd.", "Butte", "The Cracker Box", "Liu Wong", "Marketing Assistant", "USA", "(406) 555-8083", "(406) 555-5834", "59801", "MT" },
                    { "TOMSP", "Luisenstr. 48", "Münster", "Toms Spezialitäten", "Karin Josephs", "Marketing Manager", "Germany", "0251-035695", "0251-031259", "44087", null },
                    { "TORTU", "Avda. Azteca 123", "México D.F.", "Tortuga Restaurante", "Miguel Angel Paolino", "Owner", "Mexico", null, "(5) 555-2933", "05033", null },
                    { "TRADH", "Av. Inês de Castro, 414", "São Paulo", "Tradição Hipermercados", "Anabela Domingues", "Sales Representative", "Brazil", "(11) 555-2168", "(11) 555-2167", "05634-030", "SP" },
                    { "TRAIH", "722 DaVinci Blvd.", "Kirkland", "Trail's Head Gourmet Provisioners", "Helvetius Nagy", "Sales Associate", "USA", "(206) 555-2174", "(206) 555-8257", "98034", "WA" },
                    { "VAFFE", "Smagsløget 45", "Århus", "Vaffeljernet", "Palle Ibsen", "Sales Manager", "Denmark", "86 22 33 44", "86 21 32 43", "8200", null },
                    { "VICTE", "2, rue du Commerce", "Lyon", "Victuailles en stock", "Mary Saveley", "Sales Agent", "France", "78.32.54.87", "78.32.54.86", "69004", null },
                    { "VINET", "59 rue de l'Abbaye", "Reims", "Vins et alcools Chevalier", "Paul Henriot", "Accounting Manager", "France", "26.47.15.11", "26.47.15.10", "51100", null },
                    { "WANDK", "Adenauerallee 900", "Stuttgart", "Die Wandernde Kuh", "Rita Müller", "Sales Representative", "Germany", "0711-035428", "0711-020361", "70563", null },
                    { "WARTH", "Torikatu 38", "Oulu", "Wartian Herkku", "Pirkko Koskitalo", "Accounting Manager", "Finland", "981-443655", "981-443655", "90110", null },
                    { "WELLI", "Rua do Mercado, 12", "Resende", "Wellington Importadora", "Paula Parente", "Sales Manager", "Brazil", null, "(14) 555-8122", "08737-363", "SP" },
                    { "WHITC", "305 - 14th Ave. S. Suite 3B", "Seattle", "White Clover Markets", "Karl Jablonski", "Owner", "USA", "(206) 555-4115", "(206) 555-4112", "98128", "WA" },
                    { "WILMK", "Keskuskatu 45", "Helsinki", "Wilman Kala", "Matti Karttunen", "Owner/Marketing Assistant", "Finland", "90-224 8858", "90-224 8858", "21240", null },
                    { "WOLZA", "ul. Filtrowa 68", "Warszawa", "Wolski  Zajazd", "Zbyszek Piestrzeniewicz", "Owner", "Poland", "(26) 642-7012", "(26) 642-7012", "01-012", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
