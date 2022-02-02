using Microsoft.EntityFrameworkCore.Migrations;

namespace refresh_tokens_api.Migrations
{
    public partial class UpdateUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResonRevoked",
                table: "RefreshTokens",
                newName: "ReasonRevoked");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReasonRevoked",
                table: "RefreshTokens",
                newName: "ResonRevoked");
        }
    }
}
