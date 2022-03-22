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
    public class FormDentistaInsert : Form
    {
        Label labelName;
        Label labelCpf;
        Label labelFone;
        Label labelEmail;
        Label labelSenha;
        Label labelRegistro;
        Label labelSalario;
        Label labelEspecialidadeId;
        TextBox textName;
        TextBox textCpf;
        TextBox textFone;
        TextBox textEmail;
        TextBox textSenha;
        TextBox textRegistro;
        TextBox textSalario;
        TextBox textEspecialidadeId;
        public FormDentistaInsert()
        {
            this.ClientSize = new System.Drawing.Size(400,550);

            labelName = new Label();
            labelName.Text = "Nome";
            labelName.Location = new Point(20,20);

            labelCpf = new Label();
            labelCpf.Text = "CPF";
            labelCpf.Location = new Point(20,85);

            labelFone = new Label();
            labelFone.Text = "Fone";
            labelFone.Location = new Point(210,85);

            labelEmail = new Label();
            labelEmail.Text = "Email";
            labelEmail.Location = new Point(20,215);

            labelSenha = new Label();
            labelSenha.Text = "Senha";
            labelSenha.Location = new Point(20,280);

            labelRegistro = new Label();
            labelRegistro.Text = "Registro";
            labelRegistro.Location = new Point(20,345);

            labelSalario = new Label();
            labelSalario.Text = "Salário";
            labelSalario.Location = new Point(20,410);

            labelEspecialidadeId = new Label();
            labelEspecialidadeId.Text = "Id Especialidade";
            labelEspecialidadeId.Location = new Point(20,475);

            textName = new TextBox();
            textName.Location = new Point(20,45);
            textName.Size = new Size(360,20);

            textCpf = new TextBox();
            textCpf.Location = new Point(20,110);
            textCpf.Size = new Size(175,20);

            textFone = new TextBox();
            textFone.Location = new Point(210,110);
            textFone.Size = new Size(175,20);

            textEmail = new TextBox();
            textEmail.Location = new Point(20,240);
            textEmail.Size = new Size(360,20);

            textSenha = new TextBox();
            textSenha.Location = new Point(20,305);
            textSenha.Size = new Size(360,20);

            textRegistro = new TextBox();
            textRegistro.Location = new Point(20,370);
            textRegistro.Size = new Size(360,20);

            textSalario = new TextBox();
            textSalario.Location = new Point(20,435);
            textSalario.Size = new Size(360,20);

            textEspecialidadeId = new TextBox();
            textEspecialidadeId.Location = new Point(20,500);
            textEspecialidadeId.Size = new Size(360,20);

            this.Controls.Add(labelName);
            this.Controls.Add(labelCpf);
            this.Controls.Add(labelFone);
            this.Controls.Add(labelEmail);
            this.Controls.Add(labelSenha);
            this.Controls.Add(labelRegistro);
            this.Controls.Add(labelSalario);
            this.Controls.Add(labelEspecialidadeId);
            this.Controls.Add(textName);
            this.Controls.Add(textCpf);
            this.Controls.Add(textFone);
            this.Controls.Add(textEmail);
            this.Controls.Add(textSenha);
            this.Controls.Add(textRegistro);
            this.Controls.Add(textSalario);
            this.Controls.Add(textEspecialidadeId);

        }
    }
}