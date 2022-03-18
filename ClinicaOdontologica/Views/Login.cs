using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace Views
{
    /*static class Login
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			
        }
    }*/

    public class Login : Form
    {

        Label labelNome;
        Label labelDtNasc;
        Label labelCpf;
        TextBox textNome;
        TextBox textDtNasc;
        TextBox textCpf;


        public Login()
        {
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Text = "Login";

            labelNome = new Label();
            labelNome.Text = "Nome";
            labelNome.Location = new Point(20, 20);

            labelDtNasc = new Label();
            labelDtNasc.Text = "Data de Nascimento";
            labelDtNasc.Location = new Point(20, 75);
            labelDtNasc.Size = new Size(200, 18);

            labelCpf = new Label();
            labelCpf.Text = "CPF";
            labelCpf.Location = new Point(20, 130);

            textNome = new TextBox();
            textNome.Location = new Point(20,50);
            textNome.Size = new Size(250,18);

            textDtNasc = new TextBox();
            textDtNasc.Location = new Point(20,100);
            textDtNasc.Size = new Size(250,18);

            textCpf = new TextBox();
            textCpf.Location = new Point(20,155);
            textCpf.Size = new Size(250,18);

            this.Controls.Add(labelNome);
            this.Controls.Add(labelDtNasc);
            this.Controls.Add(labelCpf);
            this.Controls.Add(textNome);
            this.Controls.Add(textDtNasc);
            this.Controls.Add(textCpf);
        }

    }
}