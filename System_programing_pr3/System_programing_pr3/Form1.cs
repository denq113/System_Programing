using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_programing_pr3
{
    public partial class Form1 : Form
    {
        const string fileName = "Text.dat";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                 using (var stream = File.Open(fileName, FileMode.Create))
                 {

                      using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                      {
                           writer.Write(richTextBox1.Text);
                      }
                 }
            }
            else if (radioButton2.Checked == true)
            {
                using (var stream = File.Open(fileName, FileMode.Create))
                {

                    using (var writer = new BinaryWriter(stream, Encoding.Unicode, false))
                    {
                        writer.Write(richTextBox1.Text);
                    }
                }
            }
            else
            {
                using (var stream = File.Open(fileName, FileMode.Create))
                {

                    using (var writer = new BinaryWriter(stream, Encoding.ASCII, false))
                    {
                        writer.Write(richTextBox1.Text);
                    }
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (File.Exists(fileName))
                {
                    using (var stream = File.Open(fileName, FileMode.Open))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                        {
                            string we = reader.ReadString();
                            richTextBox1.Text = we;
                        }
                    }
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (File.Exists(fileName))
                {
                    using (var stream = File.Open(fileName, FileMode.Open))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.Unicode, false))
                        {
                            string we = reader.ReadString();
                            richTextBox1.Text = we;
                        }
                    }
                }
            }
            else
            {
                if (File.Exists(fileName))
                {
                    using (var stream = File.Open(fileName, FileMode.Open))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.ASCII, false))
                        {
                            string we = reader.ReadString();
                            richTextBox1.Text = we;
                        }
                    }
                }
            }
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);   
        }
    }
}
