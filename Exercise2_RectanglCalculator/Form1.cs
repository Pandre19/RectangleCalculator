using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Exercise2_RectanglCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            double length, width, area, perimeter, diagonal;

            if(!double.TryParse(textBox_Length.Text, out length) |
                !double.TryParse(textBox_Width.Text, out width))
            {
                MessageBox.Show("WARNING\n\nBoth Length and Width have to be doubles");
            } else
            {
                area = length * width;
                perimeter = (length *2) + (width *2);
                diagonal = Math.Sqrt( Math.Pow(length, 2) + Math.Pow(width, 2));
                MessageBox.Show("ANSWER\n\nArea = " + area.ToString("F") + "\nPerimeter = "
                    + perimeter.ToString("F") + "\nDiagonal = " + diagonal.ToString("F"));
            }

            textBox_Length.Clear();
            textBox_Width.Clear();
        }
    }
}
