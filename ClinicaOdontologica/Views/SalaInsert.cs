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
    public class FormSalaInsert : Form
    {
        Label labelNumero;
        Label labelEquipamentos;
        TextBox textNumero;
        TextBox textEquipamentos;
        Button btConfirmar;
        Button btFechar;
        public FormSalaInsert()
        {
            this.ClientSize = new System.Drawing.Size(400,420);

            labelNumero = new Label();
            labelNumero.Text = "Número";
            labelNumero.Location = new Point(20,20);

            labelEquipamentos = new Label();
            labelEquipamentos.Text = "CPF";
            labelEquipamentos.Location = new Point(20,85);

            textNumero = new TextBox();
            textNumero.Location = new Point(143,305);
            textNumero.Size = new Size(114,20);

            textEquipamentos = new TextBox();
            textEquipamentos.Location = new Point(266,305);
            textEquipamentos.Size = new Size(114,20);

            btConfirmar = new Button();
            btConfirmar.Text = "Confirmar";
            btConfirmar.Location = new Point(90,360);
            btConfirmar.Size = new Size(100,25);

            btFechar = new Button();
            btFechar.Text = "Fechar";
            btFechar.Location = new Point(210,360);
            btFechar.Size = new Size(100,25);

            this.Controls.Add(labelNumero);
            this.Controls.Add(labelEquipamentos);
            this.Controls.Add(textNumero);
            this.Controls.Add(textEquipamentos);
            this.Controls.Add(btConfirmar);
            this.Controls.Add(btFechar);

        }

        private void btConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                SalaController.IncluirSala(
                textNumero.Text,
                textEquipamentos.Text
                );

                MessageBox.Show("Dados inseridos com sucesso.");
                this.Close();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Não foi possível inserir os dados.");
            }
        }

        private void btFecharClick(object sender, EventHandler e)
        {
            this.Close();
        }
    }
}