using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatingPerimeterandAreaofaCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float pi, radius;

        private void tboxradius_TextChanged(object sender, EventArgs e)
        {
        }

        private void tboxPi_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            radius = float.Parse(tboxradius.Text);
            pi = float.Parse(tboxPi.Text);
            MessageBox.Show("Perimeter of Circle: " + 2 * pi * radius);
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            radius = float.Parse(tboxradius.Text);
            pi = float.Parse(tboxPi.Text);
            MessageBox.Show("Area of Circle: " + pi * radius * radius);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
