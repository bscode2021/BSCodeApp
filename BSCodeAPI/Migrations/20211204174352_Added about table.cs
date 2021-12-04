using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSCodeAPI.Migrations
{
    public partial class Addedabouttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_about",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AboutPoints = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    LastThought = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_about", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_about");
        }
    }
}
