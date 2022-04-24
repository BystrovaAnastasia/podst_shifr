using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            String alfa = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            String l = richTextBox1.Text;
            String m = "";
            int d = 0;
            int k = 0;
            for (int i = 0; i < richTextBox1.Text.Length; i++)
            {
                for (int j = 0; j < alfa.Length; j++)
                {
                    if (alfa[j] == l[i])
                    {
                        d = j;
                        break;
                    }
                }
                if (textBox1.Text == "") {
                    k = d;
                }
                else
                {
                    k = d + Convert.ToInt32(textBox1.Text);
                }
                m += alfa[k];
            }
            for (int i = 0; i < m.Length; i++)
            {
                richTextBox2.Text += m[i];
            }
        }

        private void одноалфавитнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            //newForm2.Show();
            this.Hide();
            if (newForm2.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void многоалфавитнаяОдноконтурнаяМонофоническаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            //newForm2.Show();
            this.Hide();
            if (newForm3.ShowDialog() != DialogResult.OK)
                Close();
        }
    }
}
