using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList(1, "Lisa Shumova");
            list.AddItem("Ivan");
            list.AddItem("Andrew");
            list.AddItem("Anton");
            list.AddItem("Dima");

            string abc = "My name is Slim Shady";
            Console.WriteLine($"Count of words: {abc.CountOfWords()}");

            list.GetOwner().GetInfo();

         
        }
    }
}
