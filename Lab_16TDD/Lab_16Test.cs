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
            if (num1 == 0 || num1 == 1)
            {
                Console.WriteLine(num1 + " is not prime number");
                return false;
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " is not prime number");
                        return false;
                    }

                }
                Console.WriteLine(num1 + " is a prime number");
                return true;

            }

            }
        }
    }       



