using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class CorrectedTyposInSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 8,
                column: "Content",
                value: "A rare species of the Coding Corgi in its natural habitat. For all we know, this Corgi created this entire site from scratch.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "It's very easy to mistake Untoasted Corgis as loafs of bread, but if you look closely you can see that it's just a corgi, no worries.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "Content",
                value: "A rare species of the Coding Corgi in its natural habitat. For all we know, this corgi created this entire site from scratch.");
        }
    }
}
