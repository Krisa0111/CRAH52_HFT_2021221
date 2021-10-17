using System;
using CRAH52_HFT_2021221.Data;

namespace CRAH52_HFT_2021221.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ClubsDbContext ctx = new ClubsDbContext();
            ctx.SaveChanges();
            foreach (var item in ctx.Events)
            {
                Console.WriteLine(item.EventName);
            }
            Console.ReadLine();
        }
    }
}
