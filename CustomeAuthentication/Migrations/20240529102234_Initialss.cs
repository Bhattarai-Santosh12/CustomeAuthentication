using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomeAuthentication.Migrations
{
    /// <inheritdoc />
    public partial class Initialss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserNmae",
                table: "UserAccounts",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserAccounts",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "UserAccounts",
                newName: "UserNmae");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "UserAccounts",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
