using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Определите переменные всех возможных примитивных типов
            //int a = -5;
            //uint aa = 5;
            //float b = 2.17f;
            //double c = 2.17;
            //decimal d = -45;
            //char e = '&';
            //bool f = false;
            //string g = "Hello world";
            //byte h = 25;
            //sbyte hh = -25;
            //short i = -8;
            //ushort ii = 8;
            //long j = -92;
            //ulong jj = 92;
            //object k = 7u;

            ////Выполните 5 операций явного и 5 неявного приведения.
            //j = aa;
            //b = a;
            //c = h;
            //ii = h;
            //d = a;
            //a = (int)aa;
            //h = (byte)hh;
            //i = (short)ii;
            //j = (long)jj;
            //b = (float)c;
            //int let = Convert.ToInt32(g);

            ////Выполните упаковку и распаковку значимых типов
            //int x = 8;
            //Object s = x;
            //int n = (int)s;

            ////Продемонстрируйте работу с неявно типизированной переменной
            //var t = "hello world!";
            //Console.WriteLine(t.GetType());

            ////Продемонстрируйте пример работы с Nullable переменной
            //Nullable<uint> nol = null;
            //Console.Write(nol);

            ////Объявите строковые литералы. Сравните их
            //string line1 = "Hello world";
            //string line2 = "Hello world";
            //Console.WriteLine(String.Equals(line1, line2));

            ////Создайте три строки на основе String. Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, 
            ////вставки подстроки в заданную позицию, удаление заданной подстроки. Продемонстрируйте интерполирование строк

            ////Создайте пустую и null строку. Продемонстрируйте использование метода string.IsNullOrEmpty
            //string emp = "";
            //string emp1 = null;
            //string line = "valar morgulis";
            //Console.WriteLine(string.IsNullOrEmpty(emp));
            //Console.WriteLine(string.IsNullOrEmpty(line));
            //Console.WriteLine(string.IsNullOrEmpty(emp1));

            ////Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки
            //StringBuilder build = new StringBuilder("Hello World");
            //build.Remove(2, 4);
            //Console.WriteLine(build);
            //build.Insert(5, "!!!");
            //Console.WriteLine(build);

            ////Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица)
            //int[,] array = { {1, 2, 3 },{4, 5, 6 }, { 7, 8, 9} };

            //int height = array.GetLength(0);
            //int width = array.GetLength(1);

            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        Console.Write(array[y, x]);
            //    }
            //    Console.WriteLine();
            //}

            ////Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива
            //string[] arr = { "September", "October", "November" };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine(arr.Length);

            ////Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно.
            //int[][] myArr = new int[3][];
            //myArr[0] = new int[2];
            //myArr[1] = new int[3];
            //myArr[2] = new int[4];

            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    for (int j = 0; j < myArr[i].Length; j++)
            //    {
            //        Console.Write($"myArr[{i}][{j}] = ");
            //        myArr[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    Console.WriteLine(string.Join(" ", myArr[i]));
            //}
            //Console.ReadLine();

            ////Создайте неявно типизированные переменные для хранения массива и строки
            //var rr = new[] { 1, 2, 3, 4, 5 };

            ////Задайте кортеж из 5 элементов с типами int, string, char, string, ulong
            //(int, string, char, string, ulong) tuple = (8, "line", '&', "line again", 134);

            ////Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4 элементы)
            //Console.WriteLine($"Кортеж: {tuple.Item1}, {tuple.Item2}, {tuple.Item3}, {tuple.Item4}, {tuple.Item5}");
            //Console.WriteLine("элемент 1: {0}", tuple.Item1);
            //Console.WriteLine("элемент 3: {0}", tuple.Item3);
            //Console.WriteLine("элемент 4: {0}", tuple.Item4);

            ////Выполните распаковку кортежа в переменные
            //int elem1 = 4;
            //string elem2 = "text";
            //char elem3 = '!';
            //string elem4 = "phrase";
            //ulong elem5 = 10;
            //(elem1, elem2, elem3, elem4, elem5) = tuple;

            ////Сравните два кортежа
            //(int, string, char, string, ulong) tuple1 = (3, "privet", '%', "yeba", 111);
            //if (tuple == tuple1) Console.WriteLine("Кортежи равны!"); else Console.WriteLine("Кортежи не равны!");

            ////Создайте локальную функцию в main и вызовите ее
            //(int, int, int, char) localfunc(int[] array, string line)
            //{
            //    int maxx = array.Max();
            //    int minn = array.Min();
            //    int summ = array.Sum();
            //    char simm = line.First();
            //    return (maxx, minn, summ, simm);
            //}
            //int[] array1 = { 1, 2, 5, 3, 4 };
            //string line1 = "Hello world";
            //Console.WriteLine(localfunc(array1, line1));

            ////Работа с checked/unchecked
            //int func_checked() 
            //{
            //    checked
            //    {
            //        int t = int.MaxValue;
            //        try
            //        {
            //            return t + 1;
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("переполнение");
            //            return t;
            //        }
            //    }
            //}
            //int func_unchecked()
            //{
            //    unchecked
            //    {
            //        int t = int.MaxValue;
            //        try
            //        {
            //            return t + 1;
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("переполнение");
            //            return t;
            //        }
            //    }
            //}
            //Console.WriteLine(func_checked());
            //Console.WriteLine(func_unchecked());
            //Console.ReadKey();
        }
    }
}
