using Microsoft.EntityFrameworkCore.Migrations;

namespace Secret_Santa.Migrations
{
    public partial class insert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_GiftedFriendId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_GiftedFriendId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "GiftedFriendId",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "GiftedFriend",
                table: "Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GiftedFriend",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "GiftedFriendId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GiftedFriendId",
                table: "Persons",
                column: "GiftedFriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_GiftedFriendId",
                table: "Persons",
                column: "GiftedFriendId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
