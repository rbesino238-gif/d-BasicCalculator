using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace d_BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(comboBox1.SelectedItem.ToString());
                float num2 = float.Parse(comboBox1.SelectedItem.ToString());
                float result = 0;

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Additon":
                        BasicCalculation.Add(num1, num2);
                        break;
                    case "division":
                        BasicCalculation.Add(num1, num2);
                        break;
                    case "Multiplication":
                        BasicCalculation.Add(num1, num2);
                        break;
                    case "Subtraction":
                        BasicCalculation.Add(num1, num2);
                        break;
                }
                pictureBox1 = new PictureBox();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid number. ", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
