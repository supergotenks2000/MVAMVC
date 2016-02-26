using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace MVAMVC.Migrations
{
    public partial class ProductCategoryID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Product_Category_CategoryId", table: "Product");
            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Product",
                newName: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Product_Category_CategoryId", table: "Product");
            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Product",
                newName: "CategoryId");
        }
    }
}
