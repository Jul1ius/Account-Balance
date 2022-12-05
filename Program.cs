using System;

namespace Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vnoska = Console.ReadLine();
            double obshtoPari = 0;

            while (vnoska != "NoMoreMoney")
            {
                double secNum = double.Parse(vnoska);
                if (secNum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {secNum:f2}");
                obshtoPari += secNum;
                vnoska = Console.ReadLine();
            }
            Console.WriteLine($"Total: {obshtoPari:f2}");
        }
    }

}
