using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConcertTickets.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingTicketsAndConcerts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumTickets = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ConcertId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketOffers_Concerts_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumTickets = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    DiscountApplied = table.Column<bool>(type: "bit", nullable: false),
                    TicketOfferId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_TicketOffers_TicketOfferId",
                        column: x => x.TicketOfferId,
                        principalTable: "TicketOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "Artist", "CreatedAt", "Date", "Location", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Taylor Swift", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(839), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koning Boudewijn Stadion, Brussel", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(840) },
                    { 2, "Taylor Swift", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(842), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koning Boudewijn Stadion, Brussel", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(842) },
                    { 3, "Charlie XCX", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(843), new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vorst Nationaal, Brussel", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(844) },
                    { 4, "Compact Disk Dummies", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(845), new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ancienne Belgique, Brussel", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(845) },
                    { 5, "Compact Disk Dummies", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ancienne Belgique, Brussel", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(846) },
                    { 6, "Coldplay", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(847), new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sport Paleis, Antwerpen", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(848) },
                    { 7, "Dua Lipa", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(849), new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werchter", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(849) },
                    { 8, "Dua Lipa", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werchter", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(850) }
                });

            migrationBuilder.InsertData(
                table: "TicketOffers",
                columns: new[] { "Id", "ConcertId", "CreatedAt", "NumTickets", "Price", "TicketType", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(974), 10, 200.0, "Golden Circle", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(974) },
                    { 2, 1, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(976), 50, 50.0, "Standing", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(976) },
                    { 3, 1, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(977), 60, 60.0, "Seated", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(977) },
                    { 4, 2, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(978), 1000, 200.0, "Golden Circle", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(979) },
                    { 5, 2, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(980), 19000, 50.0, "Standing", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(980) },
                    { 6, 2, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(981), 20000, 60.0, "Seated", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(981) },
                    { 7, 3, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(982), 0, 100.0, "Golden Circle", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(982) },
                    { 8, 3, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(983), 0, 28.0, "Standing", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(984) },
                    { 9, 3, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(985), 0, 32.0, "Seated", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(985) },
                    { 10, 4, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(986), 2000, 28.0, "Standing", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(986) },
                    { 11, 4, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(987), 1800, 32.0, "Seated", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(988) },
                    { 12, 5, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(988), 2000, 28.0, "Standing", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(989) },
                    { 13, 5, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(990), 7800, 32.0, "Seated", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(990) },
                    { 14, 6, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(991), 400, 150.0, "Golden Circle", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(991) },
                    { 15, 6, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(992), 4000, 65.0, "Standing", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(993) },
                    { 16, 6, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1035), 4000, 55.0, "Seated", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1035) },
                    { 17, 7, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1036), 1000, 124.0, "Golden Circle", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1037) },
                    { 18, 7, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1038), 20000, 67.0, "Standing", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1038) },
                    { 19, 8, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1039), 2000, 36.0, "Standing", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1039) },
                    { 20, 8, new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1040), 7800, 40.0, "Seated", new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1040) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TicketOfferId",
                table: "Orders",
                column: "TicketOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketOffers_ConcertId",
                table: "TicketOffers",
                column: "ConcertId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "TicketOffers");

            migrationBuilder.DropTable(
                name: "Concerts");
        }
    }
}
