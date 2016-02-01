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
    public partial class New_car : Form
    {
        public New_car()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            int i,
                ok;
            ok = 1;
            carsTableAdapter.Fill(tabelDataSet.Cars);
            DataTable cars = tabelDataSet.Cars;

            if (textBox1.Text != "")
            {
                for (i = 0; i < cars.Rows.Count; i++)
                {
                    if (cars.Rows[i]["Car_number"].ToString() == textBox1.Text)
                    {
                        ok = 0;
                    }
                }

                if (ok == 0)
                {
                    MessageBox.Show("Masina cu acest numar exista deja.");
                    textBox1.Text = "";

                }
                else
                {
                    carsTableAdapter.New_car(textBox1.Text);
                    MessageBox.Show("Masina a fost adaugata cu succes.");
                    this.Close();
                }
            }
            else
            {
                answer = MessageBox.Show(this, "Nu ati introdus date. Doriti sa adaugati o doua data?", "", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                {
                    this.Close();
                }

            }

        }

        private void New_car_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);

        }
    }
}
