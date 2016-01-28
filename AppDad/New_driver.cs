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
            DialogResult answer;
            if (textBox1.Text != "")
            {

                answer = MessageBox.Show(this, "Doriti sa salvati?", "", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    driversTableAdapter.New_driver(textBox1.Text);
                    //driversTableAdapter.Fill(tabelDataSet.Drivers);
                    //driversTableAdapter.Update(tabelDataSet.Drivers);
                    MessageBox.Show("Datele au fost adaugate cu succes.");
                }
                else
                {
                    this.Close();
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
