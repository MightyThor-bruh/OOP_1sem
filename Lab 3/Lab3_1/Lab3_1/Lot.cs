﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public partial class Lot
    {
        public static int numCreatObjects = 0; 
        public static int chetMin = 0;
        public static int chetMax = 0;
        private int Number;
        private int Coint;
        readonly private int reaonly; //поле только для чтения
        public List<int> listInt = new List<int> { };
        public List<int> listIntTwo = new List<int> { };
        public int number //реализация свойства get set 
        {
            get
            {
                return Number;
            }
            set
            {
                if (value > 0 && value < 32)
                {
                    if (coint != 2)
                    {
                        Number = value;
                    }
                    else
                    {
                        if (value < 29)
                        {
                            Number = value;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }
            }
        }
        public int coint
        {
            get
            {
                return Coint;
            }
            set
            {
                if (value > 0 && value < 13)
                {
                    Coint = value;
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }
            }
        }
        public int year { get; set; } //автоматическое свойство get set
        public Lot() //конструктор по умолчанию
        {
            numCreatObjects++;
        }
        public Lot(int a, int b, int c) //конструктор с параметрами
        {
            this.listInt.Add(a);
            this.listInt.Add(b);
            this.listInt.Add(c);
            numCreatObjects++;
        }
        public Lot(int a, int b)
        {
            this.listInt.Add(a);
            this.listInt.Add(b);
            numCreatObjects++;
        }

        // конструктор вызывается автоматически для инициализации класса перед созданием экземпляра или ссылкой 
        static Lot() //статический конструктор: выполняется всегда один раз
        {
            Lot privConstructor = new Lot(1, 1, 1, true);
            numCreatObjects++;
            Console.WriteLine("статический конструктор");
        }
        private Lot(int a, int b, int c, bool isOne) //закрытый конструктор
        {
            isOne = true;
            listIntTwo.Add(a);
            listIntTwo.Add(b);
            listIntTwo.Add(c);
            numCreatObjects++;
        }
        //Использование переменной без ref - операции со ЗНАЧЕНИЕМ 
        //С ref - с самой ПЕРЕМЕННОЙ 
        //out можно юзать, если не хватает return
        public static void AboutDate() //вывод инфы о классе; статический метод
        {
            Console.WriteLine("Объектов создано:");
            Console.WriteLine($"{numCreatObjects} объектов");
        }
        //переопределение методов
        public override string ToString() //служит для получения строкового представления данного объекта
        {
            return base.ToString() + " " + this.year + " " + this.coint + " " + this.number; //base = вызов конструктора, определенного в базовом классе

        }

        public override bool Equals(object obj) //Метод Equals позволяет сравнить два объекта на равенство
        {
            if (obj == null) return false;

            if (this.GetType() != obj.GetType()) return false; //Метод GetType позволяет получить тип данного объекта

            Lot a = (Lot)obj;

            if (this.year == a.year)
                if (this.coint == a.coint)
                    if (this.number == a.number)
                        return true;
            return false;
        }
        //позволяет возвратить некоторое числовое значение,
        //которое будет соответствовать данному объекту или его хэш-коду
        public override int GetHashCode() //override - переопределение метода
        {
            int hash = 47;
            hash += this.year + this.coint + this.number;
            hash %= 3;
            return hash;
        }
       
        public void Add(int elem)
        {
            this.listInt.Add(elem);
            Console.Write("добавили {0} к множеству -> ", elem);
            foreach (int ch in this.listInt)
                Console.Write(ch + " ");
            Console.WriteLine("\n");
            numCreatObjects++;
        }
        public void Remove(int elem)
        {
            this.listInt.Remove(elem);
            Console.Write("удалили {0} из множества -> ", elem);
            foreach (int ch in this.listInt)
                Console.Write(ch + " ");
            Console.WriteLine("\n");
            numCreatObjects++;
        }
        public int PrintQuantity()
        {
            int quantity = 0;
            foreach (int ch in this.listInt)
            {
                quantity++;
            }
            Console.WriteLine("\n" + quantity);
            numCreatObjects++;
            return quantity;
        }
        public int Max()
        {
            int count = 0;
            numCreatObjects++;
            Console.WriteLine("\nМожество: ");
            foreach (int ch in this.listInt)
            {
                count += ch;
                Console.Write(ch + " ");
            }
            Console.WriteLine("\nMAX " + count);

            if (chetMax < count)
            {
                chetMax = count; //присваиваем переменной максимальное значение
            }
            if (chetMin == 0)
                chetMin = count;
            else if (chetMin > count)
            {
                chetMin = count;
            }
            return chetMin;
        }
        public void Print()
        {
            int max = 0;
            numCreatObjects++;
            foreach (int ch in this.listInt)
            {
                max += ch;
            }
            if (max == chetMax) //вывод макс множества
            {
                Console.WriteLine("\nМножество с максимальной суммой элементов: ");
                foreach (int ch in this.listInt)
                    Console.Write(ch + " ");
                Console.WriteLine("\n");
            }
            if (max == chetMin) //вывод мин множества
            {
                Console.WriteLine("\nМножество с минимальной суммой элементов");
                foreach (int ch in this.listInt)
                    Console.Write(ch + " ");
                Console.WriteLine("\n");
            }

        }
        public bool NegativeElem()
        {
            numCreatObjects++;
            bool booleanChangeable = false;
            foreach (int ch in this.listInt)
                if (ch < 0)
                {
                    booleanChangeable = true;
                }
            if (booleanChangeable == true)
            {
                Console.Write("\n");
                foreach (int ch in this.listInt)
                    Console.Write(ch + " ");
            }
            return booleanChangeable;
        }

    }
}
