using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationApp
{
    public partial class Form1 : Form
    {
        localhost.Calculation ws = new localhost.Calculation();
        double a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnResult.Text = "Result";
        }


        //Add (+)
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TxtNumber1.Texts);
            b = Convert.ToDouble(TxtNumber2.Texts);

            c = ws.Add(a, b);

            string result = Convert.ToString(c);
            BtnResult.Text = result;

        }


        //sub (-)
        private void BtnSub_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TxtNumber1.Texts);
            b = Convert.ToDouble(TxtNumber2.Texts);

            c = ws.Subtract(a, b);

            string result = Convert.ToString(c);
            BtnResult.Text = result;
        }

        //Mul (*)
        private void BtnMul_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TxtNumber1.Texts);
            b = Convert.ToDouble(TxtNumber2.Texts);

            c = ws.Multiply(a, b);

            string result = Convert.ToString(c);
            BtnResult.Text = result;
        }

        //Div (/)
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TxtNumber1.Texts);
            b = Convert.ToDouble(TxtNumber2.Texts);

            c = ws.Divide(a, b);

            string result = Convert.ToString(c);
            BtnResult.Text = result;
        }

    }
}
