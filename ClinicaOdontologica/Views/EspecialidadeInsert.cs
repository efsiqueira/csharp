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
    public class FormEspecialidadeInsert : Form
    {
        Label labelDescricao;
        Label labelDetalhamento;
        TextBox textDescricao;
        TextBox textDetalhamento;
        Button btConfirmar;
        Button btFechar;
        public FormEspecialidadeInsert()
        {
            this.ClientSize = new System.Drawing.Size(400,420);

            labelDescricao = new Label();
            labelDescricao.Text = "Descrição";
            labelDescricao.Location = new Point(20,20);

            labelDetalhamento = new Label();
            labelDetalhamento.Text = "Detalhamento";
            labelDetalhamento.Location = new Point(20,85);

            textDescricao = new TextBox();
            textDescricao.Location = new Point(20,45);
            textDescricao.Size = new Size(360,20);

            textDetalhamento = new TextBox();
            textDetalhamento.Location = new Point(20,110);
            textDetalhamento.Size = new Size(175,20);

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

            this.Controls.Add(labelDescricao);
            this.Controls.Add(labelDetalhamento);
            this.Controls.Add(textDescricao);
            this.Controls.Add(textDetalhamento);
            this.Controls.Add(btConfirmar);
            this.Controls.Add(btFechar);

        }

        private void btConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                EspecialidadeController.InserirEspecialidade(
                textDescricao.Text,
                textDetalhamento.Text
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