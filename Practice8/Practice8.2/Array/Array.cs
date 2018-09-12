using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    public class Massiv
    {
        private int[] mas;

        public Massiv()
        {
            Size =0;
            this.mas = new int[Size];
        }

        public Massiv(int size)
        {
            Size = size;
            this.mas = new int[Size];
        }

        public int Size { get; set; }

        public int this[int i]
        {
            get
            {
                return this.mas[i];
            }
            set
            {
                this.mas[i] = (int)Math.Pow((int)value, 2);
            }
        }

    }
}