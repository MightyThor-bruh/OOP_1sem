﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_
{
    public class SYIFileInfo
    {
        public void FileData(string path)
        {
            Console.WriteLine("FileInfo");
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("\tAll way : {0}", fileInf.DirectoryName);
                Console.WriteLine("\tName: {0}", fileInf.Name);
                Console.WriteLine("\tCapacity: {0} KB\n\tExtension: {1}\n\tCreationTime: {2}", fileInf.Length / 1024, fileInf.Extension, fileInf.CreationTime);
            }
            else
            {
                Console.WriteLine("This file doesn't exists");
            }
        }
    }
}
