using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pintar(textBox1.Text);
        }
        public void pintar(string color)
        {
            switch (color)
            {
                case "1":
                    richTextBox1.BackColor = Color.Red;
                    break;
                case "2":
                    richTextBox1.BackColor = Color.Yellow;
                    break;
                case "3":
                    richTextBox1.BackColor = Color.Green;
                    break;

                case "4":
                    richTextBox1.BackColor = Color.Black;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Words(textBox2.Text);
        }
        public void Words(string color)
        {
            switch (color)
            {
                case "1":
                    richTextBox1.ForeColor = Color.Red;
                    break;
                case "2":
                    richTextBox1.ForeColor = Color.Yellow;
                    break;
                case "3":
                    richTextBox1.ForeColor = Color.Green;
                    break;

                case "4":
                    richTextBox1.ForeColor = Color.Black;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fuente();
        }
        public void Fuente()
        {
            richTextBox1.AppendText("\n" + "201408580");
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle newFontStyle = FontStyle.Underline;
            richTextBox1.Font = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            agregar();
        }
        public void agregar() {
            richTextBox1.AppendText("\n"+ textBox3.Text);
        }
    }
}
