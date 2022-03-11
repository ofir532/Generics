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
            try
            {
                if (size < 0)
                    throw new IndexNotValid("Size Can't be lower than 0.");
            }
            catch(IndexNotValid)
            {
                Console.WriteLine("Size updated to 0");
                size = 0;
            }
            knights = new Knight[size];
        }
        public void AddHero(Knight kngiht, int index)
        {
            if (index < 0)
                throw new IndexNotValid("Index Can't be lower than 0.");
            if (knights.Length < index)
                throw new IndexNotExist("Index out of range");
            if (knights[index] != null)
                throw new IndexIsNotNull("The spot is already taken");

            knights[index] = kngiht;
        }
        public void RemoveHero(int index)
        {
            if (index < 0)
                throw new IndexNotValid("Index Can't be lower than 0.");
            if (knights.Length < index)
                throw new IndexNotExist("Index out of range");
            try
            {
                if (knights[index] == null)
                    throw new IndexIsNull("The spot is empty");
            }
            catch (IndexIsNull) { };

            knights[index] = null;

        }
        public int GetNumOfKnights()
        {
            int count = 0;
            for (int i = 0; i < knights.Length; i++)
            {
                if (knights[i] != null)
                    count++;
            }
            return count;
        }
        public Knight[] GetKnights()
        {
            int size = GetNumOfKnights();
            Knight[] newKnightsArray = new Knight[size];
            for (int i = 0,x = 0; i < knights.Length; i++)
            {
                if (knights[i] != null)
                {
                    newKnightsArray[x] = knights[i];
                    x++;
                }
            }
            return newKnightsArray;
        }
    }
}
