using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCreationV2.Infra.Migrations
{
    /// <inheritdoc />
    public partial class entidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "status",
                table: "Persons",
                newName: "Time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Persons",
                newName: "status");
        }
    }
}
