/*
 * 4/14/2021
 * CSC 153
 * Branden Alder
 * Program taking array of sales and calculating total, average, largest, and smallest.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesAnalysisLibrary;

namespace SalesAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) // Closes application
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e) // Calculate button to add values in currency format to text labels
        {
            totalText.Text = ArrayCalculations.GetTotal(Sales.salesList).ToString("C");
            averageText.Text = ArrayCalculations.GetAverage(Sales.salesList).ToString("C");
            largestText.Text = ArrayCalculations.GetLargest(Sales.salesList).ToString("C");
            smallestText.Text = ArrayCalculations.GetSmallest(Sales.salesList).ToString("C");
        }

        private void Form1_Load(object sender, EventArgs e) // puts sales in listbox
        {
            Display.DisplaySales(salesListBox, Sales.salesList);
        }
    }
}
