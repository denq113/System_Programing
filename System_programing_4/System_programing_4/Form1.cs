using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace System_programing_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Настройка компонентов печати
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
            pageSetupDialog1.Document = printDocument1;
            printDialog1.Document = printDocument1;
            printPreviewDialog1.Document = printDocument1;
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = richTextBox1.Text;
            Font printFont = new Font("Arial", 12);
            e.Graphics.DrawString(text, printFont, Brushes.Black, 50, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (printDialog1.ShowDialog() == DialogResult.OK)
                        {
                            printDocument1.Print();
                        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }
    }
}
