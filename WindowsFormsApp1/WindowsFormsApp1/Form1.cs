using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Btn1.Checked)
            {
                double t1 = Convert.ToDouble(txt1.Text)/1000;
                txt2.Text = Convert.ToString(t1);
                label4.Visible = false;
                txt2.BackColor = Color.White;

            }
            if (Btn2.Checked)
            {
                double t1 = Convert.ToDouble(txt1.Text) *1000;
                txt2.Text = Convert.ToString(t1);
                label4.Visible = false;
                txt2.BackColor = Color.White;

            }
            if (Btn3.Checked)
            {
                double t1 = Convert.ToDouble(txt1.Text) *100;
                txt2.Text = Convert.ToString(t1);
                label4.Visible = false;
                txt2.BackColor = Color.White;

            }
            if (!Btn1.Checked && !Btn2.Checked && !Btn3.Checked)
            {
                label4.Visible = true;
                txt2.BackColor=Color.Red; 
            }
        }

    
    }
}
