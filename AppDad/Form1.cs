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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adaugareFisaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Months' table. You can move, or remove it, as needed.
            this.monthsTableAdapter.Fill(this.tabelDataSet.Months);
            // TODO: This line of code loads data into the 'tabelDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.tabelDataSet.Drivers);
            // TODO: This line of code loads data into the 'tabelDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.tabelDataSet.Document);
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);
            // TODO: This line of code loads data into the 'tabelDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.tabelDataSet.Drivers);
            // TODO: This line of code loads data into the 'tabelDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.tabelDataSet.Document);
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);
            // TODO: This line of code loads data into the 'tabelDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.tabelDataSet.Drivers);
            // TODO: This line of code loads data into the 'tabelDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.tabelDataSet.Document);
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);
            // TODO: This line of code loads data into the 'tabelDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.tabelDataSet.Drivers);
            // TODO: This line of code loads data into the 'tabelDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.tabelDataSet.Document);
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);

        }

        private void adaugareFisaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_document adaugare = new Add_document();
            adaugare.ShowDialog();


        }

        private void adaugareSoferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_driver driver = new New_driver();
            driver.ShowDialog();
        }

        private void listaSoferiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stergereSoferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_driver driver = new Delete_driver();
            driver.ShowDialog();
        }

        private void adaugareMasinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_car car = new New_car();
            car.ShowDialog();
        }

        private void stergereMasinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stergereFisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_document doc = new Delete_document();
            doc.ShowDialog();
                
        }

        private void fiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentStatistics statistici_doc = new DocumentStatistics();
            statistici_doc.ShowDialog();
        }

        private void masiniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CarsStatistics cars = new CarsStatistics();
            cars.ShowDialog();
        }

        private void soferiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DriversStatistics drivers = new DriversStatistics();
            drivers.ShowDialog();
        }
    }
}
