using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace opsist5
{
    public partial class Form1 : Form
    {
        Thread[] Thread = new Thread[2];
        public Form1()
        {
            InitializeComponent();
        }

        public static void Count(string n)
        {

            if (n =="1")
            {
                
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
