using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public interface IGenericInterface<T>
    {
        void Add(T item);
        void Delete(int index);
        void Show();
    }
}
