using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight k1 = new Knight();
            k1.Id = 1;
            HeroesTable heroes = new HeroesTable(5);
        }
    }
}
