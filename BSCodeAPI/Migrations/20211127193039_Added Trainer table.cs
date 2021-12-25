using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BSCodeAPI.Migrations
{
    public partial class AddedTrainertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TrainerID",
                table: "tbl_project",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "tbl_trainer",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Specialty = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwiterURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramURl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedinURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_trainer", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_project_TrainerID",
                table: "tbl_project",
                column: "TrainerID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_project_tbl_trainer_TrainerID",
                table: "tbl_project",
                column: "TrainerID",
                principalTable: "tbl_trainer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_project_tbl_trainer_TrainerID",
                table: "tbl_project");

            migrationBuilder.DropTable(
                name: "tbl_trainer");

            migrationBuilder.DropIndex(
                name: "IX_tbl_project_TrainerID",
                table: "tbl_project");

            migrationBuilder.DropColumn(
                name: "TrainerID",
                table: "tbl_project");
        }
    }
}
