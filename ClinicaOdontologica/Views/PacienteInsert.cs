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
    public class FormPacienteInsert : Form
    {
        Label labelName;
        Label labelCpf;
        Label labelFone;
        Label labelEmail;
        Label labelSenha;
        Label labelDtNasc;
        TextBox textName;
        TextBox textCpf;
        TextBox textFone;
        TextBox textEmail;
        TextBox textSenha;
        TextBox textDtNasc;
        Button btConfirmar;
        Button btFechar;
        public FormPacienteInsert()
        {
            this.ClientSize = new System.Drawing.Size(400,355);

            labelName = new Label();
            labelName.Text = "Nome";
            labelName.Location = new Point(20,20);

            labelCpf = new Label();
            labelCpf.Text = "CPF";
            labelCpf.Location = new Point(20,85);

            labelFone = new Label();
            labelFone.Text = "Fone";
            labelFone.Location = new Point(143,85);

            labelDtNasc = new Label();
            labelDtNasc.Text = "Data de Nasc.";
            labelDtNasc.Location = new Point(266,85);

            labelEmail = new Label();
            labelEmail.Text = "Email";
            labelEmail.Location = new Point(20,150);

            labelSenha = new Label();
            labelSenha.Text = "Senha";
            labelSenha.Location = new Point(20,215);

            textName = new TextBox();
            textName.Location = new Point(20,45);
            textName.Size = new Size(360,20);

            textCpf = new TextBox();
            textCpf.Location = new Point(20,110);
            textCpf.Size = new Size(114,20);

            textFone = new TextBox();
            textFone.Location = new Point(143,110);
            textFone.Size = new Size(114,20);

            textDtNasc = new TextBox();
            textDtNasc.Location = new Point(266,110);
            textDtNasc.Size = new Size(114,20);

            textEmail = new TextBox();
            textEmail.Location = new Point(20,175);
            textEmail.Size = new Size(360,20);

            textSenha = new TextBox();
            textSenha.Location = new Point(20,240);
            textSenha.Size = new Size(360,20);

            btConfirmar = new Button();
            btConfirmar.Text = "Confirmar";
            btConfirmar.Location = new Point(90,295);
            btConfirmar.Size = new Size(100,25);

            btFechar = new Button();
            btFechar.Text = "Fechar";
            btFechar.Location = new Point(210,295);
            btFechar.Size = new Size(100,25);

            this.Controls.Add(labelName);
            this.Controls.Add(labelCpf);
            this.Controls.Add(labelFone);
            this.Controls.Add(labelDtNasc);
            this.Controls.Add(labelEmail);
            this.Controls.Add(labelSenha);
            this.Controls.Add(textName);
            this.Controls.Add(textCpf);
            this.Controls.Add(textFone);
            this.Controls.Add(textDtNasc);
            this.Controls.Add(textEmail);
            this.Controls.Add(textSenha);
            this.Controls.Add(btConfirmar);
            this.Controls.Add(btFechar);

        }
    }
}