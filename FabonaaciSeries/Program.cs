using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabonaaciSeries
{
    class FacbonaaciNumbers
    {
        public List<int> GetFabonacciNumbers()
        {
            List<int> FabonacciNo = new List<int>();
            FabonacciNo.Add(1);
            FabonacciNo.Add(1);

            for(int i = 0; i < 21; i++)
            {
                var temp = FabonacciNo[i] + FabonacciNo[i + 1];
                FabonacciNo.Add(temp);
            }

            return FabonacciNo;
        }

    }

    class PrimeNumbers
    {
        public bool getPrimeNumbers(int number)
        {
            bool _status = false;
            int count = 0;
            for(int i = 0; i < number; i++)
            {
                if (number % (i+1) == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                _status = true;
            }
           
            return _status;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FacbonaaciNumbers obj = new FabonaaciSeries.FacbonaaciNumbers();
            List<int> FabNumbers= obj.GetFabonacciNumbers();
            Console.WriteLine("Fabonacci Series:");
            foreach (int nos in FabNumbers)
            {
                Console.Write(nos + " ,");
            }
            Console.WriteLine();

            Console.WriteLine("Prime Numbers:");
            PrimeNumbers objPrime = new FabonaaciSeries.PrimeNumbers();
            int count = 0;
            for(int i = 1; i < 1000; i++)
            {
                if (count < 21)
                {
                    if (objPrime.getPrimeNumbers(i))
                    {
                        Console.Write(i + " ,");
                        count++;
                    }
                }
                else
                {
                    break;
                }
              
            }

            Console.Read();
        }
    }
}
