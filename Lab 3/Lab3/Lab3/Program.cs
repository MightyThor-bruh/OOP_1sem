using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Show(string msg, SortedSet<int> set)
        {
            Console.Write(msg);
            foreach (char ch in set)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            SortedSet<int> setA = new SortedSet<int>();
            SortedSet<int> setB = new SortedSet<int>();

            setA.Add('1');
            setA.Add('2');
            setA.Add('3');
            setB.Add('4');
            setB.Add('5');
            setB.Add('6');
            setB.Add('7');

            Show("setA: ", setA);
            Show("setB: ", setB);
            Console.WriteLine();
            Console.WriteLine("The number of elements in set A are: "+ setA.Count);
            Console.WriteLine("The number of elements in set B are: " + setB.Count);

            setA.Remove('3');
            Show("setA after removing the element: ", setA);
        }
    }
}

