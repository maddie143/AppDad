﻿using System;
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
    public partial class Delete_driver : Form
    {
        public Delete_driver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable drivers = tabelDataSet.Drivers;
            int i,
                ok;
            ok = 0;
            for (i = 0; i < drivers.Rows.Count; i++)
            {
                if (drivers.Rows[i]["Driver_name"].ToString() == textBox1.Text)
                {
                    ok = 1;
                }
            }
            if (ok == 0)
            {
                MessageBox.Show("Soferul cu acest nume nu este inregistrat.");
            }
            else
            {
                driversTableAdapter.DeleteDriver(textBox1.Text);
                MessageBox.Show("Numele a fost sters cu succes!");
                this.Close();
            }
        }

        private void Delete_driver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.tabelDataSet.Drivers);
            // TODO: This line of code loads data into the 'tabelDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.tabelDataSet.Drivers);

        }
    }
}
