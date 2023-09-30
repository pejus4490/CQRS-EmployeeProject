using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 10, 14, 55, 670, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 6, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 10, 14, 55, 670, DateTimeKind.Unspecified).AddTicks(8570), new TimeSpan(0, 6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 10, 14, 55, 671, DateTimeKind.Unspecified).AddTicks(1852), new TimeSpan(0, 6, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 10, 14, 55, 671, DateTimeKind.Unspecified).AddTicks(1864), new TimeSpan(0, 6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 26, 9, 32, 46, 89, DateTimeKind.Unspecified).AddTicks(8325), new TimeSpan(0, 6, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 26, 9, 32, 46, 89, DateTimeKind.Unspecified).AddTicks(8352), new TimeSpan(0, 6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 26, 9, 32, 46, 90, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 6, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 26, 9, 32, 46, 90, DateTimeKind.Unspecified).AddTicks(2066), new TimeSpan(0, 6, 0, 0, 0)) });
        }
    }
}
