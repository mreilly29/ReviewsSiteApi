using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class AddedMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bread");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Super");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Hard-Working" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 4, 1, "It's very easy to mistake Untoasted Corgis as loafs of bread, but if you look closely you can see that it's just a corgi, no worries.", "/Images/corgiLoaf.jpg", "Corgi Type: Loaf" },
                    { 5, 2, "You're probably thinking, /'why is Captain America on this site?'/ But look again, it's Captain Corgi! He fights evil day and night to keep us all safe.", "/Images/superCorgi.png", "Corgi Type: Hero" },
                    { 6, 2, "A rare photo of the ancient mythical creature know as the Ninja Turtle Corgi!", "/Images/turtleCorgi.jpg", "Corgi Type: Turtle" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 7, 3, "Need a ride? Call on Cowboy Corgi to get you from point A to point B in record time!", "/Images/codingCorgi.jpg", "Corgi Type: Cowboy Corgi" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 8, 3, "A rare species of the Coding Corgi in its natural habitat. For all we know, this corgi created this entire site from scratch.", "/Images/codingCorgi.jpg", "Corgi Type: Tech Savvy" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 9, 3, "This Corgi learned how to play the guitar when he was only 8 weeks old. He is currently doing a world tour, maybe you'll get lucky enough to snag some tickets!", "/Images/guitarCorgi.jpg", "Corgi Type: Musical" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "dog");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "doggo");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 2);
        }
    }
}
