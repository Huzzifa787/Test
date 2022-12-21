namespace Test_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] xs = new double[] { 1, 2, 3, 4, 5 };
            double[] ys = new double[] { 1, 4, 9, 16, 25 };
            formsPlot1.Plot.AddScatter(xs, ys);
            formsPlot1.Refresh();
        }
    }
}