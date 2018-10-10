using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Find_The_Unique_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySolution
            int GetUnique(IEnumerable<int> numbers)
            {
                List<int> numbersList = numbers.ToList();
                numbersList.Sort();
                if (numbersList[0] != numbersList[1])
                {
                    return numbersList[0];
                }
                return numbersList[numbersList.Count - 1];
            }
        }
    }
}
