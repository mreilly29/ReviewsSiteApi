using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class AddedCommentModelandCommentSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ReviewId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedAt", "ReviewId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Wow! I've never seen a white Corgi before." },
                    { 2, new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Such a cute dog!!" },
                    { 3, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "I want a burnt Corgi!" },
                    { 4, new DateTime(2018, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Did anyone else think this was just a loaf a bread?.. no? just me..?" },
                    { 5, new DateTime(2018, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "I sure do feel safer when Captain Corgi is around." },
                    { 6, new DateTime(2018, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Captain Corgi once helped get my cat out of a tree. Great doggo." },
                    { 7, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "I've been searching for this Corgi in the wild for years.. but no luck!" },
                    { 8, new DateTime(2018, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Uber was taking too long, so I went with Cowboy Corgi. Highly recommend their service! Way faster than Uber or Lyft!" },
                    { 9, new DateTime(2018, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "I had Coding Corgi create my website for my business and I have seen such an increase in online traffic of my site! His work is amzing!!" },
                    { 10, new DateTime(2018, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "GREATEST CONCERT I'VE EVER BEEN TO!" },
                    { 11, new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "You should highly consider putting this Corgi's concert on your bucket list." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReviewId",
                table: "Comments",
                column: "ReviewId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
