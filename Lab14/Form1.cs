using System;
using System.Windows.Forms;

namespace Lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDprimerDataSet.osntabl' table. You can move, or remove it, as needed.
            this.tableLab14TableAdapter.Fill(this.lab14DataSet.TableLab14);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString("d");
            tableLab14BindingSource.Filter = "datavv = '" + dateTimePicker1.Value.ToString("d") + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            tableLab14BindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += dateTimePicker2.Value.ToString("d")+"       ";
            textBox1.Text += dateTimePicker3.Value.ToString("d");
            tableLab14BindingSource.Filter = "datavv>= '" + dateTimePicker2.Value.ToString("d") + "' and datavv<= '" + dateTimePicker3.Value.ToString("d") + "' ";
        }
    }
}