using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16TDD
{
    class Lab_16Test
    {

        public static bool PrimeTest(int num1)
        {
            //actual math being done to check if the number is prime
            if (num1 == 0) return false;
            if (num1 == 1) return false;

            for (int i = 2; i < num1; i++)
                if (num1 % i == 0)
                {
                    return false;
                }
            return true;
        }



    }
}       



