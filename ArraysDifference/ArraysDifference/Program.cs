using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "Alex", "Dima", "Kate", "Galina", "Ivan" };
            string[] array2 = { "Dima", "Ivan", "Kate" };
            //new array to set names that doesn't exist in array2
            string[] arrayDif = new string[0];
            int x = array2.Length;
            int y = 0;
            for (int i=0; i < array1.Length; i++)
            {
                foreach (string name in array2)
                {
                    //compare name from array1 with every name in array2
                    //increment y every time if names different
                    if (name != array1[i])
                    {
                        y++;
                    }
                    //if name from array1 doesn't match any name in array2
                    //increase length of arrayDif by 1 and set this name to arrayDif
                    if (y == x)
                    {
                        Array.Resize(ref arrayDif, arrayDif.Length + 1);
                        arrayDif[arrayDif.Length - 1] = array1[i];
                    }
                }
            }
            foreach (string name in arrayDif)
            {
                Console.WriteLine("{0}", name);
            }
        }
    }
    
}
