using Microsoft.EntityFrameworkCore.Migrations;

namespace C_Project.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_FriendLists_UserId",
                table: "FriendLists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FriendLists_Users_UserId",
                table: "FriendLists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FriendLists_Users_UserId",
                table: "FriendLists");

            migrationBuilder.DropIndex(
                name: "IX_FriendLists_UserId",
                table: "FriendLists");
        }
    }
}
