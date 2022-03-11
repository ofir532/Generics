using Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class HeroesTable
    {
        private Knight[] knights;
        public HeroesTable(int size = 2)
        {
            if (size < 0)
            {
                throw new IndexNotValid("The size should be higer than 0. Size updated to 1.");
            }
            knights = new Knight[size];
        }
        public void AddHero(Knight kngiht, int index)
        {
            if (index < 0)
                throw new IndexNotValid("The size should be higer than 0. Size updated to 1.");
            else if (knights.Length < index)
                throw new IndexNotExist("");
            else if (knights[index] != null)
                throw new IndexIsNotNull("");

            knights[index] = kngiht;
        }
        public void RemoveHero(int index)
        {
            if (index < 0)
            {
                throw new IndexNotValid("The size should be higer than 0. Size updated to 1.");
            }
            else if (knights.Length < index)
            {
                throw new IndexNotExist("");
            }
            else if (knights[index] == null)
            {
                throw new IndexIsNull("");
            }
        }
    }
}
