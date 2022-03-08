using System;

namespace Task_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin:");
            Eight();

        }
        public static int Three()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < number; i+=3)
            {
                if (number < 50 )
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return number;
        }
        public static int Five()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count= 0;
            for (int i = 0; i < number; i += 5)
            {
                if (number > 50 && number < 100)
                {

                    count++;
                }
            }
            Console.WriteLine(count);
            return number;
        }
        public static int Eight()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count= 0;
            for (int i = 0; i < number; i += 8)
            {
                if (number > 100)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return number;
        }
    }
}
