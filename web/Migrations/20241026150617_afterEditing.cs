using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Migrations
{
    public partial class afterEditing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cards_CardId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CardId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LoyaltyId",
                table: "Users",
                column: "LoyaltyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cards_LoyaltyId",
                table: "Users",
                column: "LoyaltyId",
                principalTable: "Cards",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cards_LoyaltyId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LoyaltyId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CardId",
                table: "Users",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cards_CardId",
                table: "Users",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id");
        }
    }
}
