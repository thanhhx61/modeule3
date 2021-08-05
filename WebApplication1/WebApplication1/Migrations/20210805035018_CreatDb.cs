using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class CreatDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classses",
                columns: table => new
                {
                    ClasssId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClasssName = table.Column<string>(maxLength: 250, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classses", x => x.ClasssId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(maxLength: 40, nullable: false),
                    Year = table.Column<string>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ClasssId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Classses_ClasssId",
                        column: x => x.ClasssId,
                        principalTable: "Classses",
                        principalColumn: "ClasssId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Classses",
                columns: new[] { "ClasssId", "ClasssName", "IsDeleted" },
                values: new object[,]
                {
                    { 1, "A1", false },
                    { 2, "A2", false },
                    { 3, "A3", false },
                    { 4, "A4", false },
                    { 5, "A5", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClasssId",
                table: "Students",
                column: "ClasssId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classses");
        }
    }
}
