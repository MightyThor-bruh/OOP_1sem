﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Threading.Tasks;

namespace Lab12
{
    public class Reflector
    {
        public const string FilePath = @"D:\Стандартные папки\Рабочий стол\У(ч)ёба\ООП\Lab 12\Lab12\Lab12\out.txt";
        public static void ToFile(string classname)
        {
            Type type = Type.GetType(classname, false, true);
            if (type == null)
            {
                Console.WriteLine("Тип не найден");
                return;
            }
            using (StreamWriter sw = new StreamWriter(FilePath, false, Encoding.Default))
            {
                sw.WriteLine("Namespace.ClassName: " + classname);
                sw.WriteLine("Конструкторы: ");
                foreach (var constr in type.GetConstructors())
                    sw.WriteLine("\t" + constr.Name);
                sw.WriteLine("Поля: ");
                foreach (var filds in type.GetFields())
                    sw.WriteLine("\t" + filds.Name);
                sw.WriteLine("Свойства: ");
                foreach (var prop in type.GetProperties())
                    sw.WriteLine("\t" + prop.Name);
                sw.WriteLine("Методы: ");
                foreach (var methods in type.GetMethods())
                    sw.WriteLine("\t" + methods.Name);

                sw.Write("parameters\t");
                sw.WriteLine("18 Lisa");
            }
        }
        public static MethodInfo[] GetMethods(string classname)
        {
            Type type = Type.GetType(classname, true, false);
            if (type == null)
            {
                Console.WriteLine("Тип не найден");
                return null;
            }
            return type.GetMethods();
        }

        public static List<MemberInfo[]> GetFieldsProps(string classname)
        {
            Type type = Type.GetType(classname, true, false);
            if (type == null)
            {
                Console.WriteLine("Тип не найден");
                return null;
            }
            var props = type.GetProperties();
            var methods = type.GetFields();
            List<MemberInfo[]> mems = new List<MemberInfo[]> { props, methods };
            return mems;
        }

        public static Type[] GetInterface(string classname)
        {
            Type type = Type.GetType(classname, true, false);
            if (type == null)
            {
                Console.WriteLine("Тип не найден");
                return null;
            }
            return type.GetInterfaces();
        }

        public static void PrintMet(string classname, Type par)
        {
            Type type = Type.GetType(classname, true, false);
            if (type == null)
            {
                Console.WriteLine("Тип не найден");
                return;
            }
            var methods = type.GetMethods();
            var result = methods.Where(a => a.GetParameters().Where(t => t.ParameterType == par).Count() != 0);
            Console.WriteLine($"Методы с параметром {par}: ");
            foreach (var el in result)
                Console.WriteLine(el.Name);
        }

        public static void ExecuteMethod(string className, string methodName)
        {
            Type type = Type.GetType(className, false, true);
            if (type == null)
            {
                Console.WriteLine("Тип не найден");
                return;
            }


            string fileinf = "";
            string parameters = "parameters";
            using (StreamReader sr = new StreamReader(FilePath, Encoding.Default))
            {
                fileinf = sr.ReadToEnd();
            }
            if (fileinf.IndexOf(methodName) == -1)
            {
                Console.WriteLine("Метод отсутствует в файле");
                return;
            }
            int param = fileinf.IndexOf(parameters);
            List<string> paramlist = new List<string>();
            if (param == -1)
                Console.WriteLine("Параметров для вызова функции нет");
            else
            {
                string currentParam = "";
                for (int i = param + parameters.Length + 1; i < fileinf.Length; i++)
                {
                    if (fileinf[i] == ' ' || fileinf[i] == '\n')
                    {
                        paramlist.Add(currentParam);
                        currentParam = "";
                    }
                    else
                        currentParam += fileinf[i];
                }
            }
            var method = type.GetMethod(methodName);
            int intParam;
            int.TryParse(paramlist.First(), out intParam);
            string strParam = paramlist.Last();
            object obj = Activator.CreateInstance(type);
            if (paramlist.Count() != 0)
                method.Invoke(obj, new object[] { strParam, intParam });
            else
                method.Invoke(obj, new object[] { });
        }
    }
}
