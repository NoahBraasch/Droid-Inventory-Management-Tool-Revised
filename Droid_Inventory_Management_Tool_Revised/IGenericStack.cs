using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Inventory_Management_Tool_Revised
{
    internal interface IGenericStack<T>
    {
        void Push(T Data);
        T Pop();
        bool IsEmpty { get; }
        int Size { get; }
    }
}
