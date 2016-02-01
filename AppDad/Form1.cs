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
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
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
            Delete_car car = new Delete_car();
            car.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                if (textBox1.Text == UserPass.recover_password)
                    MessageBox.Show(UserPass.password);
                else
                {
                    if (textBox1.Text == UserPass.username.ToString())
                    {
                        if (textBox2.Text == UserPass.password.ToString())
                        {
                            //MessageBox.Show("Acces permis!");
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            button1.Visible = false;
                            menuStrip1.Visible = true;
                            button2.Visible = true;

                        }
                        else
                        {
                            MessageBox.Show("Parola incorecta!");
                            textBox2.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username invalid.");
                        textBox2.Text = "";
                        textBox1.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Datele nu sunt valide.");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn schimbare = new LogIn();
            schimbare.ShowDialog();
        }
    }
}
