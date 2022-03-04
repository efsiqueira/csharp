using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaOdontologica.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAgendamento",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "IdProcedimento",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "IdDentista",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "IdSala",
                table: "Agendamentos");

            migrationBuilder.AddColumn<int>(
                name: "AgendamentoId",
                table: "Atendimentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProcedimentoId",
                table: "Atendimentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DentistaId",
                table: "Agendamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Agendamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Agendamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_AgendamentoId",
                table: "Atendimentos",
                column: "AgendamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_ProcedimentoId",
                table: "Atendimentos",
                column: "ProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_DentistaId",
                table: "Agendamentos",
                column: "DentistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_PacienteId",
                table: "Agendamentos",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_SalaId",
                table: "Agendamentos",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Dentistas_DentistaId",
                table: "Agendamentos",
                column: "DentistaId",
                principalTable: "Dentistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Pacientes_PacienteId",
                table: "Agendamentos",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Salas_SalaId",
                table: "Agendamentos",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Agendamentos_AgendamentoId",
                table: "Atendimentos",
                column: "AgendamentoId",
                principalTable: "Agendamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Procedimentos_ProcedimentoId",
                table: "Atendimentos",
                column: "ProcedimentoId",
                principalTable: "Procedimentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Dentistas_DentistaId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Pacientes_PacienteId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Salas_SalaId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Agendamentos_AgendamentoId",
                table: "Atendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Procedimentos_ProcedimentoId",
                table: "Atendimentos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_AgendamentoId",
                table: "Atendimentos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_ProcedimentoId",
                table: "Atendimentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_DentistaId",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_PacienteId",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_SalaId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "AgendamentoId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "ProcedimentoId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "DentistaId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Agendamentos");

            migrationBuilder.AddColumn<int>(
                name: "IdAgendamento",
                table: "Atendimentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProcedimento",
                table: "Atendimentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDentista",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPaciente",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSala",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
