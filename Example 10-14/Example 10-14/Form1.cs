using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_10_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------
        int BMM(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return BMM(b, a % b);
        }
        //----------------------------------------------------------------
        int KMM(int a, int b)
        {
            return (a * b) / BMM(a, b);
        }
        //----------------------------------------------------------------
        private void btnBmmKmm_Click(object sender, EventArgs e)
        {
            int a, b;
            a = txtDigit1.Text == "" ? 0 : int.Parse(txtDigit1.Text);
            b = txtDigit2.Text == "" ? 0 : int.Parse(txtDigit2.Text);
            if (b == 0)
            {
                MessageBox.Show("ERROR Division By Zero");
                return;
            }
            MessageBox.Show("BMM(" + a + "," + b + ")=" + BMM(a, b) + " ,KMM=" + KMM(a, b));
        }
    }
}
