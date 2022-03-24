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
    
    public class FormDentistaCrud : Form
    {

        Label labelBoasVindas;
        ListView listView;
        ListViewItem newLine;
        Button btInserir;
        Button btUpdate;
        Button btDelete;
        Button btFechar;

        public FormDentistaCrud()
        {
            this.ClientSize = new System.Drawing.Size(500,400);

            labelBoasVindas = new Label();
            labelBoasVindas.Text = "DENTISTAS";
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
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Fone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Registro", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Salario", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Especialidade", -2, HorizontalAlignment.Left);

            listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;

            foreach (Dentista item in DentistaController.VisualizarDentista())
            {
                newLine = new ListViewItem(item.Id.ToString());
                newLine.SubItems.Add(item.Nome);
                newLine.SubItems.Add(item.Cpf);
                newLine.SubItems.Add(item.Fone);
                newLine.SubItems.Add(item.Email);
                newLine.SubItems.Add(item.Registro);
                newLine.SubItems.Add(string.Format("R$ {0:#.00}", Convert.ToDecimal(item.Salario) / 100));
                newLine.SubItems.Add(item.Especialidade.Descricao);
                
                listView.Items.Add(newLine);
            }

            this.Controls.Add(labelBoasVindas);
            this.Controls.Add(listView);
            this.Controls.Add(btInserir);
            this.Controls.Add(btUpdate);
            this.Controls.Add(btDelete);
            this.Controls.Add(btFechar);
        }

        private void btInserirClick(object sender, EventArgs e)
        {
            FormDentistaInsert form = new FormDentistaInsert();
            form.Show();
        }

        private void btUpdateClick(object sender, EventArgs e)
        {
            
        }

        private void btDeleteClick(object sender, EventArgs e)
        {
            ListViewItem itemSelecionado = listView.SelectedItems[0];
            new FormDentistaDelete(Convert.ToInt32(itemSelecionado.Text)).Show();
        }

        private void btFecharClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}