using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace MVAMVC.Migrations
{
    public partial class CategoryDisplayName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Product_Category_CategoryId", table: "Product");
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "Category",
                nullable: false,
                defaultValue: "");
            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Product_Category_CategoryId", table: "Product");
            migrationBuilder.DropColumn(name: "DisplayName", table: "Category");
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                nullable: false);
            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
