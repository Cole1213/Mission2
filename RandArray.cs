using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RandArray
    {
        public int[] createArray(int num)
        {
            //Create the empty array
            int[] rollTotals = new int[13];

            //initialize variables
            int die1 = 0;
            int die2 = 0;
            int total = 0;

            //Initialize random object
            Random rnd = new Random();

            for (int i = 0; i < num; i++) //loop through num
            {
                die1 = rnd.Next(1, 7); //random number
                die2 = rnd.Next(1, 7); //random number
                total = die1 + die2;

                rollTotals[total]++; //Increment array accordingly
            }
            
            //Return rolls array
            return rollTotals;
            
        }
    }
}
