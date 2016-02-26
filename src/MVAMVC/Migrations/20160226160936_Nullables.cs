using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace MVAMVC.Migrations
{
    public partial class Nullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Product_Category_CategoryId", table: "Product");
            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "Product",
                nullable: false);
            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Product_Category_CategoryId", table: "Product");
            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "Product",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
