using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finly.Migrations
{
    public partial class AddCompanyClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegisteredCompanyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CompanyNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IncorporationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyType = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyClients_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyClientSICCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyClientId = table.Column<int>(type: "int", nullable: false),
                    SICCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyClientSICCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyClientSICCodes_CompanyClients_CompanyClientId",
                        column: x => x.CompanyClientId,
                        principalTable: "CompanyClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyClients_ProfileId",
                table: "CompanyClients",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyClientSICCodes_CompanyClientId",
                table: "CompanyClientSICCodes",
                column: "CompanyClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyClientSICCodes");

            migrationBuilder.DropTable(
                name: "CompanyClients");
        }
    }
}
