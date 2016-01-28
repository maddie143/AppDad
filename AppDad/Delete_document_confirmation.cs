using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDad
{
    public partial class Delete_document_confirmation : Form
    {
        DataGridView datagrid;
        Button b;
        Label l;
        public Delete_document_confirmation(DataGridView datagrid,Button but, Label lab)
        {
            InitializeComponent();
            documentTableAdapter.Fill(tabelDataSet.Document);
            this.datagrid = datagrid;
            this.b = but;
            this.l = lab;

        }
        private void Delete_document_confirmation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.tabelDataSet.Document);

        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            documentTableAdapter.Fill(tabelDataSet.Document);
            DataTable documente = tabelDataSet.Document;
            int i,
                ok;
            ok = 0;

            for (i = 0; i < documente.Rows.Count; i++)
            {
                if (documente.Rows[i]["Document_no"].ToString() == textBox1.Text)
                {
                    MessageBox.Show("Se deschide ceva.");
                    ok = 1;
                    documentTableAdapter.DeleteDocument(int.Parse(textBox1.Text));
                    MessageBox.Show("aici?");
                    this.datagrid.DataSource = this.tabelDataSet.Tables["Document"];
                    this.documentTableAdapter.Fill(this.tabelDataSet.Document);
                    this.documentTableAdapter.Update(this.tabelDataSet.Document);
                    if (documente.Rows.Count == 0)
                    {
                        this.l.Visible = true;
                        this.b.Visible = false;
                    }
                }
            }
            if (ok == 0)
            {
                MessageBox.Show("Nu exista inregistrata nici o fisa cu acest numar.");
            }
            else
            {
                MessageBox.Show("Fisa a fost stearsa cu succes!");
                this.Close();
            }




        }

        private void formclos(object sender, FormClosingEventArgs e)
        {
            Delete_document doc = new Delete_document();
            doc.PerformRefresh();
        }
    }
}
