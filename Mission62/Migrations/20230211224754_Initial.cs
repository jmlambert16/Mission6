using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission62.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addMovies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent_To = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addMovies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action", "Sam Raimi", false, null, null, "PG-13", "Spider-Man", 2002 });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Sport/Drama", "M. Night Shyamalan", false, null, null, "PG", "Invincible", 2006 });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Comedy/Christmas/Musical ", "Sean Anders", false, null, null, "PG-13", "spirited ", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addMovies");
        }
    }
}
