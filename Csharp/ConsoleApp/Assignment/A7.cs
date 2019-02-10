using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp.Assignment
{
    public partial class A7 : Form
    {
        public A7()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Starting to calculate Factorial");


                Task<TimeData> task1 = Task.Run(() => StartFactorial(num));
                Task task2 = Task.Run(() => ShowResult());

                await Task.WhenAll(task1, task2); // wait for both to complete

                MessageBox.Show("Calculating is Done");



                DateTime startTime = task1.Result.StartTime;
                DateTime endTime = task1.Result.EndTime;
                double totalMinutes = (endTime - startTime).TotalMinutes;

                textBox1.AppendText(
                $"Total calculation time = {totalMinutes:F6} minutes\r\n");

            }
            catch
            {
                MessageBox.Show("Pleas input integer to calculate factorial");
            }
        }

        public void ShowResult()
        {
            MessageBox.Show("Calculating is almost done..");
        }

        static int Factorial(int n)
        {
            if (n >= 2) return n * Factorial(n - 1);
            return 1;
        }

        TimeData StartFactorial(int n)
        {
            // create a TimeData object to store start/end times
            var result = new TimeData();

            textBox1.Clear();
            AppendText($"******Calculating Factorial for {n} !! **********");
            result.StartTime = DateTime.Now;
            long factValue = Factorial(n);
            result.EndTime = DateTime.Now;



            AppendText($"Factorial for {n} is {factValue}");
            double minutes =
               (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"Calculation time = {minutes:F6} minutes\n");

            return result;
        }



        public void AppendText(String text)
        {
            if (InvokeRequired) // not GUI thread, so add to GUI thread
            {
                Invoke(new MethodInvoker(() => AppendText(text)));
            }
            else // GUI thread so append text
            {

                textBox1.AppendText(text + "\n");
            }
        }
    }
}
