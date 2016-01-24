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
    public partial class Add_document : Form
    {
        public Add_document()
        {
            InitializeComponent();
            default_buttons();
            default_color();
            driversTableAdapter.Return_drr(tabelDataSet.Drivers);
            carsTableAdapter.Return_carss(tabelDataSet.Cars);
            DataTable driver = tabelDataSet.Drivers;
            int i,ok,j;
            for (i = 0; i < driver.Rows.Count; i++)
            {
                ok = 1;
                for (j = 0; j < i; j++)
                {
                    if (driver.Rows[i]["Driver_name"].ToString() == driver.Rows[j]["Driver_name"].ToString()) // comparison between their value toString()
                        ok = 0;
                }
                if (ok == 1)
                {
                    comboBox2.Items.Add(driver.Rows[i]["Driver_name"]); // adding the OBJECT
                }
                else
                {
                    MessageBox.Show("Datele introduse exista deja.");
                }
            }

            DataTable cars = tabelDataSet.Cars;
            for (i = 0; i < cars.Rows.Count; i++)
            {
                ok = 1;
                for (j = 0; j < i; j++)
                {
                    if (cars.Rows[i]["Car_number"].ToString() == cars.Rows[j]["Car_number"].ToString())
                        ok = 0;
                }
                if (ok == 1)
                {
                    comboBox1.Items.Add(cars.Rows[i]["Car_number"]);
                }
            }

        }


        private void Add_document_Load(object sender, EventArgs e)
        {
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
        public void default_buttons()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
        }

        public int validate_datas(){
            try
            {
                int.Parse(textBox1.Text);
                int.Parse(textBox2.Text);
                int.Parse(textBox4.Text);
                int.Parse(textBox5.Text);
                int.Parse(textBox6.Text);
                int.Parse(textBox7.Text);
                int.Parse(textBox8.Text);
                if (comboBox1.SelectedItem == null)
                    throw new FormatException() ;
                if (comboBox2.SelectedItem == null)
                    throw new FormatException() ;
                if (textBox1.Text == "")
                    return 0;
                if (textBox10.Text == "")
                    return 0;
                if (textBox2.Text == "")
                    return 0;
                if (textBox4.Text == "")
                    return 0;
                if (textBox5.Text == "")
                    return 0;
                if (textBox6.Text == "")
                    return 0;
                if (textBox7.Text == "")
                    return 0;
                if (textBox8.Text == "")
                    return 0;
                if (textBox9.Text == "")
                    return 0;
                if (textBox11.Text == "")
                    return 0;
                return 1;
            }
            catch (FormatException){
                return 0;
            }
          }
        public void wrong_elements()
        {
            int number;

            bool check;
            check = Int32.TryParse(textBox1.Text,out number);
            if (check == false || textBox1.Text == "")
                textBox1.BackColor = System.Drawing.Color.Red;

            check = Int32.TryParse(textBox2.Text, out number);
            if (check == false || textBox2.Text == "")
                textBox2.BackColor = System.Drawing.Color.Red;

            check = Int32.TryParse(textBox4.Text, out number);
            if (check == false || textBox4.Text == "")
                textBox4.BackColor = System.Drawing.Color.Red;

            check = Int32.TryParse(textBox5.Text, out number);
            if (check == false || textBox5.Text == "")
                textBox5.BackColor = System.Drawing.Color.Red;

            check = Int32.TryParse(textBox6.Text, out number);
            if (check == false || textBox6.Text == "")
                textBox6.BackColor = System.Drawing.Color.Red;

            check = Int32.TryParse(textBox7.Text, out number);
            if (check == false || textBox7.Text == "")
                textBox7.BackColor = System.Drawing.Color.Red;

            check = Int32.TryParse(textBox8.Text, out number);
            if (check == false || textBox8.Text == "")
                textBox8.BackColor = System.Drawing.Color.Red;

            if (comboBox1.SelectedItem == null)
                comboBox1.BackColor = System.Drawing.Color.Red;

            if (comboBox2.SelectedItem == null)
                comboBox2.BackColor = System.Drawing.Color.Red;

            if (textBox9.Text == "")
                textBox9.BackColor = System.Drawing.Color.Red;

            if (textBox10.Text == "")
                textBox10.BackColor = System.Drawing.Color.Red;

            if (textBox11.Text == "")
                textBox11.BackColor = System.Drawing.Color.Red;

        }

        public void default_color()
        {
            textBox1.BackColor = System.Drawing.Color.White;
            textBox2.BackColor = System.Drawing.Color.White;
            textBox4.BackColor = System.Drawing.Color.White;
            textBox5.BackColor = System.Drawing.Color.White;
            textBox6.BackColor = System.Drawing.Color.White;
            textBox7.BackColor = System.Drawing.Color.White;
            textBox8.BackColor = System.Drawing.Color.White;
            textBox9.BackColor = System.Drawing.Color.White;
            textBox10.BackColor = System.Drawing.Color.White;
            textBox11.BackColor = System.Drawing.Color.White;
            comboBox1.BackColor = System.Drawing.Color.White;
            comboBox2.BackColor = System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate_datas() == 1)
            {
                MessageBoxButtons yes = MessageBoxButtons.YesNo;
                DialogResult answer;
                answer = MessageBox.Show(this, "Doriti sa salvati?", "", yes);

                if (answer == DialogResult.Yes)
                {
                    MessageBox.Show("Datele au fost introduse.");
                    documentTableAdapter.InsertDocument(
                        int.Parse(textBox1.Text),
                        int.Parse(textBox2.Text), 
                        comboBox1.SelectedItem.ToString(), 
                        comboBox2.SelectedItem.ToString(), 
                        int.Parse(textBox4.Text), 
                        int.Parse(textBox7.Text), 
                        int.Parse(textBox8.Text), 
                        textBox9.Text,
                        textBox10.Text, 
                        int.Parse(textBox5.Text), 
                        int.Parse(textBox6.Text), 
                        textBox11.Text
                        );

                    documentTableAdapter.GetData();
                    documentTableAdapter.Fill(tabelDataSet.Document);
                    documentTableAdapter.Update(tabelDataSet.Document);
                    default_buttons();
                    default_color();
                  }
            }
            else
            {
                MessageBox.Show("Unele date nu sunt introduse sau nu sunt introduse in formatul cerut.");
                default_color();
                wrong_elements();
            }
        }

        private void textBox1_BindingContextChanged(object sender, EventArgs e)
        {
        
        }

        private void Change_bkcolor(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show(this, "Sunteti sigur ca doriti sa renuntati?", "", MessageBoxButtons.YesNoCancel);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                test n = new test();
                n.ShowDialog();
            }
        }

    }
}
