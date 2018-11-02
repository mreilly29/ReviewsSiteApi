using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class CorrectedTypos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "It's very easy to mistake Untoasted Corgis as loaves of bread, but if you look closely you can see that it's just a Corgi, no worries.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: "You're probably thinking, 'why is Captain America on this site?' But look again, it's Captain Corgi! He fights evil day and night to keep us all safe.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "It's very easy to mistake Untoasted Corgis as loaves of bread, but if you look closely you can see that it's just a corgi, no worries.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: "You're probably thinking, /'why is Captain America on this site?'/ But look again, it's Captain Corgi! He fights evil day and night to keep us all safe.");
        }
    }
}
