using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class SeedDataIdChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 1, "Untoasted type Corgis have white fur. It's as if you had a piece of bread and did not put it in a toaster.", "/Images/whiteCorgi.png", "Corgi Type: Untoasted" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "ImageUrl", "Title" },
                values: new object[] { "Toasted type Corgis have brown fur. Like if you were to take a white piece of bread and put it in the toaster to toast it.", "/Images/puppyCorgi.jpg", "Corgi Type: Toasted" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 4, 2, "Burnt type Corgis have mostly black fur with partial brown and white mixed in. In other words, you left your piece of bread in the toaster for far too long and it got burnt.", "/Images/blackCorgi.jpg", "Corgi Type: Burnt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 2, "Toasted type Corgis have brown fur. Like if you were to take a white piece of bread and put it in the toaster to toast it.", "/Images/puppyCorgi.jpg", "Corgi Type: Toasted" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "ImageUrl", "Title" },
                values: new object[] { "Burnt type Corgis have mostly black fur with partial brown and white mixed in. In other words, you left your piece of bread in the toaster for far too long and it got burnt.", "/Images/blackCorgi.jpg", "Corgi Type: Burnt" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 1, 1, "Untoasted type Corgis have white fur. It's as if you had a piece of bread and did not put it in a toaster.", "/Images/whiteCorgi.png", "Corgi Type: Untoasted" });
        }
    }
}
