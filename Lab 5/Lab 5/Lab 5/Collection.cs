using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    partial class CollectionType<T> : IGeneric<T> where T : class
    {
        private int size;
        public List<T> list;

        public CollectionType()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
            size++;
        }

        public void Delete(int index)
        {
            try
            {
                list.RemoveAt(index);
                size--;
            }
            catch
            {
                Console.WriteLine($"Выход за пределы, используйте числа в диапазоне (0-{size})");
            }
        }

        public void Show()
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public int GetSize()
        {
            return size;
        }
    }
}
