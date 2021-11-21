using System;
using CRAH52_HFT_2021221.Data;
using CRAH52_HFT_2021221.Logic; // SZEDD KI TE BAROM
using CRAH52_HFT_2021221.Repository; // EZT IS

namespace CRAH52_HFT_2021221.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ClubsDbContext ctx = new ClubsDbContext();

            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}
