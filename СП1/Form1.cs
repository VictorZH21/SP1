using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СП1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.AppendText($"{Environment.OSVersion}. \n");
            textBox2.AppendText($"{Environment.Is64BitOperatingSystem}. \n");
            textBox3.AppendText($"{Environment.MachineName}. \n");
            textBox4.AppendText($"{Environment.ProcessorCount}. \n");
            textBox5.AppendText($"{Environment.SystemDirectory}. \n");
            textBox6.AppendText($"{String.Join(",", Environment.GetLogicalDrives()).TrimEnd(',', ' ').Replace("/", String.Empty)}. \n");
        }
    }
}
