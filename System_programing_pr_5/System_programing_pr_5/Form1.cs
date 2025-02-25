using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace System_programing_pr_5
{
    public partial class Form1 : Form
    {
        private const int Shift = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                Clipboard.SetText(txtInput.Text);
                MessageBox.Show("Данные скопированы в буфер обмена.");
            }
            else
            {
                MessageBox.Show("Поле ввода пустое!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtOutput.Text = Clipboard.GetText();
            }
            else
            {
                MessageBox.Show("Буфер обмена пуст!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            MessageBox.Show("Буфер обмена очищен.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string text = Clipboard.GetText();
                string encryptedText = CaesarCipher(text, Shift);
                Clipboard.SetText(encryptedText);
                MessageBox.Show("Данные зашифрованы и помещены в буфер.");
            }
            else
            {
                MessageBox.Show("Буфер обмена пуст!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string encryptedText = Clipboard.GetText();
                string decryptedText = CaesarCipher(encryptedText, -Shift);
                txtOutput.Text = decryptedText;
            }
            else
            {
                MessageBox.Show("Буфер обмена пуст!");
            }
        }
        private string CaesarCipher(string text, int shift)
        {
            StringBuilder result = new StringBuilder();

            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    char baseChar = char.IsUpper(ch) ? 'A' : 'a';
                    char encryptedChar = (char)(baseChar + (ch - baseChar + shift + 26) % 26);
                    result.Append(encryptedChar);
                }
                else
                {
                    result.Append(ch); // Не шифруем знаки препинания и цифры
                }
            }

            return result.ToString();
        }
    }
}
