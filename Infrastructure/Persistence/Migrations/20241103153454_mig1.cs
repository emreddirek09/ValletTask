using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vallet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteIsApartment = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bloks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlockName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockNumberOfFloors = table.Column<int>(type: "int", nullable: false),
                    SiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bloks_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Daires",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaireFloorNumber = table.Column<int>(type: "int", nullable: false),
                    DaireApartmentNumber = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BlockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Daires_Bloks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Bloks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Daires_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DaireBorcs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DebtAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DebtDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DebtCreatedByAdminId = table.Column<int>(type: "int", nullable: false),
                    DebtDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaireId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaireBorcs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DaireBorcs_Daires_DaireId",
                        column: x => x.DaireId,
                        principalTable: "Daires",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DaireBorcs_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bloks_SiteId",
                table: "Bloks",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_DaireBorcs_DaireId",
                table: "DaireBorcs",
                column: "DaireId");

            migrationBuilder.CreateIndex(
                name: "IX_DaireBorcs_UsersId",
                table: "DaireBorcs",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Daires_BlockId",
                table: "Daires",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Daires_UsersId",
                table: "Daires",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaireBorcs");

            migrationBuilder.DropTable(
                name: "Daires");

            migrationBuilder.DropTable(
                name: "Bloks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Sites");
        }
    }
}
