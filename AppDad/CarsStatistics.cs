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
    public partial class CarsStatistics : Form
    {
        public CarsStatistics()
        {
            InitializeComponent();
            dataGridView1.Columns[1].HeaderText = "Numar masina";
        }

        private void CarsStatistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
