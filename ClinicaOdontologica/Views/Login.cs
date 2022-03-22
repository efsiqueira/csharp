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

    public class FormLogin : Form
    {

        Label labelLogin;
        Label labelSenha;
        TextBox textLogin;
        TextBox textSenha;
        Button buttonConfirmar;
        Button buttonFechar;

        public FormLogin()
        {
            this.ClientSize = new System.Drawing.Size(200, 220);
            this.Text = "Login";

            labelLogin = new Label();
            labelLogin.Text = "Login";
            labelLogin.Location = new Point(20, 20);

            labelSenha = new Label();
            labelSenha.Text = "Senha";
            labelSenha.Location = new Point(20, 90);

            textLogin = new TextBox();
            textLogin.Location = new Point(20,45);
            textLogin.Size = new Size(160,15);

            textSenha = new TextBox();
            textSenha.Location = new Point(20,115);
            textSenha.Size = new Size(160,15);
            textSenha.PasswordChar = '*';

            buttonConfirmar = new Button();
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.Size = new Size(80,25);
            buttonConfirmar.Location = new Point(20,170);
            buttonConfirmar.Click += new EventHandler(this.buttonConfirmarClick);
            
            buttonFechar = new Button();
            buttonFechar.Text = "Fechar";
            buttonFechar.Size = new Size(80,25);
            buttonFechar.Location = new Point(100,170);
            buttonFechar.Click += new EventHandler(this.buttonFecharClick);

            this.Controls.Add(labelLogin);
            this.Controls.Add(labelSenha);
            this.Controls.Add(textLogin);
            this.Controls.Add(textSenha);
            this.Controls.Add(buttonConfirmar);
            this.Controls.Add(buttonFechar);
        }

        private void buttonConfirmarClick(object sender, EventArgs e)
        {
            try
                {
                    Auth.Login(textLogin.Text, textSenha.Text);
                    if (Auth.Dentista != null)
                    {
                        FormDentista form = new FormDentista();
                        form.Show();
                    }
                    if (Auth.Paciente != null)
                    {
                        //MenuPaciente();
                    }
                    Auth.Logout();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }
        }

        private void buttonFecharClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}