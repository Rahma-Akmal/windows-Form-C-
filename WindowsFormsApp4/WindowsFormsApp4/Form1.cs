using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            foreach(object item in cl1.CheckedItems )
            {

                cl2.Items.Add(item.ToString());
            }
            for (int i = cl1.CheckedIndices.Count - 1; i >= 0; i--)
            {
                cl1.Items.RemoveAt(cl1.CheckedIndices[i]);
            }
        }

        private void cl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            foreach (object item in cl1.Items)
            {

                cl2.Items.Add(item.ToString());

            }
            cl1.Items.Clear();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
           foreach(string item in cl2.CheckedItems)
           {
                cl1.Items.Add(item.ToString());
           }

            for (int i = cl2.CheckedIndices.Count - 1; i >= 0; i--)
            {
                cl2.Items.RemoveAt(cl2.CheckedIndices[i]);
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            foreach(string item in cl2.Items)
            {
                cl1.Items.Add(item.ToString());
            }
            if (cl2.Items.Count > 0)
            {
                cl2.Items.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {

                cl2.Visible = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                cl2.Visible=true;
                
            }
            if (comboBox1.SelectedIndex == 2)
            {
                cl2.Visible = true;
            }

        }
    }
}
