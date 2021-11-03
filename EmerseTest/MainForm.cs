using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmerseTest
{
    public partial class MainForm : Form
    {
        private BMICalculator bmicalc = new BMICalculator();
        private string name = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }
        public void InitializeGui()
        {
            labBMI.Text = string.Empty;
            labCate.Text = string.Empty;
            radioMetric.Checked = true;
            textBoxInch.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void desplay()
        {
            labNBmi.Text = "Normal BMI is between 18.55 and 24.9";
            if (radioMetric.Checked)
            {
                labNWeight.Text = "Normal weight should be between 50 and 68 Kg";
            }
            else
            {
                labNWeight.Text = "Normal weight should be between 113 and 152 lbs";
            }
            double result;
            if (radioMetric.Checked)
                result = bmicalc.CalculateMetric();
            else
                result = bmicalc.CalculateAmerican();

            labBMI.Text = result.ToString("f2");

            if (result < 18.5)
            {
                labCate.Text = "Underweight";
            }
            else if ((result >= 18.5) && (result <= 24.9))
            {
                labCate.Text = "Normal weight";
            }
            else if ((result >= 25.0) && (result<= 29.9))
            {
                labCate.Text = "Overweight (Pre-obesity)";
            }
            else if((result >= 30.0) && (result <= 34.9))
            {
                labCate.Text = "Overweight (Obesity class I)";
            }
            else if((result >= 35.0) && (result <= 39.9))
            {
                labCate.Text = "Overweight (Obesity class II)";
            }
            else if(result>=40)
            {
                labCate.Text = "Overweight (Obesity class III)";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadName();
            bmicalc.SetHeight(ReadHeight());
            bmicalc.SetWeight(ReadWieght());
            desplay();           
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxInch.Visible = false;
            UpdateText();
        }
        private void UpdateText()
        {
            if (radioMetric.Checked)
            {
                labHeight.Text = "Height (Cm)";
                labWeight.Text = "Weight (Kg)";
            }
            else
            {
                labHeight.Text = "Height (ft , in)";
                labWeight.Text = "Weight (lbs)";
            }
        }
        private void ReadName()
        {
            string name = NameTextBox1.Text;
            name.Trim();
            groupBox2.Text = name;
        }
        private double ReadInch()
        {
            double inch = 0.0;
            if (radioUS.Checked)
            {
                bool ok = double.TryParse(textBoxInch.Text, out inch);
                if (!ok)
                    MessageBox.Show("invaled Inch number");
            }
            return inch;
        }
        private double ReadHeight()
        {
            double height = 0.0;
            bool ok = double.TryParse(textBoxHeight.Text, out height);
            if (!ok)
            {
                MessageBox.Show("ERROR Invaled Number");
            }
            if (radioUS.Checked)
            {
                double getInch = ReadInch();
                height = height * 12;
                height = height + getInch;
            }
            return height;        
        }
        private double ReadWieght()
        {
            double wieght = 0.0;
            bool ok = double.TryParse(textBoxWeight.Text, out wieght);
            if (!ok)
            {
                MessageBox.Show("invaled wieght number");
            }
            return wieght;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInch_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioUS_CheckedChanged(object sender, EventArgs e)
        {
            textBoxInch.Visible = true;
            UpdateText();
        }

        private void labNBmi_Click(object sender, EventArgs e)
        {

        }
    }
}
