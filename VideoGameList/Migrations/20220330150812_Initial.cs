using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoGameList.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name", "Rating", "year" },
                values: new object[] { 1, "Grand Theft Auto", 5, 2013 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name", "Rating", "year" },
                values: new object[] { 2, "Shadow of the Tomb Raider ", 4, 2016 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name", "Rating", "year" },
                values: new object[] { 3, "Madden NFL 19", 4, 2019 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
