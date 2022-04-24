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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[,] M_table = new String[,]{ 
                { "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ь", "Ы", "Ъ", "Э", "Ю", "Я" },
                { "Ф", "Н", "(", "Щ", "И", "Г", "Е", "R", "A", "Д", "Ы", "~", "@", "S", "Л", "Я", "Ж", "^", "C", "Ш", "М", "Б", "Q", "П", "Т", "Х", "Ю", "Ъ", "Р", "}", "\\", "_"},
                { "*", "Н", "У", "Щ", "D", "+", "Е", "R", "=", "Д", "Ц", "Й", "Ч", "[", "В", "Ь", ")", "O", "&", "{", "М", "Б", "Q", "П", "Т", "Х", "Ю", "Ъ", "Р", "}", "\\", "_"},
                { "Л", "Н", "(", "Щ", "И", "]", "Е", "R", "%", "Д", "Ы", "~", "@", "G", "/", "Я", "Э", "З", "\"", "Ш", "М", "Б", "Q", "П", "Т", "Х", "Ю", "Ъ", "Р", "}", "\\", "_"},
                { "Ф", "Н", "У", "Щ", "D", "К", "Е", "R", "A", "Д", "Ц", "Й", "Ч", "S", "+", "Ь", "Ж", "^", "C", "{", "М", "Б", "Q", "П", "Т", "Х", "Ю", "Ъ", "Р", "}", "\\", "_"}
            };

            richTextBox2.Text = "";
            String l = richTextBox1.Text;

            for (int i = 0; i < l.Length; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if (M_table[0, j].Equals(l[i].ToString()))
                    {
                        richTextBox2.Text += M_table[1, j];
                        for (int k = 1; k < 4; k++)
                        {
                            String temp = M_table[k, j];
                            M_table[k, j] = M_table[k + 1, j];
                            M_table[k + 1, j] = temp;
                        }
                    }
                }
            }

        }

        private void одноалфавитнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            //newForm1.Show();
            this.Hide();
            if (newForm1.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void многоалфавитнаяОдноконтурнаяОбыкновеннаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            //newForm2.Show();
            this.Hide();
            if (newForm2.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ь", "Ы", "Ъ", "Э", "Ю", "Я");
            dataGridView1.Rows.Add("Ф", "Н", "(", "Щ", "И", "Г", "Е", "R", "A", "Д", "Ы", "~", "@", "S", "Л", "Я", "Ж", "^", "C", "Ш", "М", "Б", "Q", "П", "Т", "Х", "Ю", "Ъ", "Р", "}", "\\", "_");
            dataGridView1.Rows.Add("*", "Н", "У", "Щ", "D", "+", "Е", "R", "=", "Д", "Ц", "Й", "Ч", "[", "В", "Ь", ")", "O", "&", "{", "М", "Б", "Q", "П", "Т", "Х", "Ю", "Ъ", "Р", "}", "\\", "_");
            dataGridView1.Rows.Add("Л", "Н", "(", "Щ", "И", "]", "Е", "R", "%", "Д", "Ы", "~", "@", "G", "/", "Я", "Э", "З", "\"", "Ш", "М", "Б", "Q", "П", "Т", "Х", "Ю", "Ъ", "Р", "}", "\\", "_");
            dataGridView1.Rows.Add("Ф", "Н", "У", "Щ", "D", "К", "Е", "R", "A", "Д", "Ц", "Й", "Ч", "S", "+", "Ь", "Ж", "^", "C", "{", "М", "Б", "Q", "П", "Т", "Х", "Ю", "Ъ", "Р", "}", "\\", "_");
        }
    }
}
