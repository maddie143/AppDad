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
    public partial class MonthlyStatistics : Form
    {
        public MonthlyStatistics()
        {
            InitializeComponent();
            label_visible();
            documentTableAdapter.Fill(tabelDataSet.Document);
            DataTable dt = tabelDataSet.Document;
            int i, kilometers, fuel, consumption, adblu, hours, minutes, days;
            kilometers  = 0;
            fuel        = 0;
            consumption = 0;
            adblu       = 0;
            hours       = 0;
            minutes     = 0;
            days        = 0;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                kilometers  += (int)dt.Rows[i]["Hours_end"];
                fuel        += (int)dt.Rows[i]["Fuel"];
                consumption += (int)dt.Rows[i]["Consumption"];
                adblu       += (int)dt.Rows[i]["ADBLU"];

                string times = (string)dt.Rows[i]["Hours_start"];
                string[] arg = new string[] { ":" };
                string[] tt  = times.Split(arg, StringSplitOptions.None);
                if (tt.Length == 2)
                {
                    minutes += int.Parse(tt[1]);
                    hours   += int.Parse(tt[0]);

                }
            }
            int verify;
            if (minutes > 59)
            {
                verify  = minutes / 60;
                minutes = minutes % 60;
                hours   += verify;
                if (hours > 23)
                {
                    verify = hours / 24;
                    hours  = hours % 24;
                    days   += verify;
                }
            }
            else
            {
                if (hours > 23)
                {
                verify = hours / 24;
                hours  = hours % 24;
                days   += verify;
                }
            }
            label8.Text  = days.ToString() + " zile, " + hours.ToString() + " ore, " + minutes.ToString() + " minute ";
            label6.Text  = kilometers.ToString();
            label7.Text  = fuel.ToString();
            label9.Text  = consumption.ToString();
            label10.Text = adblu.ToString();
        
        }

        private void MonthlyStatistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.tabelDataSet.Document);
            // TODO: This line of code loads data into the 'tabelDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.tabelDataSet.Document);
            
        }

        private void februarieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void label_visible()
        {
            label6.Visible  = true;
            label7.Visible  = true;
            label8.Visible  = true;
            label9.Visible  = true;
            label10.Visible = true;
        }
        public void GetStatistics(int i)
        {

            documentTableAdapter.ReturnDataMonth(tabelDataSet.Document, i);

            DataTable dt = tabelDataSet.Document;
            int kilometers, fuel, consumption, adblu, hours, minutes, days;
            kilometers  = 0;
            fuel        = 0;
            consumption = 0;
            adblu       = 0;
            hours       = 0;
            minutes     = 0;
            days        = 0;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                kilometers  += (int)dt.Rows[i]["Hours_end"];
                fuel        += (int)dt.Rows[i]["Fuel"];
                consumption += (int)dt.Rows[i]["Consumption"];
                adblu       += (int)dt.Rows[i]["ADBLU"];

                string times = (string)dt.Rows[i]["Hours_start"];
                string[] arg = new string[] { ":" };
                string[] tt  = times.Split(arg, StringSplitOptions.None);
                if (tt.Length == 2)
                {
                    minutes += int.Parse(tt[1]);
                    hours   += int.Parse(tt[0]);

                }

            }
            int verify;
            if (minutes > 59)
            {
                verify  = minutes / 60;
                minutes = minutes % 60;
                hours   += verify;
                if (hours > 23)
                {
                    verify  = hours / 24;
                    hours   = hours % 24;
                    days    += verify;
                }
            }
            else
            {
                if (hours > 23)
                {
                    verify = hours / 24;
                    hours  = hours % 24;
                    days   += verify;
                }
            }
            label8.Text  = days.ToString() + " zile, " + hours.ToString() + " ore, " + minutes.ToString() + " minute ";
            label6.Text  = kilometers.ToString();
            label7.Text  = fuel.ToString();
            label9.Text  = consumption.ToString();
            label10.Text = adblu.ToString();



        }
        private void ianuarieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            GetStatistics(i);
            label_visible();

        }

        private void februarieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int i = 2;
            GetStatistics(i);
            label_visible();
        }

        private void martieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 3;
            GetStatistics(i);
            label_visible();
        }

        private void aprilieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 4;
            GetStatistics(i);
            label_visible();
        }

        private void mariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 5;
            GetStatistics(i);
            label_visible();
        }

        private void iunieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 6;
            GetStatistics(i);
            label_visible();
        }

        private void iulieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 7;
            GetStatistics(i);
            label_visible();
        }

        private void augustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 8;
            GetStatistics(i);
            label_visible();
        }

        private void septembrieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 9;
            GetStatistics(i);
            label_visible();
        }

        private void octombrieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 10;
            GetStatistics(i);
            label_visible();
        }

        private void noiembrieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 11;
            GetStatistics(i);
            label_visible();
        }

        private void decembrieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 12;
            GetStatistics(i);
            label_visible();
        }
    }
}
