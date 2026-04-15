using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_conversion
{

    public partial class Form1 : Form
    {


        double res;


        public Form1()
        {

            InitializeComponent();
            KeyPreview = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convertbutt_Click(object sender, EventArgs e)
        {
            double x;

            x = Convert.ToDouble(textBox1.Text);
            if (frombox.SelectedItem == "USD" && tobox.SelectedItem == "SAR")
            {
                res = (x * 3.75);
            }

            else if (frombox.SelectedItem == "USD" && tobox.SelectedItem == "YER")
            {
                res = (x * 2250);
            }
            else if (frombox.SelectedItem == "SAR" && tobox.SelectedItem == "USD")
            {
                res = (x * 0.27);
            }
            else if (frombox.SelectedItem == "SAR" && tobox.SelectedItem == "YER")
            {
                res = (x * 600);

            }
            else if (frombox.SelectedItem == "YER" && tobox.SelectedItem == "SAR")
            {
                res = (x * 0.00166666);
            }
            else if (frombox.SelectedItem == "YER" && tobox.SelectedItem == "USR")
            {
                res = (x * 0.00044);
            }
            else if (frombox.SelectedItem == "SAR" && tobox.SelectedItem == "SAR")
            {
                res = x;
            }
            else if (frombox.SelectedItem == "USD" && tobox.SelectedItem == "USD")
            {
                res = x;
            }
            else if (frombox.SelectedItem == "YER" && tobox.SelectedItem == "YER")
            {
                res = x;
            }
            else
            {
                MessageBox.Show("تأكد انك اخترت عملة");
            }
            
                result.Text = res.ToString();
            }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        { 
                
            
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

           
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress= true;
                convertbutt_Click(sender, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fm_Click(object sender, EventArgs e)
        {

        }

        private void t_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
