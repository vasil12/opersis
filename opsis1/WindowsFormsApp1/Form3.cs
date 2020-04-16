using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using _2lib;
using lib3;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
//using lsum;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        [DllImport("Gdi32.dll")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect,
                                                           int nTopRect,
                                                           int nRightRect,
                                                           int nBottomRect,
                                                           int nWidthEllipse,
                                                           int nHeightEllipse);
        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);
        [DllImport("Gdi32.dll")]
        public static extern int CombineRgn(IntPtr hrgnDest, IntPtr hrgnSrc1, IntPtr hrgnSrc2, int fnCombineMode);
        public object obj;
        public Form3()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.LoadFile(System.IO.Path.GetFullPath("2lib.dll"));

            Type types = a.GetType("_2lib.Class2");
            obj = Activator.CreateInstance(types);

            Object[] texti = new object[3];
            texti[0] = textBox5.Text;
            texti[1] = textBox6.Text;
            texti[2] = textBox4.Text;

            MethodInfo mi = types.GetMethod("rep");
            textBox4.Text = mi.Invoke(obj, texti).ToString();
            //string st1 = textBox5.Text;
            //string st2 = textBox6.Text;
            //string st3 = textBox4.Text;
            //textBox4.Text = st3 = Class2.rep(st1, st2, st3);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.LoadFile(System.IO.Path.GetFullPath("lib3.dll"));

            Type types = a.GetType("lib3.Class3");
            obj = Activator.CreateInstance(types);

            Object[] texti = new object[1];
            texti[0] = textBox4.Text;

             MethodInfo mi = types.GetMethod("upp");
            textBox4.Text = mi.Invoke(obj, texti).ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.LoadFile(System.IO.Path.GetFullPath("lib3.dll"));

            Type types = a.GetType("lib3.Class3");
            obj = Activator.CreateInstance(types);

            Object[] texti = new object[1];
            texti[0] = textBox4.Text;

            MethodInfo mi = types.GetMethod("low");
            textBox4.Text = mi.Invoke(obj, texti).ToString();
            //string st = textBox4.Text;
            //st = Class3.low(st);
            //textBox4.Text = st;

        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.LoadFile(System.IO.Path.GetFullPath("libcon1.dll"));

            Type types = a.GetType("libcon.Class1");
            obj = Activator.CreateInstance(types);

            Object[] texti = new object[2];
            texti[0] = textBox5.Text;
            texti[1] = textBox6.Text;

            MethodInfo mi = types.GetMethod("con");
           // textBox4.Text = mi.Invoke(o, new object[] { texti[0] }).ToString();
            textBox4.Text = mi.Invoke(obj,texti).ToString();
            //string st1 = textBox5.Text;
            //string st2 = textBox6.Text;
            //string st3 = Class1.concatil(st1,st2);
            //textBox4.Text = st3;
        }
        private void Form3_Deactivate(object sender, EventArgs e)
        {
           this.Opacity = 1;
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            this.Opacity = .60;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            IntPtr hRgn = CreateRoundRectRgn(0, 0, Width, Height, 60, 60);
            IntPtr qwe = CreateRoundRectRgn(50 * 2, 120, 100 * 2, 170, 0, 0);
            CombineRgn(hRgn, hRgn, qwe, 3);
            qwe = CreateRoundRectRgn(60 * 2, 125, 90 * 2, 135, 0, 0); // горизонтальная 1
            CombineRgn(hRgn, hRgn, qwe, 2);

            qwe = CreateRoundRectRgn(60 * 2, 125, 130 , 160, 0, 0); // 1
            CombineRgn(hRgn, hRgn, qwe, 2);

            qwe = CreateRoundRectRgn(120, 150 , 180, 160, 0, 0); // 2
            CombineRgn(hRgn, hRgn, qwe, 2);

            qwe = CreateRoundRectRgn(120, 140, 180, 145, 0, 0); // 3
            CombineRgn(hRgn, hRgn, qwe, 2);

            qwe = CreateRoundRectRgn(175, 145, 180, 160, 0, 0); // 4
            CombineRgn(hRgn, hRgn, qwe, 2);

            SetWindowRgn(this.Handle, hRgn, true);
        }
    }
}
