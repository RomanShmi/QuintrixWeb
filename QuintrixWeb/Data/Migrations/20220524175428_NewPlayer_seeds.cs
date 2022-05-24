using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuintrixWeb.Data.Migrations
{
    public partial class NewPlayer_seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NewPlayers",
                columns: new[] { "Id", "Email", "Level", "Name", "StateId" },
                values: new object[] { 5, "seed1@seed.ss", 7, "Seed1", 8 });

            migrationBuilder.InsertData(
                table: "NewPlayers",
                columns: new[] { "Id", "Email", "Level", "Name", "StateId" },
                values: new object[] { 6, "seed2@seed.ss", 7, "Seed2", 12 });

            migrationBuilder.InsertData(
                table: "NewPlayers",
                columns: new[] { "Id", "Email", "Level", "Name", "StateId" },
                values: new object[] { 7, "seed3@seed.ss", 9, "Seed3", 23 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewPlayers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NewPlayers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NewPlayers",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
