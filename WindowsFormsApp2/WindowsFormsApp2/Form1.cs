using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (txt1.Text is null || txt1.TextLength < 5)
            {
                l8.Visible = false;

                l3.Visible = true;
                l3.ForeColor = Color.Red;

            }
            if (!txt2.Text.Contains("@") || txt2.Text is null)
            {
                l8.Visible = false;

                l4.Visible = true;
                l4.ForeColor = Color.Red;
            }
            if (checkBox1.Checked != true && checkBox2.Checked != true && checkBox3.Checked != true)
            {
                l8.Visible = false;

                l7.Visible = true;
                l7.ForeColor = Color.Red;
            }
           
            if (txt1.TextLength >= 5 && txt2.Text.Contains("@") && (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true))
            { 
                l8.Visible = true;
                l8.ForeColor= Color.Green;
                l7.Visible = false;
                l4.Visible = false;
                l3.Visible = false;
            }



        }
    }
}
