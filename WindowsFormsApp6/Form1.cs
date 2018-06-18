using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string descripcion = de_conocTextBox.Text;
            string referencia = re_conocTextBox.Text;
            DateTime date = fe_conocDateTimePicker.Value;
            conocimientoTableAdapter1.InsertQuery(descripcion, referencia, date);
            conocimientoTableAdapter1.Fill(dataSet1.conocimiento);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conocimientoTableAdapter1.Fill(dataSet1.conocimiento);
        }

        private void conocimientoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(id_conocTextBox.Text);
            conocimientoTableAdapter1.UpdateQuery(de_conocTextBox.Text, re_conocTextBox.Text, fe_conocDateTimePicker.Value, ID);
            conocimientoTableAdapter1.Fill(dataSet1.conocimiento);
        }

        private void id_conocTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void de_conocTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conocimientoTableAdapter1.DeleteQuery(int.Parse(id_conocTextBox.Text));
            conocimientoTableAdapter1.Fill(dataSet1.conocimiento);
        }
    }
}
