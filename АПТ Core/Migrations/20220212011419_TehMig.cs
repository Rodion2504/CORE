using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace АПТ_Core.Migrations
{
    public partial class TehMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stud",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Im = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rost = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    St_Ball = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stipendiya = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud");
        }
    }
}
