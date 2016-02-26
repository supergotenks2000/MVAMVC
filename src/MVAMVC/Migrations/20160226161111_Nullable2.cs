using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace MVAMVC.Migrations
{
    public partial class Nullable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "MSRP",
                table: "Product",
                nullable: true);
            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentPrice",
                table: "Product",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "MSRP",
                table: "Product",
                nullable: false);
            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentPrice",
                table: "Product",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Product",
                nullable: false);
        }
    }
}
