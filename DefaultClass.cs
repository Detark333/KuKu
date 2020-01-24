using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    public class DefaultClass : InterfaceIndex
    {
        private int[] array;
        private int size = 0;
        public event myDelegate event1;
        public event myDelegate2 event2;
        public DefaultClass(int N)
        {
            Random rand = new Random();
            size = N;
            array = new int[size];
            for (int i = 0; i < size; ++i)
            {
                array[i] = rand.Next(1, 10);
            }
        }

        public int this[int index] { get => array[index]; set => array[index] = value; }

        public string Name { get => "DefaultClass " + size ; }


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
                    if ((array[i] > size) && (array[i] % 2 != 0))
                    {
                        sum++;
                    }
                }
            str += sum;
            return str;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
