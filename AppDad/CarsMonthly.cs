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
    public partial class CarsMonthly : Form
    {
        public CarsMonthly()
        {
            InitializeComponent();
            visible_false();
            carsTableAdapter.Fill(tabelDataSet.Cars);
            comboBox2.Items.Clear();
            DataTable dt = tabelDataSet.Cars;
            int i;
            for (i = 0; i < dt.Rows.Count; i++)
                comboBox1.Items.Add(dt.Rows[i]["Car_number"].ToString());

        }

        private void CarsMonthly_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.tabelDataSet.Document);
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);

        }

        public void get_datas(string car_number)
        {
            documentTableAdapter.ReturnCarsStatistics(tabelDataSet.Document, car_number);
            DataTable dt = tabelDataSet.Document;
            int i,alimentare,kilometri,hours,consum,adblu,minutes,days;
            alimentare = 0;
            kilometri  = 0;
            consum     = 0;
            adblu      = 0;
            hours      = 0;
            minutes    = 0;
            days       = 0;

            for (i = 0; i < dt.Rows.Count; i++)
            {
                alimentare += (int)dt.Rows[i]["Fuel"];
                kilometri  += (int)dt.Rows[i]["Hours_end"];
                consum     += (int)dt.Rows[i]["Consumption"];
                adblu      += (int)dt.Rows[i]["ADBLU"];
                comboBox2.Items.Add(dt.Rows[i]["Driver_name"].ToString());

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

            label8.Text  = alimentare.ToString();
            label9.Text  = kilometri.ToString();
            label10.Text = days.ToString() + " zile, " + hours.ToString() + " ore, " + minutes.ToString() + " minute ";
            label11.Text = consum.ToString();
            label12.Text = adblu.ToString();



        }
        public void visible_false()
        {
            label2.Visible    = false;
            label3.Visible    = false;
            label4.Visible    = false;
            label5.Visible    = false;
            label6.Visible    = false;
            label7.Visible    = false;
            label8.Visible    = false;
            label9.Visible    = false;
            label10.Visible   = false;
            label11.Visible   = false;
            label12.Visible   = false;
            comboBox2.Visible = false;
        }

        public void visible_true()
        {
            label2.Visible    = true;
            label3.Visible    = true;
            label4.Visible    = true;
            label5.Visible    = true;
            label6.Visible    = true;
            label7.Visible    = true;
            label8.Visible    = true;
            label9.Visible    = true;
            label10.Visible   = true;
            label11.Visible   = true;
            label12.Visible   = true;
            comboBox2.Visible = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string car_number = comboBox1.SelectedItem.ToString();
            get_datas(car_number);
            visible_true();
        }
    }
}
