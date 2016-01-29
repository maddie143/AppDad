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
    public partial class DocumentStatistics : Form
    {
        public DocumentStatistics()
        {
            InitializeComponent();
            dataGridView1.Refresh();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ziua";
            dataGridView1.Columns[2].HeaderText = "Numar fisa";
            dataGridView1.Columns[3].HeaderText = "Numar masina";
            dataGridView1.Columns[4].HeaderText = "Nume sofer";
            dataGridView1.Columns[5].HeaderText = "Alimentare";
            dataGridView1.Columns[6].HeaderText = "KM plecare";
            dataGridView1.Columns[7].HeaderText = "KM sosire";
            dataGridView1.Columns[8].HeaderText = "Ore functionare";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].HeaderText = "Consum";
            dataGridView1.Columns[11].HeaderText = "ADBLU";
            dataGridView1.Columns[12].HeaderText = "Ruta de deplasare";
            dataGridView1.Columns[13].HeaderText = "Luna";
            dataGridView1.AutoResizeColumns();
        }

        private void DocumentStatistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.tabelDataSet.Document);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MonthlyStatistics monthly = new MonthlyStatistics();
            monthly.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarsMonthly cars = new CarsMonthly();
            cars.ShowDialog();
        }
    }
}
