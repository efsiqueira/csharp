using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Models;

namespace Views
{
    
    public class FormDentista : Form
    {
        Label labelBoasVindas;
        Button buttonDentista;
        Button buttonPaciente;
        Button buttonProcedimento;
        Button buttonEspecialidade;
        Button buttonSala;
        Button buttonAgendamento;
        Button buttonFechar;

        public FormDentista()
        {
            this.ClientSize = new System.Drawing.Size(260,220);
            this.Text = "Dentista";

            labelBoasVindas = new Label();
            labelBoasVindas.Text = $"Olá, {Auth.Dentista.Nome}";
            labelBoasVindas.Location = new Point(0,10);
            labelBoasVindas.TextAlign = ContentAlignment.MiddleCenter;
            labelBoasVindas.Size = new Size(260,15);

            buttonDentista = new Button();
            buttonDentista.Text = "Dentista";
            buttonDentista.Size = new Size(100,30);
            buttonDentista.Location = new Point(25, 40);
            buttonDentista.Click += new EventHandler(this.buttonDentistaClick);

            buttonPaciente = new Button();
            buttonPaciente.Text = "Paciente";
            buttonPaciente.Size = new Size(100,30);
            buttonPaciente.Location = new Point(135, 40);
            buttonPaciente.Click += new EventHandler(this.buttonPacienteClick);

            buttonProcedimento = new Button();
            buttonProcedimento.Text = "Procedimento";
            buttonProcedimento.Size = new Size(100,30);
            buttonProcedimento.Location = new Point(25, 80);
            //buttonDentista.Click += new EventHandler(this.buttonDentistaClick);

            buttonEspecialidade = new Button();
            buttonEspecialidade.Text = "Especialidade";
            buttonEspecialidade.Size = new Size(100,30);
            buttonEspecialidade.Location = new Point(135, 80);
            buttonEspecialidade.Click += new EventHandler(this.buttonEspecialidadeClick);

            buttonSala = new Button();
            buttonSala.Text = "Sala";
            buttonSala.Size = new Size(100,30);
            buttonSala.Location = new Point(25, 120);
            //buttonDentista.Click += new EventHandler(this.buttonDentistaClick);

            buttonAgendamento = new Button();
            buttonAgendamento.Text = "Agendamento";
            buttonAgendamento.Size = new Size(100,30);
            buttonAgendamento.Location = new Point(135, 120);
            //buttonDentista.Click += new EventHandler(this.buttonDentistaClick);

            buttonFechar = new Button();
            buttonFechar.Text = "Fechar";
            buttonFechar.Size = new Size(100,30);
            buttonFechar.Location = new Point(80, 175);
            buttonFechar.Click += new EventHandler(this.buttonFecharClick);

            this.Controls.Add(labelBoasVindas);

            this.Controls.Add(buttonDentista);
            this.Controls.Add(buttonPaciente);
            this.Controls.Add(buttonProcedimento);
            this.Controls.Add(buttonEspecialidade);
            this.Controls.Add(buttonSala);
            this.Controls.Add(buttonAgendamento);
            this.Controls.Add(buttonFechar);
        }

        private void buttonDentistaClick(object sender, EventArgs e)
        {
            FormDentistaCrud form = new FormDentistaCrud();
            form.Show();
        }

        private void buttonPacienteClick(object sender, EventArgs e)
        {
            FormPacienteCrud form = new FormPacienteCrud();
            form.Show();
        }

        private void buttonProcedimentoClick(object sender, EventArgs e)
        {
            
        }

        private void buttonEspecialidadeClick(object sender, EventArgs e)
        {
            FormEspecialidadeCrud form = new FormEspecialidadeCrud();
            form.Show();
        }

        private void buttonSalaClick(object sender, EventArgs e)
        {
            
        }

        private void buttonAgendamentoClick(object sender, EventArgs e)
        {
            
        }

        private void buttonFecharClick(object sender, EventArgs e)
        {
            this.Close();
            FormLogin form = new FormLogin();
            form.Show();
        }
    }
}