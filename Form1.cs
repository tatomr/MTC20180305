using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int FirstValue = 0;
            int SecondValue = 0;
            bool numeric = true;

            numeric = (int.TryParse(txtFirst.Text, out FirstValue) && 
                int.TryParse(txtSecond.Text, out SecondValue));

            if (txtFirst.Text != null && txtSecond.Text != null && numeric)

            {
                if (rbAdd.Checked)
                {
                    txtResult.Text = (FirstValue + SecondValue).ToString();
                }

                if (rbSubtract.Checked)
                {
                    txtResult.Text = (FirstValue - SecondValue).ToString();
                }

                if (rbMultiply.Checked)
                {
                    txtResult.Text = (FirstValue * SecondValue).ToString();
                }

                if (rbDivide.Checked)
                {
                    txtResult.Text = (FirstValue / SecondValue).ToString();
                }
            }
            else
                MessageBox.Show("Numeic Values required.");
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Operator_Enter(object sender, EventArgs e)
        {

        }
    }
}
