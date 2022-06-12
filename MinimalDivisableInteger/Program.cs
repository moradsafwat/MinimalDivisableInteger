using System;
using System.Text;

namespace MinimalDivisableInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimalDivisableInt(11));
        }

        public static int MinimalDivisableInt(int n)
        {
            int VarN = n;
            StringBuilder TempNString = new StringBuilder();
            int digitsSum;

            while (VarN <= 1000)
            {
                if(VarN % n == 0)
                {
                    digitsSum = 0;
                    TempNString.Clear();
                    TempNString.Append(VarN);

                    for(int i=0; i < TempNString.Length; i++)
                    {
                        digitsSum += Convert.ToInt32(char.GetNumericValue(TempNString[i]));
                        if (digitsSum > n)
                            break;
                    }
                    if (digitsSum == n)
                        return VarN;
                }
                VarN++;

            }
            return 0;
        }
    }
}
