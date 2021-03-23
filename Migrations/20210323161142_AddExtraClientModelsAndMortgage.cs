using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finly.Migrations
{
    public partial class AddExtraClientModelsAndMortgage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SICCode",
                table: "CompanyClientSICCodes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IncorporationDate",
                table: "CompanyClients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyType",
                table: "CompanyClients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Clients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalInsuranceNumber",
                table: "Clients",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredName",
                table: "Clients",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SmokerStatus",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SmokingQuitDate",
                table: "Clients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Title",
                table: "Clients",
                type: "int",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClientMarketingConsents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsentType = table.Column<int>(type: "int", nullable: false),
                    ConsentGivenDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientConsentedDirectly = table.Column<bool>(type: "bit", nullable: false),
                    HowWasConsentObtained = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsentRetractedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientMarketingConsents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientMarketingConsents_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientPreviousNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateOfNameChange = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPreviousNames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientPreviousNames_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mortgages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    CompanyClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mortgages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mortgages_CompanyClients_CompanyClientId",
                        column: x => x.CompanyClientId,
                        principalTable: "CompanyClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mortgages_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MortgageClient",
                columns: table => new
                {
                    MortgageId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MortgageClient", x => new { x.MortgageId, x.ClientId });
                    table.ForeignKey(
                        name: "FK_MortgageClient_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MortgageClient_Mortgages_MortgageId",
                        column: x => x.MortgageId,
                        principalTable: "Mortgages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientMarketingConsents_ClientId",
                table: "ClientMarketingConsents",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPreviousNames_ClientId",
                table: "ClientPreviousNames",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_MortgageClient_ClientId",
                table: "MortgageClient",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Mortgages_CompanyClientId",
                table: "Mortgages",
                column: "CompanyClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Mortgages_ProfileId",
                table: "Mortgages",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientMarketingConsents");

            migrationBuilder.DropTable(
                name: "ClientPreviousNames");

            migrationBuilder.DropTable(
                name: "MortgageClient");

            migrationBuilder.DropTable(
                name: "Mortgages");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "NationalInsuranceNumber",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PreferredName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SmokerStatus",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SmokingQuitDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "SICCode",
                table: "CompanyClientSICCodes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IncorporationDate",
                table: "CompanyClients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyType",
                table: "CompanyClients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
