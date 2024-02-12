using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AcmeSacHotel2024.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class InicioDbContexto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hotelAcmes",
                columns: table => new
                {
                    HotelAcmeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_hotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    des_hotel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pre_hotel = table.Column<double>(type: "float", nullable: false),
                    m2_hotel = table.Column<int>(type: "int", nullable: false),
                    cap_hotel = table.Column<int>(type: "int", nullable: false),
                    img_hotel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotelAcmes", x => x.HotelAcmeId);
                });

            migrationBuilder.InsertData(
                table: "hotelAcmes",
                columns: new[] { "HotelAcmeId", "CreateDate", "UpdateDate", "cap_hotel", "des_hotel", "img_hotel", "m2_hotel", "nom_hotel", "pre_hotel" },
                values: new object[,]
                {
                    { 1, null, null, 4, "Aquí va la descripción breve de los servicios  que brinda el hotel", "https://placehold.co/600x400", 250, "Nombre hotel 1", 150.0 },
                    { 2, null, null, 3, "Aquí va la descripción breve de los servicios  que brinda el hotel", "https://placehold.co/600x400", 50, "Nombre hotel 2", 50.0 },
                    { 3, null, null, 14, "Aquí va la descripción breve de los servicios  que brinda el hotel", "https://placehold.co/600x400", 450, "Nombre hotel 3", 450.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hotelAcmes");
        }
    }
}
