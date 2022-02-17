using Microsoft.EntityFrameworkCore.Migrations;

namespace Bereschi_Gabriel_Depozit.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDProprietar",
                table: "Depozit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProprietarID",
                table: "Depozit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Produs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    Greutate = table.Column<int>(nullable: false),
                    Vanzator = table.Column<string>(nullable: true),
                    Depozit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Proprietar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietar", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Depozit_ProprietarID",
                table: "Depozit",
                column: "ProprietarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Depozit_Proprietar_ProprietarID",
                table: "Depozit",
                column: "ProprietarID",
                principalTable: "Proprietar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Depozit_Proprietar_ProprietarID",
                table: "Depozit");

            migrationBuilder.DropTable(
                name: "Produs");

            migrationBuilder.DropTable(
                name: "Proprietar");

            migrationBuilder.DropIndex(
                name: "IX_Depozit_ProprietarID",
                table: "Depozit");

            migrationBuilder.DropColumn(
                name: "IDProprietar",
                table: "Depozit");

            migrationBuilder.DropColumn(
                name: "ProprietarID",
                table: "Depozit");
        }
    }
}
