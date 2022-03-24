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
    
    public class FormAgendamentoCrud : Form
    {

        Label labelBoasVindas;
        ListView listView;
        ListViewItem newLine;
        Button btInserir;
        Button btUpdate;
        Button btDelete;
        Button btFechar;

        public FormAgendamentoCrud()
        {
            this.ClientSize = new System.Drawing.Size(500,400);

            labelBoasVindas = new Label();
            labelBoasVindas.Text = "AGENDAMENTOS";
            labelBoasVindas.Location = new Point(0,20);
            labelBoasVindas.TextAlign = ContentAlignment.MiddleCenter;
            labelBoasVindas.Size = new Size(500,15);

            listView = new ListView();
            listView.Location = new Point(20,50);
            listView.Size = new Size(460,260);
            listView.View = View.Details;

            btInserir = new Button();
            btInserir.Text = "Inserir";
            btInserir.Size = new Size(100,30);
            btInserir.Location = new Point(20,340);
            btInserir.Click += new EventHandler(this.btInserirClick);

            btUpdate = new Button();
            btUpdate.Text = "Update";
            btUpdate.Size = new Size(100,30);
            btUpdate.Location = new Point(140,340);
            btUpdate.Click += new EventHandler(this.btUpdateClick);

            btDelete = new Button();
            btDelete.Text = "Delete";
            btDelete.Size = new Size(100,30);
            btDelete.Location = new Point(260,340);
            btDelete.Click += new EventHandler(this.btDeleteClick);

            btFechar = new Button();
            btFechar.Text = "Fechar";
            btFechar.Size = new Size(100,30);
            btFechar.Location = new Point(380,340);
            btFechar.Click += new EventHandler(this.btFecharClick);
            
            listView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Paciente", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Dentista", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Sala", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Confirmado?", -2, HorizontalAlignment.Left);
            
            listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
            
            try {
                foreach (Agendamento item in AgendamentoController.VisualizarAgendamento())
                {
                    newLine = new ListViewItem(item.Id.ToString());
                    newLine.SubItems.Add(item.Paciente.Nome);          
                    newLine.SubItems.Add(item.Dentista.Nome);                
                    newLine.SubItems.Add(item.Sala.Numero);  
                    newLine.SubItems.Add(item.Data.ToString());                
                    newLine.SubItems.Add(item.Confirmado.ToString());

                    listView.Items.Add(newLine);
                }
            }
            catch
            {
            }

            /*foreach (Agendamento item in AgendamentoController.VisualizarAgendamento())
            {
                newLine = new ListViewItem(item.Id.ToString());
                newLine.SubItems.Add(item.PacienteId.ToString());   
                newLine.SubItems.Add(item.DentistaId.ToString());                
                newLine.SubItems.Add(item.SalaId.ToString());  
                newLine.SubItems.Add(item.Data.ToString());                
                newLine.SubItems.Add(item.Confirmado.ToString());

                listView.Items.Add(newLine);
            }*/

            this.Controls.Add(labelBoasVindas);
            this.Controls.Add(listView);
            this.Controls.Add(btInserir);
            this.Controls.Add(btUpdate);
            this.Controls.Add(btDelete);
            this.Controls.Add(btFechar);
        }

        private void btInserirClick(object sender, EventArgs e)
        {
            //FormAgendamentoInsert form = new FormAgendamentoInsert();
            //form.Show();
        }

        private void btUpdateClick(object sender, EventArgs e)
        {
            //FormAgendamentoInsert form = new FormAgendamentoInsert();
            //form.Show();
        }

        private void btDeleteClick(object sender, EventArgs e)
        {
            //FormAgendamentoInsert form = new FormAgendamentoInsert();
            //form.Show();
        }

        private void btFecharClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}