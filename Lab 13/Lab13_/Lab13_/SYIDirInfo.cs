﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_
{
    public class SYIDirInfo
    {
        public void DirInfo(string dirName)
        {
            Console.WriteLine("DirInfo");
            if (Directory.Exists(dirName))
            {
                string[] files = Directory.GetFiles(dirName);
                int countFiles = 0;
                foreach (string s in files)
                {
                    countFiles++;
                }
                Console.WriteLine("\tCountOfFiles: {0}", countFiles);

                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                Console.WriteLine("\tCreationTime: {0}", dirInfo.CreationTime);

                string[] dirs = Directory.GetDirectories(dirName);
                int countSubDir = 0;
                foreach (string s in dirs)
                {
                    countSubDir++;
                }
                Console.WriteLine("\tCountOfSubDirectories: {0}", countSubDir);

                Console.WriteLine("\tParents: {0}", dirInfo.Parent);
            }
            else
            {
                Console.WriteLine("This directory doesn't exists");
            }
        }
    }
}
