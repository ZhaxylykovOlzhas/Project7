using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeOfArray
{
    public class Class1
    {
            public readonly int min;
            public readonly int max;
            public readonly int[] array;

            public Class1(int min, int max)
            {
                this.min = min;
                this.max = max;
                array = new int[max - min + 1];
            }

            public int this[int index]
            {
                get
                {
                    return array[index - min];
                }
                set
                {
                    array[index - min] = value;
                }
            }


        
    }
}
