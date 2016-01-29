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
    public partial class DriversStatistics : Form
    {
        public DriversStatistics()
        {
            InitializeComponent();
            dataGridView1.Columns[1].HeaderText = "Nume sofer";
        }

        private void DriversStatistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.tabelDataSet.Drivers);

        }
    }
}
