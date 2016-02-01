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
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            Months.error.Clear();

            default_buttons();
            default_color();
            driversTableAdapter.Return_dr(tabelDataSet.Drivers);
            carsTableAdapter.Return_cars(tabelDataSet.Cars);
            DataTable driver = tabelDataSet.Drivers;
            int i,ok,j;
            textBox3.Text = DateTime.Now.Month.ToString();
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
            // TODO: This line of code loads data into the 'tabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.tabelDataSet.Cars);
            // TODO: This line of code loads data into the 'tabelDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.tabelDataSet.Document);
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

        public int check_for_nr_document_existence(int document_nr){
            documentTableAdapter.Fill(tabelDataSet.Document);
            DataTable dt = tabelDataSet.Document;
            int i,
                ok;
            ok = 1;

            for(i=0; i < dt.Rows.Count; i++){
                if(int.Parse(dt.Rows[i]["Document_no"].ToString()) == document_nr)
                    ok = 0;

            }
            return ok;

        }



        /* We check for the datas:
         * if they're integers or comboBoxes are null
         * if they're empty
         */
        public int validate_datas(){
            try
            {

                string[] months = Months.months;
                int[] days = Months.days;

                int.Parse(textBox1.Text); 
                int.Parse(textBox2.Text); 
                int.Parse(textBox4.Text);
                int.Parse(textBox5.Text);
                int.Parse(textBox6.Text);
                int.Parse(textBox7.Text);
                int.Parse(textBox8.Text);
                int.Parse(textBox9.Text);
                int.Parse(textBox10.Text);
                if (comboBox1.SelectedItem == null)
                    return 0;
                if (comboBox2.SelectedItem == null)
                    return 0;
                if (textBox1.Text == "")
                    return 0;
                if (textBox10.Text == "")
                    return 0;
                if (textBox2.Text == "" || int.Parse(textBox2.Text) < 0)
                    return 0;
                if (textBox4.Text == "" || int.Parse(textBox4.Text) < 0)
                    return 0;
                if (textBox5.Text == "" || int.Parse(textBox5.Text) < 0)
                    return 0;
                if (textBox6.Text == "" || int.Parse(textBox6.Text) < 0)
                    return 0;
                if (textBox7.Text == "")
                    return 0;
                if (textBox8.Text == "")
                    return 0;
                if (textBox9.Text == "" || int.Parse(textBox9.Text) < 0 || int.Parse(textBox9.Text) > 23)
                    return 0;
                if (textBox11.Text == "" || int.Parse(textBox10.Text) < 0 || int.Parse(textBox10.Text) > 59)
                    return 0;

                if (int.Parse(textBox1.Text) > days[DateTime.Now.Month - 1] || int.Parse(textBox1.Text) <= 0)
                    return 0;

                if (int.Parse(textBox8.Text) - int.Parse(textBox7.Text) < 0)
                    return 0;

                if (check_for_nr_document_existence(int.Parse(textBox2.Text)) == 0)
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
            string[] months = Months.months;
            int[] days = Months.days;

            bool check;

            /* We check for the day to be a positive number and the day to be smaller or equal than/to the last day of the month
            */

            check = Int32.TryParse(textBox1.Text,out number); //data
            if (check == false || textBox1.Text == "" || int.Parse(textBox1.Text) > days[DateTime.Now.Month - 1] || int.Parse(textBox1.Text) <= 0)
            {
                textBox1.BackColor = System.Drawing.Color.Red;
                if (textBox1.Text == "")
                    Months.error.Add("Ziua nu poate fi goala.");
                else
                {

                    if (check == false)
                        Months.error.Add("Ziua trebuie sa fie formata dintr-un numar natural.");

                    if (int.Parse(textBox1.Text) > days[int.Parse(textBox3.Text) - 1])
                        Months.error.Add("Luna aceasta are doar " + days[int.Parse(textBox3.Text) - 1].ToString() + " zile.");
                    if (int.Parse(textBox1.Text) <= 0)
                        Months.error.Add("Ziua trebuie sa fie cel putin egala cu 1.");
                }
                }


            check = Int32.TryParse(textBox2.Text, out number);
            if (check == false || textBox2.Text == "" || int.Parse(textBox2.Text) < 0 || check_for_nr_document_existence(int.Parse(textBox2.Text)) == 0)
            {
                textBox2.BackColor = System.Drawing.Color.Red;
                if (textBox2.Text == "")
                    Months.error.Add("Numarul fisei nu poate fi gol.");
                else
                {
                    if (check == false)
                        Months.error.Add("Numarul fisei trebuie sa fie format doar din numere naturale.");

                    if (int.Parse(textBox2.Text) < 0)
                        Months.error.Add("Numarul fiseri nu poate fi un numar negativ.");
                    if (check_for_nr_document_existence(int.Parse(textBox2.Text)) == 0)
                        Months.error.Add("Fisa cu acest numar exista deja.");
                }
            }

            check = Int32.TryParse(textBox3.Text, out number);
            if (check == false || textBox3.Text == "" || int.Parse(textBox3.Text) < 1 || int.Parse(textBox3.Text) > 12)
            {
                textBox3.BackColor = System.Drawing.Color.Red;
                if (textBox3.Text == "")
                    Months.error.Add("Luna nu poate fi goala.");
                else
                {
                    if (check == false)
                        Months.error.Add("Luna trebuie sa fie formata din numere naturale.");
                    if (int.Parse(textBox3.Text) < 1 || int.Parse(textBox3.Text) > 12)
                        Months.error.Add("Luna trebuie sa fie cuprinsa intre 1 si 12.");
                }


            }

            if (comboBox1.SelectedItem == null)
            {
                comboBox1.BackColor = System.Drawing.Color.Red;
                Months.error.Add("Numarul masinii trebuie sa fie unul dintre cele inregistrate.");
            }

            if (comboBox2.SelectedItem == null)
            {
                comboBox2.BackColor = System.Drawing.Color.Red;
                Months.error.Add("Numele soferului trebuie sa fie unul dintre cele inregistrate.");
            }


            check = Int32.TryParse(textBox4.Text, out number);
            if (check == false || textBox4.Text == "" || int.Parse(textBox4.Text) < 0)
            {
                textBox4.BackColor = System.Drawing.Color.Red;
                if (textBox4.Text == "")
                    Months.error.Add("Alimentare nu poate fi goala.");
                else
                {
                    if (check == false)
                        Months.error.Add("Alimentarea trebuie sa fie formata doar din numere naturale.");

                    if (int.Parse(textBox4.Text) < 0)
                        Months.error.Add("Alimentarea nu poate fi un numar negativ.");
                }
            }

            check = Int32.TryParse(textBox5.Text, out number);
            if (check == false || textBox5.Text == "" || int.Parse(textBox5.Text) < 0)
            {
                textBox5.BackColor = System.Drawing.Color.Red;
                if (textBox5.Text == "")
                    Months.error.Add("Consumul nu poate fi gol.");
                else
                {
                    if (check == false)
                        Months.error.Add("Consumul trebuie sa fie format doar din numere naturale.");

                    if (int.Parse(textBox5.Text) < 0)
                        Months.error.Add("Consumul nu poate fi un numar negativ.");
                }
                
            }


            check = Int32.TryParse(textBox6.Text, out number);
            if (check == false || textBox6.Text == "" || int.Parse(textBox6.Text) < 0){
                textBox6.BackColor = System.Drawing.Color.Red;
                if (textBox6.Text == "")
                    Months.error.Add("Cantitatea de ADBLU nu poate fi goala.");
                else
                {
                    if (check == false)
                        Months.error.Add("Cantitatea de ADBLU este formata din numere naturale.");

                    if (int.Parse(textBox6.Text) < 0)
                        Months.error.Add("Cantitatea de ADBLU nu poate fi un numar negativ.");
                }
            }

            check = Int32.TryParse(textBox7.Text, out number);
            if (check == false || textBox7.Text == "" || int.Parse(textBox8.Text) - int.Parse(textBox7.Text) < 0){
                textBox7.BackColor = System.Drawing.Color.Red;
                if (textBox7.Text == "")
                    Months.error.Add("Kilometri la pornire trebuie specificati.");
                else
                {
                    if (check == false)
                        Months.error.Add("Kilometri la pornire trebuie sa fie formati doar din numere naturale.");
                }

            }
            check = Int32.TryParse(textBox8.Text, out number);
            if (check == false || textBox8.Text == "" || int.Parse(textBox8.Text) - int.Parse(textBox7.Text) < 0)
            {
                textBox8.BackColor = System.Drawing.Color.Red;
                if (textBox8.Text == "")
                    Months.error.Add("Kilometri la sosire trebuie specificati.");
                else
                {

                    if (check == false)
                        Months.error.Add("Kilometri la sosire trebuie sa fie formati doar din numere naturale.");

                    if (int.Parse(textBox8.Text) - int.Parse(textBox7.Text) < 0)
                        Months.error.Add("Numarul de km la sosire trebuie sa fie mai mare decat nr de km la plecare.");
                }
            }

            check = Int32.TryParse(textBox9.Text, out number);
            if (check == false || textBox9.Text == "" || int.Parse(textBox9.Text) < 0 || int.Parse(textBox9.Text) > 23)
            {
                textBox9.BackColor = System.Drawing.Color.Red;
                if (textBox9.Text == "")
                    Months.error.Add("Ora nu poate fi goala.");
                else
                {
                    if (check == false)
                        Months.error.Add("Ora trebuie sa fie formata din numere intregi pozitive..");
                    if (int.Parse(textBox9.Text) < 0)
                        Months.error.Add("Ora trebuie sa fie mai mare sau egala cu 0.");
                    if (int.Parse(textBox9.Text) > 23)
                        Months.error.Add("Ora trebuie sa fie cel mult egala cu 23.");
                }
            }

            check = Int32.TryParse(textBox10.Text, out number);
            if (check == false || textBox10.Text == "" || int.Parse(textBox10.Text) < 0 || int.Parse(textBox10.Text) > 59)
            {
                textBox10.BackColor = System.Drawing.Color.Red;
                if (textBox10.Text == "")
                    Months.error.Add("Minutul nu pot fi gol.");
                else
                {
                    if (check == false)
                        Months.error.Add("Minutul trebuie sa fie format doar din numere naturale.");

                    if (int.Parse(textBox10.Text) < 0)
                        Months.error.Add("Minutul nu poate fi negativ.");
                    if (int.Parse(textBox10.Text) > 59)
                        Months.error.Add("Minutul nu poate fi mai mare decat 59.");
                }
            }

            if (textBox11.Text == "")
            {
                textBox11.BackColor = System.Drawing.Color.Red;
                Months.error.Add("Ruta trebuie sa contina cel putin un caracter.");
            }

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
        public int check_duplicate()
        {
            DataTable documente = tabelDataSet.Document;
            int i,
                ok;
            string check_hour;
            ok = 1;
            check_hour = textBox9.Text + ":" + textBox10.Text;
            for (i = 0; i < documente.Rows.Count; i++)
            {
                if ((int)documente.Rows[i]["Data"] == int.Parse(textBox1.Text) &&
                    (int)documente.Rows[i]["Document_no"] == int.Parse(textBox2.Text) &&
                    documente.Rows[i]["Car_number"].ToString() == comboBox1.SelectedItem.ToString() &&
                    documente.Rows[i]["Driver_Name"].ToString() == comboBox2.SelectedItem.ToString() &&
                    (int)documente.Rows[i]["Fuel"] == int.Parse(textBox4.Text) &&
                    (int)documente.Rows[i]["Km_start"] == int.Parse(textBox7.Text) &&
                    (int)documente.Rows[i]["Km_end"] == int.Parse(textBox8.Text) &&
                    documente.Rows[i]["Hours_start"].ToString() == check_hour &&
                    (int)documente.Rows[i]["Consumption"] == int.Parse(textBox5.Text) &&
                    (int)documente.Rows[i]["ADBLU"] == int.Parse(textBox6.Text) &&
                    documente.Rows[i]["Route"].ToString() == textBox11.Text &&
                    (int)documente.Rows[i]["Month_nr"] == DateTime.Now.Month)
                    {
                                ok = 0;

                    }
            }
            return ok;


        }
        public void add_Document()
        {
            DateTime date = DateTime.Now;
            MessageBoxButtons yes = MessageBoxButtons.YesNo;
            DialogResult answer;
            answer = MessageBox.Show(this, "Doriti sa salvati?", "", yes);
            int month ;
            if (textBox3.Text != DateTime.Now.Month.ToString())
                month = int.Parse(textBox3.Text);
            else
            {
                month = DateTime.Now.Month;
            }

            if (answer == DialogResult.Yes)
            {
                int result;
                string check_hour,
                    kilometers;
                check_hour = textBox9.Text + ":" + textBox10.Text;
                result = (int.Parse(textBox8.Text) - int.Parse(textBox7.Text));
                kilometers = result.ToString();
                MessageBox.Show("Datele au fost introduse.");
                documentTableAdapter.InsertDocument(
                    int.Parse(textBox1.Text), //data
                    int.Parse(textBox2.Text), //document_no
                    comboBox1.SelectedItem.ToString(), 
                    comboBox2.SelectedItem.ToString(),
                    int.Parse(textBox4.Text), //Fuel
                    int.Parse(textBox7.Text), //km start
                    int.Parse(textBox8.Text), //km end
                    check_hour, //ore functionare - string / concatenare ore
                    kilometers, //kilometri parcursi
                    int.Parse(textBox5.Text),
                    int.Parse(textBox6.Text),
                    textBox11.Text,
                    month
                    );

                documentTableAdapter.Fill(tabelDataSet.Document);
                documentTableAdapter.Update(tabelDataSet.Document);
                default_color();
                default_buttons();
                button3.Visible = false;
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (validate_datas() == 1)
            {
                if (check_duplicate() == 1)
                {
                    add_Document();
                }
                else
                {
                    MessageBoxButtons yes = MessageBoxButtons.YesNo;
                    DialogResult answer;
                    answer = MessageBox.Show(this, "Datele introduse exista deja. Doriti sa le adaugati inca o data?", "", yes);
                    if (answer == DialogResult.Yes)
                    {
                        add_Document();
                    }

                }
            }
            else
            {
                MessageBox.Show("Unele date nu sunt introduse sau nu sunt introduse in formatul cerut.");
                default_color();
                wrong_elements();
                button3.Visible = true;
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Errors error = new Errors();
            error.ShowDialog();
        }

    }
}
