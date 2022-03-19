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
    
    public class FormDentistaCrud : Form
    {

        ListView listView;


        public FormDentistaCrud()
        {
            this.ClientSize = new System.Drawing.Size(500,400);

            listView = new ListView();
            listView.Location = new Point(20,30);
            listView.Size = new Size(460,260);
            listView.View = View.Details;
            
            listView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Fone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Senha", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Registro", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Salario", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Id Especialidade", -2, HorizontalAlignment.Left);

            listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;

            /*ListViewItem firstLine = new ListViewItem("1");
            firstLine.SubItems.Add("Jose do Carmo");

            listView.Items.Add(firstLine);*/

            this.Controls.Add(listView);
        }
    }
}