using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] xs = new double[] { 1, 2, 3, 4, 5 };
            double[] ys = new double[] { 1, 4, 9, 16, 25 };
            formsPlot1.Plot.AddPie(ys);
            formsPlot1.Refresh();
        }
    }
}
