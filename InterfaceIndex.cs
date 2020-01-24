using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    public interface InterfaceIndex
    {
        int this[int index]
        {
            get;
            set;
        }
        string ChetSum(int N);
        string ChetSum();
    }
}
