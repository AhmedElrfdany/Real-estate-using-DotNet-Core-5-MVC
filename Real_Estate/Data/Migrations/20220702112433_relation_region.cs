using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Real_Estate.Data.Migrations
{
    public partial class relation_region : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "post");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "post");

            migrationBuilder.AddColumn<int>(
                name: "governateId",
                table: "post",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "regionId",
                table: "post",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_post_governateId",
                table: "post",
                column: "governateId");

            migrationBuilder.CreateIndex(
                name: "IX_post_regionId",
                table: "post",
                column: "regionId");

            migrationBuilder.AddForeignKey(
                name: "FK_post_govarnate_governateId",
                table: "post",
                column: "governateId",
                principalTable: "govarnate",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_post_region_regionId",
                table: "post",
                column: "regionId",
                principalTable: "region",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_post_govarnate_governateId",
                table: "post");

            migrationBuilder.DropForeignKey(
                name: "FK_post_region_regionId",
                table: "post");

            migrationBuilder.DropIndex(
                name: "IX_post_governateId",
                table: "post");

            migrationBuilder.DropIndex(
                name: "IX_post_regionId",
                table: "post");

            migrationBuilder.DropColumn(
                name: "governateId",
                table: "post");

            migrationBuilder.DropColumn(
                name: "regionId",
                table: "post");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "post",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "post",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
