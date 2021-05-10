/*
 * 4/20/2021
 * CSC 153
 * Branden Alder
 * Program taking Sales analysis program and changing to lists
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
            totalText.Text = ListCalculations.GetTotal(Sales.salesList).ToString("C");
            averageText.Text = ListCalculations.GetAverage(Sales.salesList).ToString("C");
            largestText.Text = ListCalculations.GetLargest(Sales.salesList).ToString("C");
            smallestText.Text = ListCalculations.GetSmallest(Sales.salesList).ToString("C");
        }

        private void Form1_Load(object sender, EventArgs e) // puts sales in listbox
        {
            Display.DisplaySales(salesListBox, Sales.salesList);
        }
    }
}
