﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSS_Clothes.Migrations
{
    public partial class DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Clothes_ClotheID",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.RenameTable(
                name: "Image",
                newName: "Images");

            migrationBuilder.RenameIndex(
                name: "IX_Image_ClotheID",
                table: "Images",
                newName: "IX_Images_ClotheID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Clothes_ClotheID",
                table: "Images",
                column: "ClotheID",
                principalTable: "Clothes",
                principalColumn: "ClotheID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Clothes_ClotheID",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "Image");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ClotheID",
                table: "Image",
                newName: "IX_Image_ClotheID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Clothes_ClotheID",
                table: "Image",
                column: "ClotheID",
                principalTable: "Clothes",
                principalColumn: "ClotheID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
