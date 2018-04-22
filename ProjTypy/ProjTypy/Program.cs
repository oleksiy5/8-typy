using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjTypy
{
    class Program
    {
        static void Main(string[] args)
        {            
            var gun = new Gun();
            string command = "";
            while (command != "end")
            {
                command = Console.ReadLine();
                if(command == "one")
                    gun.StartShooting(ShotCount.one);
                else if (command == "two")
                    gun.StartShooting(ShotCount.two);
                else if(command == "many")
                    gun.StartShooting(ShotCount.many);
            }
        }

    }

    class Gun
    {
        public void StartShooting(ShotCount shotCount)
        {
            switch (shotCount)
            {
                case ShotCount.one:
                    Console.WriteLine("Bum");
                    Thread.Sleep(300);
                    Console.WriteLine(".");
                    break;
                case ShotCount.two:
                    Console.WriteLine("Bum");
                    Thread.Sleep(300);
                    Console.Write(".");
                    Thread.Sleep(300);
                    Console.Write(".");
                    break;
                case ShotCount.many:
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Bum");
                        Thread.Sleep(300);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                    }
                    break;
            }
        }
    }

    enum ShotCount
    {
        one,
        two,
        many
    }

}
