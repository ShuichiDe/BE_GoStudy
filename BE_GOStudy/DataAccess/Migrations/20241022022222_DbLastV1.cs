using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class DbLastV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 22, 22, 481, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 22, 22, 481, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 22, 22, 481, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 22, 22, 481, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 22, 22, 481, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 22, 22, 481, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 22, 22, 481, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 22, 22, 481, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 22, 22, 481, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 22, 22, 481, DateTimeKind.Utc).AddTicks(2210));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 13, 3, 47, 484, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 13, 3, 47, 484, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 13, 3, 47, 484, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 13, 3, 47, 484, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 13, 3, 47, 484, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 13, 3, 47, 484, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 13, 3, 47, 484, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 13, 3, 47, 484, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 13, 3, 47, 484, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 13, 3, 47, 484, DateTimeKind.Utc).AddTicks(4000));
        }
    }
}
