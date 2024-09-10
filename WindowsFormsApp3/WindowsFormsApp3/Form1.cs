using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Trainees : Form
    {
        List<Data> data = new List<Data>();
        public Trainees()
        {
            InitializeComponent();
             
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string name = txt1.Text;
            string phone=txt2.Text;
            string birthdate = dateTimePicker1.Text;
            data.Add(new Data() {Name=name,Phone=phone,Birthdate=birthdate });
            
            dataGridView1.DataSource= data;
            dataGridView1.DataSource=null;
            dataGridView1.DataSource = data;

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txt2.Text = dataGridView1.SelectedCells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedCells[2].Value.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.CurrentRow.Index;
            data[ind].Name = txt1.Text;
            data[ind].Phone = txt2.Text;
            data[ind].Birthdate=dateTimePicker1.Text;
            dataGridView1 .DataSource = null;
            dataGridView1.DataSource = data;
        }

    }
}
