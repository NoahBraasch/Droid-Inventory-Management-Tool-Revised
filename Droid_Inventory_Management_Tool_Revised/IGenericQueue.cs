using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Inventory_Management_Tool_Revised
{
    internal interface IGenericQueue<T>
    {
        void Enqueue(T Data);
        T Dequeue();
        void Display();
        bool IsEmpty { get; }
        int Size { get; }
    }
}
