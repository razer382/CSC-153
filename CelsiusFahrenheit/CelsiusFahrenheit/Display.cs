using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelsiusToFahrenheitLibrary;

namespace CelsiusFahrenheit
{
    public static class Display
    {
        public static void DisplayConversion(ListBox a) // takes a list box and adds items to it using the convert method from the lib
        {
            for (int i = 0; i <= 20; i++)
            {
                a.Items.Add(i + " C = " + Calculations.Convert(i) + " F");
            }
        }
    }
}
