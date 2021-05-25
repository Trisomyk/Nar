using System;
using System.Linq;

namespace NarcissisticNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 153;
            Console.WriteLine(Narcissistic(value) + " vs " + NarcissisticLINQ(value));
        }

        
        public static bool Narcissistic(int value)
        {
            bool flag = true;
            int[] array = new int[10];
            int num = value;
            int i = 0;
            int result = 0;

            while (num != 0 )
            {
                array[i] = num % 10;
                num /= 10;
                i++;
            }

            for (int y = 0; y < i; y++)
            {
                result += (int)Math.Pow(array[y], i);
            }

            if (result != value)
            {
                flag = false;
            }
            return flag;
        }

        
        public static bool NarcissisticLINQ(int value)
        {
            var str = value.ToString(); 
            bool result = str.Sum(c => Math.Pow(Convert.ToInt64(c.ToString()), str.Length)) == value;
            return result;
        }
    }
}
