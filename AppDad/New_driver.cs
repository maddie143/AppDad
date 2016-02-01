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
    public partial class New_driver : Form
    {
        public New_driver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            driversTableAdapter.Fill(tabelDataSet.Drivers);
            DialogResult answer;
            if (textBox1.Text != "")
            {
                DataTable drivers = tabelDataSet.Drivers;
                int i,
                    ok;
                ok = 1;
                for (i = 0; i < drivers.Rows.Count; i++)
                {
                    if (drivers.Rows[i]["Driver_name"].ToString() == textBox1.Text)
                        ok = 0;

                }

                if (ok == 1)
                {
                    driversTableAdapter.New_driver(textBox1.Text);
                    //driversTableAdapter.Fill(tabelDataSet.Drivers);
                    //driversTableAdapter.Update(tabelDataSet.Drivers);
                    MessageBox.Show("Datele au fost adaugate cu succes.");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Soferul cu acest nume este deja inregistrat.");
                    textBox1.Text = "";
                }
            }
            else
            {
                answer = MessageBox.Show(this, "Nu ati introdus date. Doriti sa adaugati o doua data?","", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void New_driver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.tabelDataSet.Drivers);
            // TODO: This line of code loads data into the 'tabelDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.tabelDataSet.Drivers);

        }
    }
}
