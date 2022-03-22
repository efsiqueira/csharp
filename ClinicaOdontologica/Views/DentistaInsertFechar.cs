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
    public class FormDentistaFechar : Form
    {
        Label labelCancelar;
        Button btConfirmar;
        Button btCancelar;
        public FormDentistaFechar()
        {
            this.ClientSize = new Size(200,160);

            labelCancelar = new Label();
            labelCancelar.Text = "Deseja realmente cancelar a operação?";
            labelCancelar.Size = new Size(200,40);
            labelCancelar.TextAlign = ContentAlignment.MiddleCenter;
            labelCancelar.Location = new Point(0,20);

            btConfirmar = new Button();
            btConfirmar.Text = "Sim";
            btConfirmar.Size = new Size(80,30);
            btConfirmar.Location = new Point(15,90);

            btCancelar = new Button();
            btCancelar.Text = "Não";
            btCancelar.Size = new Size(80,30);
            btCancelar.Location = new Point(105,90);

            this.Controls.Add(labelCancelar);
            this.Controls.Add(btConfirmar);
            this.Controls.Add(btCancelar);
        }
    }
}