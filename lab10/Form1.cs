using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score.Text = $"{GetScore(5)} - {GetScore(1)}";
        }

        private int GetScore(double lambda)
        {
            double S = 0;
            int m = 0;
            Random random = new Random();

            while (S >= -lambda)
            {
                S += Math.Log(random.NextDouble());
                m++;
            }
            return m;
        }

    }
}
