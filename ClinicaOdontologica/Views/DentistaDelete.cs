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
    public class FormDentistaDelete : Form
    {
        int id;
        Label labelRemover;
        Button btConfirmar;
        Button btCancelar;
        public FormDentistaDelete(int id)
        {
            this.id = id;
            this.ClientSize = new Size(200,160);

            labelRemover = new Label();
            labelRemover.Text = $"Deseja realmente excluir esse registro (id: {id})?";
            labelRemover.Size = new Size(200,40);
            labelRemover.TextAlign = ContentAlignment.MiddleCenter;
            labelRemover.Location = new Point(0,20);

            btConfirmar = new Button();
            btConfirmar.Text = "Sim";
            btConfirmar.Size = new Size(80,30);
            btConfirmar.Location = new Point(15,90);
            btConfirmar.Click += new EventHandler(this.btConfirmarClick);

            btCancelar = new Button();
            btCancelar.Text = "Não";
            btCancelar.Size = new Size(80,30);
            btCancelar.Location = new Point(105,90);
            btCancelar.Click += new EventHandler(this.btCancelarClick);

            this.Controls.Add(labelRemover);
            this.Controls.Add(btConfirmar);
            this.Controls.Add(btCancelar);
        }

        private void btConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                DentistaController.ExcluirDentista(
                    this.id
                );

                MessageBox.Show("Dentista deletado com sucesso!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao deletar dentista.");
            }   
        }

        private void btCancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}