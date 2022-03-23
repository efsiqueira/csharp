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
    public class FormLogin : Form
    {

        Label labelLogin;
        Label labelSenha;
        TextBox textLogin;
        TextBox textSenha;
        Button buttonConfirmar;
        Button buttonFechar;
        Button btCadastrar;

        public FormLogin()
        {
            this.ClientSize = new System.Drawing.Size(280, 220);
            this.Text = "Login";

            labelLogin = new Label();
            labelLogin.Text = "Login";
            labelLogin.Location = new Point(20, 20);

            labelSenha = new Label();
            labelSenha.Text = "Senha";
            labelSenha.Location = new Point(20, 90);

            textLogin = new TextBox();
            textLogin.Location = new Point(20,45);
            textLogin.Size = new Size(240,15);

            textSenha = new TextBox();
            textSenha.Location = new Point(20,115);
            textSenha.Size = new Size(240,15);
            textSenha.PasswordChar = '*';

            buttonConfirmar = new Button();
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.Size = new Size(80,25);
            buttonConfirmar.Location = new Point(20,170);
            buttonConfirmar.Click += new EventHandler(this.buttonConfirmarClick);
            
            btCadastrar = new Button();
            btCadastrar.Text = "Cadastrar";
            btCadastrar.Size = new Size(80,25);
            btCadastrar.Location = new Point(100,170);
            btCadastrar.Click += new EventHandler(this.btCadastrarClick);

            buttonFechar = new Button();
            buttonFechar.Text = "Fechar";
            buttonFechar.Size = new Size(80,25);
            buttonFechar.Location = new Point(180,170);
            buttonFechar.Click += new EventHandler(this.buttonFecharClick);

            this.Controls.Add(labelLogin);
            this.Controls.Add(labelSenha);
            this.Controls.Add(textLogin);
            this.Controls.Add(textSenha);
            this.Controls.Add(buttonConfirmar);
            this.Controls.Add(buttonFechar);
            this.Controls.Add(btCadastrar);
        }

        private void buttonConfirmarClick(object sender, EventArgs e)
        {
            try
                {
                    Auth.Login(textLogin.Text, textSenha.Text);
                    if (Auth.isLogged)
                    {
                        this.Hide();
                        if (Auth.Dentista != null)
                        {
                            FormDentista form = new FormDentista(this);
                            form.Show();
                        }
                        if (Auth.Paciente != null)
                        {
                            FormPaciente form = new FormPaciente(this);
                            form.Show();
                        }
                        Auth.Logout();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(
                        err.Message,
                        "ERRO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
        }

        private void buttonFecharClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrarClick(object sender, EventArgs e)
        {
            FormDentistaInsert form = new FormDentistaInsert();
            form.Show();
        }

    }
}