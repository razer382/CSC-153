/**
 * 3/16/2021
 * CSC 153
 * Branden Alder
 * Employee Class assignment. 
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
using EmployeeClassLibrary;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) // Closes app
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e) // Makes objects and stores them in text labels.
        {
            Employee one = new Employee("Susan Meyers", "47899", "Accounting", "Vice President");
            Employee two = new Employee("Mark Jones", "39119", "IT", "Programmer");
            Employee three = new Employee("Joy Rogers","81774","Manufacturing","Engineer");
            firstNameText.Text = one.Name;
            firstIdText.Text = one.IdNumber;
            firstDepartmentText.Text = one.Department;
            firstPositionText.Text = one.Position;
            secondNameText.Text = two.Name;
            secondIdText.Text = two.IdNumber;
            secondDepartmentText.Text = two.Department;
            secondPositionText.Text = two.Position;
            thirdNameText.Text = three.Name;
            thirdIdText.Text = three.IdNumber;
            thirdDepartmentText.Text = three.Department;
            thirdPositionText.Text = three.Position;
        }
    }
}
