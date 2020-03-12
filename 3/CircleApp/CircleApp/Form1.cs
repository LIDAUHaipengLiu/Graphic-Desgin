using Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Circle C = new Circle();
            C.set_radius(Convert.ToInt32(textBox1.Text));
            label5.Text = Convert.ToString(C.get_area());
            label7.Text = Convert.ToString(C.get_perimeter());
            textBox1.Text = "";
        }
    }
}
