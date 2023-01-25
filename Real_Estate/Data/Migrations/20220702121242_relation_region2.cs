using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Real_Estate.Data.Migrations
{
    public partial class relation_region2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_post_govarnate_governateId",
                table: "post");

            migrationBuilder.AlterColumn<int>(
                name: "governateId",
                table: "post",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_post_govarnate_governateId",
                table: "post",
                column: "governateId",
                principalTable: "govarnate",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_post_govarnate_governateId",
                table: "post");

            migrationBuilder.AlterColumn<int>(
                name: "governateId",
                table: "post",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_post_govarnate_governateId",
                table: "post",
                column: "governateId",
                principalTable: "govarnate",
                principalColumn: "id");
        }
    }
}
