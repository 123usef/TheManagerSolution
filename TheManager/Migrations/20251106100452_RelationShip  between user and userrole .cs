using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheManager.Migrations
{
    /// <inheritdoc />
    public partial class RelationShipbetweenuseranduserrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserRoleid",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_users_UserRoleid",
                table: "users",
                column: "UserRoleid");

            migrationBuilder.AddForeignKey(
                name: "FK_users_userRoles_UserRoleid",
                table: "users",
                column: "UserRoleid",
                principalTable: "userRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_userRoles_UserRoleid",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_UserRoleid",
                table: "users");

            migrationBuilder.DropColumn(
                name: "UserRoleid",
                table: "users");
        }
    }
}
