using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Reflection;

namespace ConsoleApp1
{
    class Program

    {
        [DllImport("kernel32")]
        //kdskh;jdsfj
        static extern bool AllocConsole();
        [DllImport("user32.dll")]
        static extern bool SetWindowText(IntPtr hwnd, string text);
        static void Main(string[] args)
        {
            object obj;
            MethodInfo change1;
            MethodInfo change2;
            const string my = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/ConsoleApp1/bin/Debug/Lib4.dll";


            Assembly dll1 = Assembly.LoadFile(System.IO.Path.GetFullPath(my));
            Type type1 = dll1.GetType("Class1");
            obj = Activator.CreateInstance(type1);
            change1 = type1.GetMethod("change1");
            change2 = type1.GetMethod("change2");


            try
            {
                string name = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/InputFile.txt";
                string name1 = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/OutputFile.txt";

                StreamReader src = new StreamReader(name, Encoding.Default);
                FileStream fs = new FileStream(name1, FileMode.Create, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs, Encoding.Default);
                string line = src.ReadLine();
                string line2 = src.ReadLine();
                string line3 = src.ReadLine();
                string k = src.ReadLine();
                Object[] texti = new object[3];
                texti[0] = line;
                texti[1] = line2;
                texti[2] = line3;

                if (k == "1")
                {
                    sr.WriteLine(change1.Invoke(obj, texti).ToString());
                    Console.WriteLine(change1.Invoke(obj, texti));
                }
                else if (k == "2")
                {
                    sr.WriteLine(line.Replace(line2, line3));
                    Console.WriteLine(line.Replace(line2, line3));
                }
                else
                {
                    sr.WriteLine(string.Concat(line2, line3));
                    Console.WriteLine(string.Concat(line2, line3));
                }
                //sr.WriteLine(change2.Invoke(obj, texti));
                //Console.WriteLine(change2.Invoke(obj, texti));
                //sr.WriteLine(change1.Invoke(obj, new object[] { line, line2, line3 }));
                //Console.WriteLine(change1.Invoke(obj, new object[] { line, line2, line3 }));
                //sr.WriteLine(change1.Invoke(obj, new object[] { line, line2, line3 }));
                //Console.WriteLine(change1.Invoke(obj, new object[] { line, line2, line3 }));

                src.Close();
                sr.Close();
                Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return;
        }
    }
}
