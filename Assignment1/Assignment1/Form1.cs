using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnshow_Click(object sender, EventArgs e)
        {
            
            //declare variable
            string week, month, year, day;


            //Assign varible
            week = txtweek.Text;
            month = txtmonth.Text;
            year = txtyear.Text;
            day = txtdaymonth.Text;

            //Display
            lbloutput.Text = day + " " + week + " " + month + " " + year;




        }
        private void button2_Click(object sender, EventArgs e)
        {

            
            
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtweek.Clear();
            txtmonth.Clear();
            txtyear.Clear();
            txtdaymonth.Clear();
            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
