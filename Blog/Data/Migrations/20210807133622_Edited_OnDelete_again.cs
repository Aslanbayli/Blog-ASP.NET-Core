using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class Edited_OnDelete_again : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTranslation_Post_PostId",
                table: "PostTranslation");

            migrationBuilder.AddForeignKey(
                name: "FK_PostTranslation_Post_PostId",
                table: "PostTranslation",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTranslation_Post_PostId",
                table: "PostTranslation");

            migrationBuilder.AddForeignKey(
                name: "FK_PostTranslation_Post_PostId",
                table: "PostTranslation",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id");
        }
    }
}
