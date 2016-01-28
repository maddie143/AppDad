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
    public partial class Delete_car : Form
    {
        public Delete_car()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable cars = tabelDataSet.Cars;
            int i,
                ok;
            ok = 0;
            for (i = 0; i < cars.Rows.Count; i++)
            {
                if (cars.Rows[i]["Car_number"].ToString() == textBox1.Text)
                {
                    ok = 1;
                }
            }
            if (ok == 0)
            {
                MessageBox.Show("Nu exista nici o masina inregistrata cu acest numar.");

            }
            else
            {
                carsTableAdapter.DeleteCar(textBox1.Text);
                MessageBox.Show("Masina a fost stearsa cu succes.");
                this.Close();
            }
        }

        private void Delete_car_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);

        }
    }
}
