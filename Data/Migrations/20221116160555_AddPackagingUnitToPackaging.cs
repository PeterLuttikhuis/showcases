using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPackagingUnitToPackaging : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PackagingUnitId",
                table: "Packages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PackagingUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingUnits", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackagingUnitId",
                table: "Packages",
                column: "PackagingUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_PackagingUnits_PackagingUnitId",
                table: "Packages",
                column: "PackagingUnitId",
                principalTable: "PackagingUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_PackagingUnits_PackagingUnitId",
                table: "Packages");

            migrationBuilder.DropTable(
                name: "PackagingUnits");

            migrationBuilder.DropIndex(
                name: "IX_Packages_PackagingUnitId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "PackagingUnitId",
                table: "Packages");
        }
    }
}
