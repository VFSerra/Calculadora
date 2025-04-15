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
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1= Convert.ToDouble(txtnum1.Text);
            num2= Convert.ToDouble(txtnum2.Text);
            result = (num1 + num2) ;
            txtresul.Text=result.ToString();
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
            result = (num1 - num2);
            txtresul.Text = result.ToString();
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
            result = (num1 / num2);
            txtresul.Text = result.ToString();
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
            result = Math.Sqrt(num1);
            txtresul.Text = result.ToString();
        }
    }
}
