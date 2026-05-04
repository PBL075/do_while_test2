using System;

namespace test_while
{
    class Program
    {
        static void Main()
        {
            int incercare = 0;

            do
            {
                incercare++;
                Console.WriteLine("Incercarea : " + incercare);
            }
            while (incercare < 0 );
        }
    }
}