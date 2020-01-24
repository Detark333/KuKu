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
        public string ChetSum(int N)
        {
            string str = "";
            int sum = 0;
            if (array == null)
            {
                array = new int[N];
                Random rand = new Random();
                for (int i = 0; i < N; ++i)
                {
                    array[i] = rand.Next(1, 10);
                }
                for (int i = 0; i < N; ++i)
                {
                    if ((array[i] > 0) && (array[i] % 2 == 0))
                    {
                        sum++;
                    }
                }
                str += sum;
                return str;
            } else
            {
                for (int j = 0; j < N; ++j)
                {
                    if ((array[j] > 0) && (array[j] % 2 == 0))
                    {
                        sum++;
                    }
                }
                str += sum;
                return str;
            }
            
        }

        public string NeChetSum(int N)
        {
            string str = "";
            int sum = 0;
            if (array == null)
            {
                array = new int[N];
                Random rand = new Random();
                for (int i = 0; i < N; ++i)
                {
                    array[i] = rand.Next(1, 10);
                }
                for (int i = 0; i < N; ++i)
                {
                    if ((array[i] > N) && (array[i] % 2 != 0))
                    {
                        sum++;
                    }
                }
            } else
            {
                for (int j = 0; j < N; ++j)
                {
                    if ((array[j] > N) && (array[j] % 2 != 0))
                    {
                        sum++;
                    }
                }
            }
            str += sum;
            return str;
        }

        public string PrintArray(int N)
        {
            string str = "";
            for(int i = 0; i < N; ++i)
            {
                str += array[i];
            }
            return str;
        }
    }
}
