using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentCar.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aracs",
                columns: table => new
                {
                    AracId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aracModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    besgünFiyat = table.Column<int>(type: "int", nullable: false),
                    onbesgünFiyat = table.Column<int>(type: "int", nullable: false),
                    otuzgünFiyat = table.Column<int>(type: "int", nullable: false),
                    fotoUrl = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracs", x => x.AracId);
                });

            migrationBuilder.CreateTable(
                name: "yorum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yorum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AracId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yorum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_yorum_aracs_AracId",
                        column: x => x.AracId,
                        principalTable: "aracs",
                        principalColumn: "AracId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "uye",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uye", x => x.Id);
                    table.ForeignKey(
                        name: "FK_uye_yorum_YorumId",
                        column: x => x.YorumId,
                        principalTable: "yorum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_uye_YorumId",
                table: "uye",
                column: "YorumId");

            migrationBuilder.CreateIndex(
                name: "IX_yorum_AracId",
                table: "yorum",
                column: "AracId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "uye");

            migrationBuilder.DropTable(
                name: "yorum");

            migrationBuilder.DropTable(
                name: "aracs");
        }
    }
}
