﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Lab12
{
    public class LDIFileManager
    {
        public static void taskA(string diskLetter)
        {
            if (!Directory.Exists(diskLetter))
            {

                Console.WriteLine("Проверьте ввод");
                return;
            }
            var aboutDisk = new DirectoryInfo(diskLetter);
            var dir = new DirectoryInfo(@"C:\Users\mdxbu\Labs");
            var subdir = dir.CreateSubdirectory("LDIInspect");

            using (var file = new StreamWriter(@"C:\Users\mdxbu\Labs\LDIInspect\LDIDirInfo.txt", false))
            {
                file.WriteLine("------------Директории------------");
                foreach (var da in aboutDisk.GetDirectories())
                {
                    file.WriteLine(da.Name.ToString());
                }
                file.WriteLine("------------Файлы------------");
                foreach (var fa in aboutDisk.GetFiles())
                {
                    file.WriteLine(fa.Name.ToString());
                }
            }

                var dirwithLDI = new FileInfo(subdir.FullName + @"\" + "LDIDirInfo.txt");
                dirwithLDI.CopyTo(subdir.FullName + @"\" + "LDIDirInfo_REPLICATE" + Convert.ToString(new Random().Next(100)) + ".txt");
                dirwithLDI.Delete();


        }

    public static void taskBC(string dirPath, string extension)
        {
              var xxfiles = new DirectoryInfo("C://Users/mdxbu/Labs/LDIFiles");
            if (!xxfiles.Exists)
            {
                xxfiles.Create();
            }
              var dir = new DirectoryInfo(dirPath);
              FileInfo[] f = dir.GetFiles(extension, SearchOption.AllDirectories);
              foreach (var x in f )
              {
                  x.CopyTo(xxfiles + @"\" + x.Name + x.Extension);
              }
            CreateArch("C://Users/mdxbu/Labs/LDIFiles");
            FileInfo[] xxfiles2 = xxfiles.GetFiles();
            foreach(var el in xxfiles2) {
                el.MoveTo("C://Users/mdxbu/Labs/LDIInspect"+ @"\" + el.Name, true);
            }
            xxfiles.Delete();

        }

        public static void CreateArch(string dir)
        {
                const string zipName = @"C://Users/mdxbu/Labs/LDIFiles.zip";
                ZipFile.CreateFromDirectory(dir, zipName);
                var direct = new DirectoryInfo(dir);
            try
            {
                foreach (var innerFile in direct.GetFiles())
                    ZipFile.ExtractToDirectory(zipName, dir);
            }
            catch
            {
                
            }
            using (ZipArchive archive = ZipFile.OpenRead(zipName))
            {
                archive.ExtractToDirectory(@"C:\Users\mdxbu\Labs\forZIP", true);

            }
        }



        }
}
