using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    class DefaultClass
    {
        private int[] array;
        private int size = 0;

        public DefaultClass(int N)
        {
            Random rand = new Random();
            if (N < 10)
            {               
                size = rand.Next(10, 20);
            } else
            {
                size = N;
            }
            array = new int[size];
            for (int i = 0; i < size; ++i)
            {
                array[i] = rand.Next(1, 10);
            }
        }
        public string ChetSum(int N)
        {
            string str = "";
            int sum = 0;
                for (int i = 0; i < N; ++i)
                {
                    if ((array[i] > 0) && (array[i] % 2 == 0))
                    {
                        sum++;
                    }
                }
                str += sum;
                return str;
        }
        //NeChet
        public string ChetSum()
        {   
            string str = "";
            int sum = 0;
                for (int i = 0; i < array.Length; ++i)
                {
                    if ((array[i] > array.Length) && (array[i] % 2 != 0))
                    {
                        sum++;
                    }
                }
            str += sum;
            return str;
        }

        public string PrintArray()
        {
            string str = "";
            for(int i = 0; i < array.Length; ++i)
            {
                str += array[i];
            }
            return str;
        }
    }
}
