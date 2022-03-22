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
    public class FormProcedimentoInsert : Form
    {
        Label labelDescricao;
        Label labelPreco;
        TextBox textDescricao;
        TextBox textPreco;
        Button btConfirmar;
        Button btFechar;
        public FormProcedimentoInsert()
        {
            this.ClientSize = new System.Drawing.Size(300,240);

            labelDescricao = new Label();
            labelDescricao.Text = "Descrição";
            labelDescricao.Location = new Point(20,20);

            labelPreco = new Label();
            labelPreco.Text = "Preço";
            labelPreco.Location = new Point(20,85);

            textDescricao = new TextBox();
            textDescricao.Location = new Point(20,45);
            textDescricao.Size = new Size(260,20);

            textPreco = new TextBox();
            textPreco.Location = new Point(20,110);
            textPreco.Size = new Size(260,20);

            btConfirmar = new Button();
            btConfirmar.Text = "Confirmar";
            btConfirmar.Location = new Point(55,180);
            btConfirmar.Size = new Size(90,25);

            btFechar = new Button();
            btFechar.Text = "Fechar";
            btFechar.Location = new Point(155,180);
            btFechar.Size = new Size(90,25);

            this.Controls.Add(labelDescricao);
            this.Controls.Add(labelPreco);
            this.Controls.Add(textDescricao);
            this.Controls.Add(textPreco);
            this.Controls.Add(btConfirmar);
            this.Controls.Add(btFechar);

        }
    }
}