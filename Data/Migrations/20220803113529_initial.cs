using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trenler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trenler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wagons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capasity = table.Column<int>(type: "int", nullable: false),
                    fullseat = table.Column<int>(type: "int", nullable: false),
                    TrenId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wagons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wagons_Trenler_TrenId",
                        column: x => x.TrenId,
                        principalTable: "Trenler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Trenler",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Başkent Express" },
                    { 2, "Doğu Express" },
                    { 3, "Çukurova Express" },
                    { 4, "İst-Ank YHT" }
                });

            migrationBuilder.InsertData(
                table: "Wagons",
                columns: new[] { "Id", "Capasity", "Name", "TrenId", "fullseat" },
                values: new object[,]
                {
                    { 1, 100, "Vagon 1", 1, 64 },
                    { 2, 90, "Vagon 2", 1, 75 },
                    { 3, 110, "Vagon 3", 1, 61 },
                    { 4, 100, "Vagon 4", 1, 88 },
                    { 5, 100, "Vagon 1", 2, 64 },
                    { 6, 70, "Vagon 2", 2, 70 },
                    { 7, 110, "Vagon 3", 2, 51 },
                    { 8, 120, "Vagon 4", 2, 84 },
                    { 9, 90, "Vagon 1", 3, 74 },
                    { 10, 95, "Vagon 2", 3, 70 },
                    { 11, 110, "Vagon 3", 3, 81 },
                    { 12, 120, "Vagon 4", 3, 88 },
                    { 13, 90, "Vagon 1", 4, 65 },
                    { 14, 90, "Vagon 2", 4, 79 },
                    { 15, 100, "Vagon 3", 4, 61 },
                    { 16, 100, "Vagon 4", 4, 82 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wagons_TrenId",
                table: "Wagons",
                column: "TrenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wagons");

            migrationBuilder.DropTable(
                name: "Trenler");
        }
    }
}
