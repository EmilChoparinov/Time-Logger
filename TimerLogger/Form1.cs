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

namespace TimerLogger
{
    public partial class TimeLogger : Form
    {

        String setName = "";
        bool isNameEntered = false;

        bool isStart = false;
        bool isStop = true;

        public TimeLogger()
        {
            InitializeComponent();
        }

        //chrome
        private void button2_Click(object sender, EventArgs e)
        {
            logTextToTextBox("Attempting Chrome Launch...");
            try
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
                logTextToTextBox("Chrome launch successful!");
            }
            catch(Exception f)
            {
                logTextToTextBox("Chrome Failed to Launch!");
            }
        }

        private void steamButton_Click(object sender, EventArgs e)
        {
            logTextToTextBox("Attempting Steam Launch...");
            try
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Steam\Steam.exe");
                logTextToTextBox("Steam launch successful!");
            }
            catch (Exception f)
            {
                logTextToTextBox("Steam Failed to Launch!");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isNameEntered)
            {
                logTextToTextBox("Name not entered yet!");
            }
            else if(!isStart)
            {
                isStart = true;
                isStop = false;
                logTextToTextBox("Timer Started: " + DateTime.Now.ToString("h:mm:ss tt"));
                logTextToTextFile("[" + setName + "] time start: " + DateTime.Now.ToString("h:mm:ss tt"));
            }
            else
            {
                logTextToTextBox("Timer already started!");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (!isNameEntered)
            {
                logTextToTextBox("Name not entered yet!");
            }
            else if (!isStop)
            {
                isStop = true;
                isStart = false;

                logTextToTextBox("Timer Stopped: " + DateTime.Now.ToString("h:mm:ss tt"));
                logTextToTextFile("[" + setName + "] time Stopped: " + DateTime.Now.ToString("h:mm:ss tt"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!nameBox.Text.Equals(""))
            {
                setName = nameBox.Text;
                isNameEntered = true;
                logTextToTextBox("Name set to " + setName);
            }
            else
            {
                logTextToTextBox("Name entered not valid!");
            }
        }

        public void logTextToTextBox(String text)
        {
            textBox.Text += text + "\n";
        }

        public void logTextToTextFile(String text)
        {
            File.AppendAllText(@"C:\Users\emilc\Documents\Visual Studio 2017\Projects\TimerLogger\TimerLogger\logger.txt", text);
        }
    }
}
