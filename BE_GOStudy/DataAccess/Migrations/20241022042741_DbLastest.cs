using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class DbLastest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 4, 27, 41, 378, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 4, 27, 41, 378, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 4, 27, 41, 378, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 4, 27, 41, 378, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 4, 27, 41, 378, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 4, 27, 41, 378, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 4, 27, 41, 378, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 4, 27, 41, 378, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 4, 27, 41, 378, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 4, 27, 41, 378, DateTimeKind.Utc).AddTicks(9830));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 31, 37, 835, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 31, 37, 835, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 31, 37, 835, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 31, 37, 835, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 31, 37, 835, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 31, 37, 835, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 31, 37, 835, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 31, 37, 835, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 31, 37, 835, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 2, 31, 37, 835, DateTimeKind.Utc).AddTicks(9600));
        }
    }
}
