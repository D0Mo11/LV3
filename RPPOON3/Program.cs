using System;

namespace RPPOON3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset first = new Dataset("csv.txt");
            Dataset second = (Dataset)first.Clone();

            first.Print();
            second.Print();
            first.ClearData();
            first.Print();  // Nece nista ispisati jer je ocisceno
            second.Print();

        }
    }
}
