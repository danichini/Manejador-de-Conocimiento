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


        private void button2_Click(object sender, EventArgs e)
        {
            conocimientoTableAdapter1.Fill(dataSet1.conocimiento);
        }

        private void conocimientoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conocimientoTableAdapter1.Fill(dataSet1.conocimiento);
            id_conocTextBox.Text = "";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(id_conocTextBox.Text);
            if (ID > 1)
            {
                conocimientoTableAdapter1.UpdateQuery(de_conocTextBox.Text, re_conocTextBox.Text, fe_conocDateTimePicker.Value, ID);
                conocimientoTableAdapter1.Fill(dataSet1.conocimiento);
            }
            else
            {
                MessageBox.Show("Operacion Invalida");
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            conocimientoTableAdapter1.DeleteQuery(int.Parse(id_conocTextBox.Text));
            conocimientoTableAdapter1.Fill(dataSet1.conocimiento);
            button6.PerformClick();
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            id_conocTextBox.Text = "";
            de_conocTextBox.Text = "";
            re_conocTextBox.Text = "";

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int ID = int.Parse(id_conocTextBox.Text);
            conocimientoTableAdapter1.GetDataBy2(ID);
            conocimientoTableAdapter1.FillBy(dataSet1.conocimiento, ID);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conocimientoTableAdapter1.Fill(dataSet1.conocimiento);
        }
    }
}
