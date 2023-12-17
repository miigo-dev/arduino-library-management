using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace Arduino_Integrated_LMS
{
    public partial class MainDashboardForm : Form
    {
        public MainDashboardForm()
        {
            InitializeComponent();
            Doughnut(gunaChart1);
            RoundedBar(gunaChart2);
            Spline(gunaChart3);
        }

        public static void Doughnut(GunaChart chart)
        {
            string[] months = { "January", "February", "March", "April" };

            // Chart configuration
            chart.Title.Text = "Books";
            chart.Legend.Position = LegendPosition.Left;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            // Create a new dataset 
            var dataset = new GunaDoughnutDataset();

            // Populate dataset with random numbers
            var r = new Random();
            for (int i = 0; i < months.Length; i++)
            {
                int num = r.Next(10, 100);

                // Add data point with the label being the month
                dataset.DataPoints.Add(months[i], num);
            }

            // Add the dataset to the chart's Datasets
            chart.Datasets.Add(dataset);

            // An update was made to re-render the chart
            chart.Update();
        }

        public static void RoundedBar(GunaChart chart)
        {
            string[] shelf = { "Horror", "Fiction", "Romance", "Shelf 4", "Shelf 5", "Shelf 6"};

            //Chart configuration
            chart.Title.Text = "Most Issued";
            chart.Misc.BarCornerRadius = 10;
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var dataset = new GunaBarDataset();
            var r = new Random();
            for (int i = 0; i < shelf.Length; i++)
            {
                //random number
                int num = r.Next(10, 50);

                dataset.DataPoints.Add(shelf[i], num);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }

        public static void Spline(GunaChart chart)
        {
            string[] weeks = { "18th", "19th", "20th", "21st", "22nd" };

            //Chart configuration 
            chart.Title.Text = "Analytics";
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 3;
            dataset.PointStyle = PointStyle.Circle;
            var r = new Random();
            for (int i = 0; i < weeks.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                dataset.DataPoints.Add(weeks[i], num);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}