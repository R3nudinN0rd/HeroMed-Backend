﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeroMed_API.Migrations
{
    public partial class FirstTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fdbe311-ac30-4a06-be2c-0fcc779b9246"),
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 12, 11, 17, 48, 44, 337, DateTimeKind.Unspecified).AddTicks(2117), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fdbe311-ac30-4a06-be2c-0fcc779b9247"),
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 12, 11, 17, 48, 44, 337, DateTimeKind.Unspecified).AddTicks(2127), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fdbe311-ac30-4a06-be2c-0fcc779b9248"),
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 12, 11, 17, 48, 44, 337, DateTimeKind.Unspecified).AddTicks(2130), new TimeSpan(0, 2, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fdbe311-ac30-4a06-be2c-0fcc779b9246"),
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 12, 2, 0, 32, 38, 985, DateTimeKind.Unspecified).AddTicks(347), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fdbe311-ac30-4a06-be2c-0fcc779b9247"),
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 12, 2, 0, 32, 38, 985, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fdbe311-ac30-4a06-be2c-0fcc779b9248"),
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 12, 2, 0, 32, 38, 985, DateTimeKind.Unspecified).AddTicks(368), new TimeSpan(0, 2, 0, 0, 0)));
        }
    }
}
