/*
 * 2/1/2021
 * CSC 153
 * Branden Alder
 * hardcoded sales list sales and total
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW1_alderb6714
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hard code sales and declare total using totalSales method
            double[] sales = { 1245.67, 1189.55, 1098.72, 1456.88, 2109.34, 1987.55, 1872.36 };
            double total = totalSales(sales);
            // List sales
            listSales(sales);
            //Put out total of sales
            Console.Write("Total of sales: " + total);


            //Keep console open
            Console.ReadLine();
        }

        public static double totalSales(double[] arr) // Get total of sales
        {
            double total = 0;
           
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            return total;
        }
        public static void listSales(double[] arr)//Write Sales into console
        {
            
            Console.WriteLine("Sales:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] );
            }
        }
    }
}

