using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string snum1, snum2, sresult, Symbol;
            double num1, num2, result = 0;

            snum1 = textBox1.Text;
            snum2 = textBox2.Text;
            Symbol = comboBox1.Text;
            num1 = Convert.ToDouble(snum1);
            num2 = Convert.ToDouble(snum2);

            switch (Symbol)
            {
                case "+":result = num1 + num2;break;
                case "-":result = num1 - num2;break;
                case "*":result = num1 * num2;break;
                case "/":result = num1 / num2;break;
                default:MessageBox.Show("请选择数学符号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            sresult = result.ToString();
            textBox3.Text = sresult;



        }
    }
}
