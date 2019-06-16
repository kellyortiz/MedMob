using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //criação da tabela Paciente
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    //criação de colunas na tabela c/ integração das entidades 
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rg = table.Column<string>(nullable: false),
                    NomeCompleto = table.Column<string>(nullable: false),
                    NomeConvenio = table.Column<string>(nullable: false),
                    NumeroConvenio = table.Column<string>(nullable: false),
                    DoencaCronica = table.Column<string>(nullable: false),
                    TipoSanguineo = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    UF = table.Column<string>(nullable: false),
                    Pais = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    NomePai = table.Column<string>(nullable: false),
                    NomeMae = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    // declaração da PK 
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });

            // criação da tabela Alergia
            migrationBuilder.CreateTable(
                name: "Alergia",
                columns: table => new
                {
                    // criação de colunas na tabela c/ integração da entidade Alergia
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PacienteId = table.Column<int>(nullable: false),
                    NomeMedicamento = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    // definindo PK e FK da tabela Alergia
                    table.PrimaryKey("PK_Alergia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alergia_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alergia_PacienteId",
                table: "Alergia",
                column: "PacienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alergia");

            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
