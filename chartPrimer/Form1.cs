using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chartPrimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillChart();
        }
        //metoda kojom popunjavamo Chart
        private void fillChart()
        {
            chart1.Series["Salary"].Points.AddXY("Ajay", "10000");
            chart1.Series["Salary"].Points.AddXY("Ramesh", "8000");
            chart1.Series["Salary"].Points.AddXY("Ankit", "7000");
            chart1.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            chart1.Series["Salary"].Points.AddXY("Suresh", "8500");

            chart1.Titles.Add("Salary Chart");
        }

    }
}
