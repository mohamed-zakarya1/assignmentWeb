using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Migrations
{
    public partial class initss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    LoyaltyId = table.Column<int>(type: "int", nullable: true),
                    CardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Arts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publication_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Arts_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "10% Off", "Bronze" },
                    { 2, "20% Off", "Silver" },
                    { 3, "30% Off", "Gold" },
                    { 4, "40% Off", "Platinum" },
                    { 5, "50% Off", "Crystal" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "19th-century art movement characterized by small, thin brush strokes and emphasis on light and movement.", "Impressionism" },
                    { 2, "A period in European history marking the revival of classical learning and wisdom.", "Renaissance" },
                    { 3, "Art that uses shapes, colors, forms, and gestural marks to achieve its effect rather than depicting objects.", "Abstract" },
                    { 4, "A broad category that reflects artistic work produced during the late 19th to mid-20th century.", "Modern" },
                    { 5, "Art from ancient civilizations, including Egyptian, Mesopotamian, and classical Greek.", "Ancient" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardId", "Email", "LoyaltyId", "Name", "age" },
                values: new object[,]
                {
                    { 1, null, "johndoe@example.com", 1, "John Doe", 30 },
                    { 2, null, "janesmith@example.com", 2, "Jane Smith", 25 },
                    { 3, null, "michaelj@example.com", 3, "Michael Johnson", 35 },
                    { 4, null, "sarahc@example.com", 4, "Sarah Connor", 28 },
                    { 5, null, "tonystark@example.com", 5, "Tony Stark", 45 }
                });

            migrationBuilder.InsertData(
                table: "Arts",
                columns: new[] { "Id", "CategoryId", "Price", "Publication_date", "Title", "userId" },
                values: new object[,]
                {
                    { 1, 1, "100000", new DateTime(1889, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starry Night", null },
                    { 2, 2, "500000", new DateTime(1503, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Mona Lisa", null },
                    { 3, 3, "120000", new DateTime(1923, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Composition VIII", null },
                    { 4, 4, "200000", new DateTime(1931, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Persistence of Memory", null },
                    { 5, 5, "150000", new DateTime(2500, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Pyramid", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arts_CategoryId",
                table: "Arts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Arts_userId",
                table: "Arts",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CardId",
                table: "Users",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
