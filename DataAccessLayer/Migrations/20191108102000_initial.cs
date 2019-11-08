using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    OnBoardDate = table.Column<DateTime>(type: "Date", nullable: false),
                    AnnualLeave = table.Column<int>(nullable: false, defaultValue: 0),
                    RemainAnnual = table.Column<int>(nullable: false, defaultValue: 0),
                    BirthDay = table.Column<DateTime>(type: "Date", nullable: false),
                    Phone = table.Column<string>(unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    Kind = table.Column<short>(nullable: false),
                    LeaveStart = table.Column<DateTime>(type: "Date", nullable: false),
                    LeaveEnd = table.Column<DateTime>(type: "Date", nullable: false),
                    LeaveTime = table.Column<int>(nullable: false),
                    Reason = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Leaves");
        }
    }
}
