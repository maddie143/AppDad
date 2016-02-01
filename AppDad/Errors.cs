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
    public partial class Errors : Form
    {
        public Errors()
        {
            InitializeComponent();

            int i;
            string[] check = Months.error.ToArray();
            for (i = 0; i < check.Length; i++)
            {
                listBox1.Items.Add(check[i]);
            }
            Months.delete_list();
        }

        private void Errors_Load(object sender, EventArgs e)
        {

        }
    }
}
