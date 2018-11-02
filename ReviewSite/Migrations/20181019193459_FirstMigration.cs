using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "dog" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "doggo" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 1, 1, "Untoasted type Corgis have white fur. It's as if you had a piece of bread and did not put it in a toaster.", "/Images/whiteCorgi.png", "Corgi Type: Untoasted" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 2, 2, "Toasted type Corgis have brown fur. Like if you were to take a white piece of bread and put it in the toaster to toast it.", "/Images/puppyCorgi.jpg", "Corgi Type: Toasted" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "Title" },
                values: new object[] { 3, 2, "Burnt type Corgis have mostly black fur with partial brown and white mixed in. In other words, you left your piece of bread in the toaster for far too long and it got burnt.", "/Images/blackCorgi.jpg", "Corgi Type: Burnt" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CategoryId",
                table: "Reviews",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
