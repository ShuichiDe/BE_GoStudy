﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class UpdateDNewFieldBlogb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var columnExistsCheck1 = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
                                WHERE TABLE_NAME = 'BlogPosts' AND COLUMN_NAME = 'Category')
                            BEGIN
                                ALTER TABLE [BlogPosts] ADD [Category] nvarchar(max) NULL;
                            END";

            migrationBuilder.Sql(columnExistsCheck1);

            // Kiểm tra nếu cột 'Tags' chưa tồn tại trong bảng 'BlogPosts' thì mới thêm
            var columnExistsCheck2 = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
                                WHERE TABLE_NAME = 'BlogPosts' AND COLUMN_NAME = 'Tags')
                            BEGIN
                                ALTER TABLE [BlogPosts] ADD [Tags] nvarchar(max) NULL;
                            END";

            migrationBuilder.Sql(columnExistsCheck2);
            
            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -10,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 21, 1, 912, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -9,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 21, 1, 912, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 21, 1, 912, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 21, 1, 912, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 21, 1, 912, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 21, 1, 912, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 21, 1, 912, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 21, 1, 912, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 21, 1, 912, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 21, 1, 912, DateTimeKind.Utc).AddTicks(3060));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -10,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 11, 6, 280, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -9,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 11, 6, 280, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 11, 6, 280, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 11, 6, 280, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 11, 6, 280, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 11, 6, 280, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 11, 6, 280, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 11, 6, 280, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 11, 6, 280, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "ClassroomId",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 2, 2, 11, 6, 280, DateTimeKind.Utc).AddTicks(4250));
        }
    }
}
