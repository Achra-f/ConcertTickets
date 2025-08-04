using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcertTickets.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "Orders",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7873), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7876), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7878), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7879), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7880), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7882), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7883), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7884), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7994), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7996), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7997), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7999), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8000), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8001), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8003), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8004), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8005), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8007), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8008), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8009), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8010), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8012), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8013), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8014), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8016), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8017), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8018), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8019), new DateTime(2025, 1, 16, 21, 36, 19, 754, DateTimeKind.Utc).AddTicks(8020) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(839), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(842), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(843), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(845), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(847), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(849), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(974), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(976), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(977), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(978), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(980), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(981), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(982), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(983), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(985), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(986), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(987), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(988), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(990), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(991), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(992), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1035), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1036), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1038), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1039), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "TicketOffers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1040), new DateTime(2025, 1, 8, 0, 9, 8, 190, DateTimeKind.Utc).AddTicks(1040) });
        }
    }
}
