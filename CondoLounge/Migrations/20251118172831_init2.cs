using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondoLounge.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserCondo_Condo_CondosId",
                table: "ApplicationUserCondo");

            migrationBuilder.DropForeignKey(
                name: "FK_Condo_Building_BuildingId",
                table: "Condo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Condo",
                table: "Condo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building",
                table: "Building");

            migrationBuilder.RenameTable(
                name: "Condo",
                newName: "Condos");

            migrationBuilder.RenameTable(
                name: "Building",
                newName: "Buildings");

            migrationBuilder.RenameIndex(
                name: "IX_Condo_CondoNumber_BuildingId",
                table: "Condos",
                newName: "IX_Condos_CondoNumber_BuildingId");

            migrationBuilder.RenameIndex(
                name: "IX_Condo_BuildingId",
                table: "Condos",
                newName: "IX_Condos_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Condos",
                table: "Condos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buildings",
                table: "Buildings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserCondo_Condos_CondosId",
                table: "ApplicationUserCondo",
                column: "CondosId",
                principalTable: "Condos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Condos_Buildings_BuildingId",
                table: "Condos",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserCondo_Condos_CondosId",
                table: "ApplicationUserCondo");

            migrationBuilder.DropForeignKey(
                name: "FK_Condos_Buildings_BuildingId",
                table: "Condos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Condos",
                table: "Condos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buildings",
                table: "Buildings");

            migrationBuilder.RenameTable(
                name: "Condos",
                newName: "Condo");

            migrationBuilder.RenameTable(
                name: "Buildings",
                newName: "Building");

            migrationBuilder.RenameIndex(
                name: "IX_Condos_CondoNumber_BuildingId",
                table: "Condo",
                newName: "IX_Condo_CondoNumber_BuildingId");

            migrationBuilder.RenameIndex(
                name: "IX_Condos_BuildingId",
                table: "Condo",
                newName: "IX_Condo_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Condo",
                table: "Condo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building",
                table: "Building",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserCondo_Condo_CondosId",
                table: "ApplicationUserCondo",
                column: "CondosId",
                principalTable: "Condo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Condo_Building_BuildingId",
                table: "Condo",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
