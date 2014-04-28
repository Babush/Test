using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           /* Pole p1 = new Pole(1,Image.FromFile(@"C:\Users\Vladimir\Documents\GitHub\Test\TestProject\TestProject\Images\1.png"));
            button1.BackgroundImage = p1.Slika;
            Pole p2 = new Pole(2, Image.FromFile(@"C:\Users\Vladimir\Documents\GitHub\Test\TestProject\TestProject\Images\2.png"));
            button2.BackgroundImage = p2.Slika;
            Pole p3 = new Pole(3, Image.FromFile(@"C:\Users\Vladimir\Documents\GitHub\Test\TestProject\TestProject\Images\3.png"));
            button3.BackgroundImage = p3.Slika;
            Pole p4 = new Pole(4, Image.FromFile(@"C:\Users\Vladimir\Documents\GitHub\Test\TestProject\TestProject\Images\4.png"));
            button4.BackgroundImage = p4.Slika;
            Pole p5 = new Pole(5, Image.FromFile(@"C:\Users\Vladimir\Documents\GitHub\Test\TestProject\TestProject\Images\5.png"));
            button5.BackgroundImage = p5.Slika;
            Pole p6 = new Pole(6, Image.FromFile(@"C:\Users\Vladimir\Documents\GitHub\Test\TestProject\TestProject\Images\6.png"));
            button6.BackgroundImage = p6.Slika;
            Pole p7 = new Pole(7, Image.FromFile(@"C:\Users\Vladimir\Documents\GitHub\Test\TestProject\TestProject\Images\7.png"));
            button7.BackgroundImage = p7.Slika;
            Pole p8 = new Pole(8, Image.FromFile(@"C:\Users\Vladimir\Documents\GitHub\Test\TestProject\TestProject\Images\8.png"));
            button8.BackgroundImage = p8.Slika;
            Pole p9 = new Pole(9, Image.FromFile(@"C:\Users\Vladimir\Documents\GitHub\Test\TestProject\TestProject\Images\9.png"));
            button9.BackgroundImage = p9.Slika;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button1.Text;
                button1.Text = "";
            }
            proveri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }
            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button2.Text;
                button2.Text = "";
            }
            proveri();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button3.Text;
                button3.Text = "";
            }
            proveri();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button4.Text;
                button4.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button4.Text;
                button4.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button4.Text;
                button4.Text = "";
            }
            proveri();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button5.Text;
                button5.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button5.Text;
                button5.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button5.Text;
                button5.Text = "";
            }
            proveri();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button6.Text;
                button6.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button6.Text;
                button6.Text = "";
            }
            proveri();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button7.Text;
                button7.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }
            proveri();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button8.Text;
                button8.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button8.Text;
                button8.Text = "";
            }
            proveri();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = button9.Text;
                button9.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button9.Text;
                button9.Text = "";
            }
            proveri();
        }
        public void proveri()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
                button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8")
                MessageBox.Show("Bravo");
        }
    }
}
