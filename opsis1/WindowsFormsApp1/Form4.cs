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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string st = textBox7.Text;
            Class3 myObject = new Class3();
            st = myObject.upp(st);
            textBox7.Text = st;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string st = textBox7.Text;
            st = Class3.low(st);
            textBox7.Text = st;
        }
    }
}
