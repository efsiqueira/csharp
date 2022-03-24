using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Models;
using Controllers;

namespace Views
{
    public class FormAgendamentoInsert : Form
    {
        Label labelPaciente;
        Label labelDentista;
        Label labelSala;
        Label labelData;
        Label labelConfirma;
        TextBox textPaciente;
        TextBox textDentista;
        TextBox textSala;
        DateTimePicker dtPickerData;
        TextBox textConfirma;
        Button btConfirmar;
        Button btFechar;
        public FormAgendamentoInsert()
        {
            this.ClientSize = new System.Drawing.Size(400,420);

            labelPaciente = new Label();
            labelPaciente.Text = "Id Paciente";
            labelPaciente.Location = new Point(20,20);

            labelDentista = new Label();
            labelDentista.Text = "Id Dentista";
            labelDentista.Location = new Point(20,85);

            labelSala = new Label();
            labelSala.Text = "Id Sala";
            labelSala.Location = new Point(210,85);

            labelData = new Label();
            labelData.Text = "Data";
            labelData.Location = new Point(20,150);

            labelConfirma = new Label();
            labelConfirma.Text = "Confirma";
            labelConfirma.Location = new Point(20,215);

            textPaciente = new TextBox();
            textPaciente.Location = new Point(20,45);
            textPaciente.Size = new Size(360,20);

            textDentista = new TextBox();
            textDentista.Location = new Point(20,110);
            textDentista.Size = new Size(175,20);

            textSala = new TextBox();
            textSala.Location = new Point(205,110);
            textSala.Size = new Size(175,20);

            dtPickerData = new DateTimePicker();
            dtPickerData.MinDate = DateTime.Today;
            dtPickerData.Location = new Point(20,175);
            dtPickerData.Format = DateTimePickerFormat.Short;
            dtPickerData.Size = new Size(114,420);

            /*textConfirma = new TextBox();
            textConfirma.Location = new Point(20,240);
            textConfirma.Size = new Size(360,20);*/
            
            btConfirmar = new Button();
            btConfirmar.Text = "Confirmar";
            btConfirmar.Location = new Point(90,360);
            btConfirmar.Size = new Size(100,25);
            btConfirmar.Click += new EventHandler(this.btConfirmarClick);

            btFechar = new Button();
            btFechar.Text = "Fechar";
            btFechar.Location = new Point(210,360);
            btFechar.Size = new Size(100,25);
            btFechar.Click += new EventHandler(this.btFecharClick);

            this.Controls.Add(labelPaciente);
            this.Controls.Add(labelDentista);
            this.Controls.Add(labelSala);
            this.Controls.Add(labelData);
            //this.Controls.Add(labelConfirma);
            this.Controls.Add(textPaciente);
            this.Controls.Add(textDentista);
            this.Controls.Add(textSala);
            this.Controls.Add(dtPickerData);
            //this.Controls.Add(textConfirma);
            this.Controls.Add(btConfirmar);
            this.Controls.Add(btFechar);

        }

        private void btConfirmarClick(object sender, EventArgs e)
        {
            int pacienteId = int.Parse(textPaciente.Text);
            int dentistaId = int.Parse(textDentista.Text);
            int salaId = int.Parse(textSala.Text);
            try
            {
                AgendamentoController.InserirAgendamento(
                pacienteId,
                dentistaId,
                salaId,
                dtPickerData.Value
                );

                MessageBox.Show("Dados inseridos com sucesso.");
                this.Close();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Não foi possível inserir os dados.");
            }
        }

        private void btFecharClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}