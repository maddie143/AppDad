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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (textBox1.Text == UserPass.username)
                {
                    if (textBox2.Text == UserPass.password)
                    {
                        if (textBox3.Text != textBox4.Text)
                        {
                            MessageBox.Show("Parola repetata nu coincide cu parola noua.");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                        }
                        else
                        {
                            UserPass.password = textBox4.Text;
                            MessageBox.Show("Parola s-a schimbat cu succes.");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parola veche incorecta.");
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Username incorect.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    }
            }
            else
            {
                MessageBox.Show("Toate datele trebuie introduse.");

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool a = textBox2.UseSystemPasswordChar;
            if (a == false)
                textBox2.UseSystemPasswordChar = true;
            else
                textBox2.UseSystemPasswordChar = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool a = textBox3.UseSystemPasswordChar;
            if (a == false)
                textBox3.UseSystemPasswordChar = true;
            else
                textBox3.UseSystemPasswordChar = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool a = textBox4.UseSystemPasswordChar;
            if (a == false)
                textBox4.UseSystemPasswordChar = true;
            else
                textBox4.UseSystemPasswordChar = false;
        }
    }
}
