using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_programing_pr2
{
    public partial class Form1 : Form
    {
        int i = 0;
        string change = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Lololo();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Lololo();

        }

        private void Lololo()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            dataGridView1.Columns.Add("Property", "Свойство");
            dataGridView1.Columns.Add("Value", "Значение");

            

            if (comboBox1.SelectedIndex == 0)
            {
                change = "Win32_Processor";
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                change = "Win32_VideoController";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                change = "Win32_IDEController";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                change = "Win32_Battery";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                change = "Win32_BIOS";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                change = "Win32_PhysicalMemory";
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                change = "Win32_CacheMemory";
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                change = "Win32_USBController";
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                change = "Win32_DiskDrive";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                change = "Win32_LogicalDisk";
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                change = "Win32_Keyboard";
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                change = "Win32_NetworkAdapter";
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                change = "Win32_Account";
            }


            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + change );
            foreach (ManagementObject obj in searcher.Get())
            {
                foreach (PropertyData data in obj.Properties)
                {
                    string value = data.Value != null ? data.Value.ToString() : "Неизвестно";
                    dataGridView1.Rows.Add(data.Name, value);
                }
            }
        }
    }
}
