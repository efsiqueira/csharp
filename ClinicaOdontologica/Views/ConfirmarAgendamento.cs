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
    public class FormConfirmarAgendamento : Form
    {
        Label labelConfirmar;
        Button btConfirmar;
        Button btCancelar;
        public FormConfirmarAgendamento()
        {
            this.ClientSize = new Size(200,160);

            labelConfirmar = new Label();
            labelConfirmar.Text = "Deseja realmente confirmar o agendamento?";
            labelConfirmar.Size = new Size(200,40);
            labelConfirmar.TextAlign = ContentAlignment.MiddleCenter;
            labelConfirmar.Location = new Point(0,20);

            btConfirmar = new Button();
            btConfirmar.Text = "Sim";
            btConfirmar.Size = new Size(80,30);
            btConfirmar.Location = new Point(15,90);

            btCancelar = new Button();
            btCancelar.Text = "Não";
            btCancelar.Size = new Size(80,30);
            btCancelar.Location = new Point(105,90);

            this.Controls.Add(labelConfirmar);
            this.Controls.Add(btConfirmar);
            this.Controls.Add(btCancelar);
        }
    }
}