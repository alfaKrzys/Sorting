using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class RandomData
    {
        public static int[] RandomInt(int min, int max, int length)
        {
           
            int[] result = new int[length];

            Random randNum = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = randNum.Next(min, max);
            }

            return result;
        }
    }
}
