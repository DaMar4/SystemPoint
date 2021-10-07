using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemPoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
            string FileToRead = @"c:/boot_windows.txt";
            //List<string> apps = new List<string>();
            using (StreamReader ReaderObject = new StreamReader(FileToRead))
            {

                string Line;
                // ReaderObject reads a single line, stores it in Line string variable and then displays it on console
                while ((Line = ReaderObject.ReadLine()) != null)
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo(@Line);
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(startInfo2);
                }
            }
        }
    }
}

