using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib3;
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int t = 0,k=0;
        private void Button5_Click(object sender, EventArgs e)
        {
            t = 1;
            /* Process u = new Process();
            u.StartInfo.FileName = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/ConsoleApp1/bin/Debug/ConsoleApp1.exe";
            string name = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/InputFile.txt";
            FileStream fs = new FileStream(name, FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine(textBox4.Text);
            sr.WriteLine(textBox5.Text);
            sr.WriteLine(textBox6.Text);
            sr.Close();

            u.Start();
            u.WaitForExit();
            string name1 = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/OutputFile.txt";
            FileStream fs1 = new FileStream(name1, FileMode.Open, FileAccess.Read);
            StreamReader src = new StreamReader(fs1);
            textBox4.Text = "";
           //textBox4.Text = src.ReadToEnd();
            textBox5.Text = "";
            textBox6.Text = "";
            src.Close();*/
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            t = 2;
            /*Process w = new Process();
            w.StartInfo.FileName = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/ConsoleApp2/bin/Debug/ConsoleApp2.exe";
            string name = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/InputFile.txt";
            FileStream fs = new FileStream(name, FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine(textBox4.Text);
            sr.WriteLine(textBox5.Text);
            sr.WriteLine(textBox6.Text);
            sr.Close();

            w.Start();
            w.WaitForExit();
           
            string name1 = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/OutputFile.txt";
            FileStream fs1 = new FileStream(name1, FileMode.Open, FileAccess.Read);
            StreamReader src = new StreamReader(fs1);
            textBox4.Text = "";
            //textBox4.Text = src.ReadToEnd();
            textBox5.Text = "";
            textBox6.Text = "";
            src.Close();*/
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            k = 1;
            if (t == 1)
            {
                Process u = new Process();
                u.StartInfo.FileName = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/ConsoleApp1/bin/Debug/ConsoleApp1.exe";
                string name = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/InputFile.txt";
                FileStream fs = new FileStream(name, FileMode.Create, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(textBox4.Text);
                sr.WriteLine(textBox5.Text);
                sr.WriteLine(textBox6.Text);
                sr.WriteLine(k.ToString());
                sr.Close();

                u.Start();
                u.WaitForExit();
                string name1 = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/OutputFile.txt";
                FileStream fs1 = new FileStream(name1, FileMode.Open, FileAccess.Read);
                StreamReader src = new StreamReader(fs1);
                textBox4.Text = "";
                textBox4.Text = src.ReadToEnd();
                textBox5.Text = "";
                textBox6.Text = "";
                src.Close();
            }
            else
            {
                Process w = new Process();
                w.StartInfo.FileName = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/ConsoleApp2/bin/Debug/ConsoleApp2.exe";
                string name = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/InputFile.txt";
                FileStream fs = new FileStream(name, FileMode.Create, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(textBox4.Text);
                sr.WriteLine(textBox5.Text);
                sr.WriteLine(textBox6.Text);
                sr.WriteLine(k.ToString());
                sr.Close();

                w.Start();
                w.WaitForExit();

                string name1 = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/OutputFile.txt";
                FileStream fs1 = new FileStream(name1, FileMode.Open, FileAccess.Read);
                StreamReader src = new StreamReader(fs1);
                textBox4.Text = "";
                textBox4.Text = src.ReadToEnd();
                textBox5.Text = "";
                textBox6.Text = "";
                src.Close();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            k = 3;
            if (t == 1)
            {
                Process u = new Process();
                u.StartInfo.FileName = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/ConsoleApp1/bin/Debug/ConsoleApp1.exe";
                string name = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/InputFile.txt";
                FileStream fs = new FileStream(name, FileMode.Create, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(textBox4.Text);
                sr.WriteLine(textBox5.Text);
                sr.WriteLine(textBox6.Text);
                sr.WriteLine(k.ToString());
                sr.Close();

                u.Start();
                u.WaitForExit();
                string name1 = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/OutputFile.txt";
                FileStream fs1 = new FileStream(name1, FileMode.Open, FileAccess.Read);
                StreamReader src = new StreamReader(fs1);
                textBox4.Text = "";
                textBox4.Text = src.ReadToEnd();
                textBox5.Text = "";
                textBox6.Text = "";
                src.Close();
            }
            else
            {
                Process w = new Process();
                w.StartInfo.FileName = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/ConsoleApp2/bin/Debug/ConsoleApp2.exe";
                string name = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/InputFile.txt";
                FileStream fs = new FileStream(name, FileMode.Create, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(textBox4.Text);
                sr.WriteLine(textBox5.Text);
                sr.WriteLine(textBox6.Text);
                sr.WriteLine(k.ToString());
                sr.Close();

                w.Start();
                w.WaitForExit();

                string name1 = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/OutputFile.txt";
                FileStream fs1 = new FileStream(name1, FileMode.Open, FileAccess.Read);
                StreamReader src = new StreamReader(fs1);
                textBox4.Text = "";
                textBox4.Text = src.ReadToEnd();
                textBox5.Text = "";
                textBox6.Text = "";
                src.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            k = 2;
            if (t == 1)
            {
                Process u = new Process();
                u.StartInfo.FileName = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/ConsoleApp1/bin/Debug/ConsoleApp1.exe";
                string name = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/InputFile.txt";
                FileStream fs = new FileStream(name, FileMode.Create, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(textBox4.Text);
                sr.WriteLine(textBox5.Text);
                sr.WriteLine(textBox6.Text);
                sr.WriteLine(k.ToString());
                sr.Close();

                u.Start();
                u.WaitForExit();
                string name1 = "C:/Users/ibook/Desktop/opsis/ConsoleApp1/OutputFile.txt";
                FileStream fs1 = new FileStream(name1, FileMode.Open, FileAccess.Read);
                StreamReader src = new StreamReader(fs1);
                textBox4.Text = "";
                textBox4.Text = src.ReadToEnd();
                textBox5.Text = "";
                textBox6.Text = "";
                src.Close();
            }
            else
            {
                Process w = new Process();
                w.StartInfo.FileName = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/ConsoleApp2/bin/Debug/ConsoleApp2.exe";
                string name = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/InputFile.txt";
                FileStream fs = new FileStream(name, FileMode.Create, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(textBox4.Text);
                sr.WriteLine(textBox5.Text);
                sr.WriteLine(textBox6.Text);
                sr.WriteLine(k.ToString());
                sr.Close();

                w.Start();
                w.WaitForExit();

                string name1 = "C:/Users/ibook/Desktop/opsis/ConsoleApp2/OutputFile.txt";
                FileStream fs1 = new FileStream(name1, FileMode.Open, FileAccess.Read);
                StreamReader src = new StreamReader(fs1);
                textBox4.Text = "";
                textBox4.Text = src.ReadToEnd();
                textBox5.Text = "";
                textBox6.Text = "";
                src.Close();
            }
        }
    }
}
