using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDPersonas.Migrations
{
    public partial class OracleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nombre = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Nro_Documento = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Correo_Electronico = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Telefono = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Fecha_Nacimiento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
