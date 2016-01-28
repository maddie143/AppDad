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
            DataTable cars = tabelDataSet.Cars;
            int i,
                ok;
            ok = 1;
            for (i = 0; i < cars.Rows.Count; i++)
            {
                if (cars.Rows[i]["Car_number"].ToString() == textBox1.Text)
                {
                    ok = 0;
                }
            }

            if(ok == 0) {
                MessageBox.Show("Masina cu acest numar exista deja.");

            }
            else {
                carsTableAdapter.New_car(textBox1.Text);
                MessageBox.Show("Masina a fost adaugata cu succes.");
                this.Close();
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
