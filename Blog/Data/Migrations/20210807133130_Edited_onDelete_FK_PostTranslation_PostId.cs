using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class Edited_onDelete_FK_PostTranslation_PostId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTranslation_Post_PostId",
                table: "PostTranslation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedAt",
                table: "PostTranslation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChanged",
                table: "PostTranslation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PostTranslation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_PostTranslation_Post_PostId",
                table: "PostTranslation",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTranslation_Post_PostId",
                table: "PostTranslation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedAt",
                table: "PostTranslation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChanged",
                table: "PostTranslation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PostTranslation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTranslation_Post_PostId",
                table: "PostTranslation",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
