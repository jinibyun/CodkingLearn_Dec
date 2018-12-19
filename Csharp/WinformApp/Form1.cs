using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run();  // Run Main UI Thread
        }

        private async void Run()
        {
            // task1 is running in other worker thread
            var task1 = Task<int>.Run(() => LongCalcAsync(10));

            // await for task1 to be finished. Once finished, then it is back to original main UI thread, then process next line
            int sum = await task1;

            // UI thread
            this.label1.Text = "Sum is " + sum;            
            this.button1.Enabled = true;
        }

        private int LongCalcAsync(int times)
        {
            // Get Worker Thread from ThreadPool to execute
            int result = 0;
            for (int i = 0; i < times; i++)
            {
                result += i;
                Thread.Sleep(1000);
            }
            return result;
        }
    }
}
