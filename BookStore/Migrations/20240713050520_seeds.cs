using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    public partial class seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Pages = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    PublisherId = table.Column<int>(type: "INTEGER", nullable: false),
                    PubDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "INTEGER", nullable: false),
                    BooksId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Author_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Book_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1005, 56, "Ashtyn Conroy" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1006, 37, "Jana Collier" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1007, 36, "Prof. Danyka Kuvalis" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1008, 61, "Maxime Crooks" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1009, 59, "Emery Wolff" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1010, 36, "Leola Spinka" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1011, 43, "Adele Barrows" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1012, 35, "Mr. Mekhi Will III" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1013, 27, "Jace Hartmann II" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1014, 49, "Harley O'Hara" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1015, 45, "Marvin Luettgen" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1016, 61, "Mrs. Mollie Upton I" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1017, 43, "Ms. Stella Sammy Bergnaum" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1018, 21, "Miss Travon Alex D'Amore Sr." });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1019, 41, "Ms. Carolyn Huel" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1020, 40, "Ms. Anabel Tavares Gusikowski V" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1021, 26, "Miss Keara Ziemann Jr." });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1022, 43, "Ms. Josiah Freeda Durgan" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1023, 59, "Rebeca Koelpin" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1024, 48, "Jeffery Justina Turner DVM" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1025, 33, "Yadira Abshire" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1026, 46, "Prof. Mitchell Jessy Gibson" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1027, 35, "Marcus Hilpert DVM" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1028, 53, "Nestor Crona" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1029, 52, "Dr. Elizabeth Aurore Bartell PhD" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1030, 29, "Dr. Corine Shanon Cummerata" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1031, 38, "Clara Keeling" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1032, 31, "Bernard Padberg" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1033, 41, "Eldridge Adams" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1034, 49, "Floyd Leannon" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1035, 43, "Mrs. Mohamed Deion Brekke" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1036, 54, "Mr. Zion Devan Murphy" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1037, 31, "Fred Daugherty" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1038, 62, "Wendell Kuphal" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1039, 26, "Victoria Lesch" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1040, 31, "Ms. Zackary Ullrich Jr." });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1041, 60, "Ms. Sincere Hilpert" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1042, 38, "Rodrigo Lueilwitz" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1043, 23, "Ressie Becker" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1044, 47, "Lyla Daugherty" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1045, 25, "Ms. Keith Emanuel Greenholt" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1046, 28, "Tamara Quitzon" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1047, 46, "Cassandre Kub" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1048, 41, "Arnold Lemke" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1049, 56, "Dr. Stephania Allene Gaylord PhD" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1050, 39, "Zakary Quitzon" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1051, 55, "Mrs. Bethel Fermin Keeling MD" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1052, 29, "Simone West" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1053, 24, "Paxton Hand" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1054, 54, "Agustin Breitenberg" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 105, "Maryam Spencer" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 106, "Mrs. Marcelino Evangeline Rempel" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 107, "Elliott Zemlak" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 108, "Jess Fay" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 109, "Mrs. Angela Shirley Bednar Jr." });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 110, "Mrs. Liliana Heaney" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 111, "Norwood Towne" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 112, "Kaitlyn Kreiger" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 113, "Mr. Albert Virgil Collins" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 114, "Mozell Keeling" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 115, "Willie Berneice Morar Jr." });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 116, "Bernard Tillman" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 117, "Rubie Grady V" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 118, "Donavon Vandervort" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 119, "Noe Toy" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 120, "Ms. Nia Sharon Macejkovic Jr." });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 121, "Dr. Woodrow VonRueden" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 122, "Melvin Witting" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 123, "Kailee Graham" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 124, "Kira O'Kon V" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 125, "Miss Roma Jaiden Rosenbaum" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 126, "Elvis Karina Streich IV" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 127, "Mortimer Mosciski" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 128, "Isabelle Sedrick Franecki MD" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 129, "Krista Murphy" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 130, "Declan Stanton" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 131, "Daren Huels" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 132, "Torey Wunsch" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 133, "Thea Gislason" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 134, "Ms. Joseph Parisian I" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 135, "Larissa Randall Murazik IV" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 136, "Prof. Noah Reginald Larson" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 137, "Ernest Rolfson" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 138, "Reagan Greenholt" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 139, "Victor Jermain Reichert MD" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 140, "Daron Schmeler" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 141, "Jalon Bartoletti" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 142, "Christine Beahan" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 143, "Princess Heathcote" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 144, "Miss Pinkie Nienow" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 145, "Dr. Ayden Lindsey O'Connell PhD" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 146, "Kara Beer" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 147, "Lewis Sanford" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 148, "Miguel Ullrich" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 149, "Alayna Goodwin" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 150, "Ansel Abshire" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 151, "Mr. Lacy Bud Stehr DVM" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 152, "Dulce Doyle" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 153, "Benny Ethan Wolff I" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { 154, "Letha Romaguera V" });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_StoreId",
                table: "Book",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Store");
        }
    }
}
