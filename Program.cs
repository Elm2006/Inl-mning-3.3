using System;
namespace Inlämning_3.__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bil");
            int timmar = int.Parse(Console.ReadLine());
            int kostnad = 80 * timmar;
            if (kostnad > 950)
            {
                kostnad = 950;
            }
            Console.WriteLine("Detta kommer att kosta "+kostnad+" kr.");
            Console.ReadKey();
        }
    }
}
