using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5._4
{
    public class Test
    {
        
        public static int[] SortByDescendingOrder(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int k = 0; k < array.Length - 1; k++)
                {

                    if (array[k] < array[k + 1])
                    {
                        int temporaryNumber = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = temporaryNumber;
                    }
                }
            }


            return array;
        }
        public static int[] SortByDescendingOrder(int[] array, string value)
        {
            return new int[5];

        }
    }
}
