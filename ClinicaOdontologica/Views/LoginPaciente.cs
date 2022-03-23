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
    
    public class FormPaciente : Form
    {
        ListView listView;
        Button btConfirmar;
        Button btFechar;

        public FormPaciente()
        {
            this.ClientSize = new System.Drawing.Size(260,300);
            this.Text = "Paciente";

            listView = new ListView();
            listView.Location = new Point(20,50);
            listView.Size = new Size(220,180);
            listView.View = View.Details;
            
            btConfirmar = new Button();
            btConfirmar.Text = "Confirmar";
            btConfirmar.Size = new Size(105,30);
            btConfirmar.Location = new Point(20, 250);
            btConfirmar.Click += new EventHandler(this.btConfirmarClick);

            btFechar = new Button();
            btFechar.Text = "Fechar";
            btFechar.Size = new Size(105,30);
            btFechar.Location = new Point(135, 250);
            btFechar.Click += new EventHandler(this.btFecharClick);

            listView.Columns.Add("Dentista", -2, HorizontalAlignment.Center);
            listView.Columns.Add("Data", -2, HorizontalAlignment.Center);
            listView.Columns.Add("Sala", -2, HorizontalAlignment.Center);
            listView.Columns.Add("Check", -2, HorizontalAlignment.Center);

            this.Controls.Add(listView);
            this.Controls.Add(btConfirmar);
            this.Controls.Add(btFechar);
        }

        private void btConfirmarClick(object sender, EventArgs e)
        {
            FormConfirmarAgendamento form = new FormConfirmarAgendamento();
            form.Show();
        }
        private void btFecharClick(object sender, EventArgs e)
        {
            this.Close();
            FormLogin form = new FormLogin();
            form.Show();
        }
    }
}