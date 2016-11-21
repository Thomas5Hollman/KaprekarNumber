using System;

namespace KaprekarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            kaprekar(101, 9000);
            System.Threading.Thread.Sleep(10000);
        }

        static void kaprekar(int d, int k)
        {
            String OutputK = "";
            for (int i = d; i <= k; i++)
            {
                string KapTestInt = Math.Pow(i, 2).ToString();

                for (int j = 1; j < KapTestInt.Length; j++)
                {

                    if ((Convert.ToInt32(KapTestInt.Substring(0, j)) + (Convert.ToInt32(KapTestInt.Substring(j, KapTestInt.Length - j))) == i))
                    {
                        Console.WriteLine("kaprekar number identified: " + i);
                        OutputK = OutputK + i + ", ";
                    }

                }
                
            }
            Console.WriteLine("Kaprekar numbers: " + OutputK);
        }
        
    }
}
