using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hardware_Info;


namespace OS_CursProject
{
    public partial class MainWindow : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
            
            ProcessorInfo Test3 = new ProcessorInfo();

            Test3.GetInfo();
            value1.Text = Test3.procName[0];
            value2.Text = "x86";
            value3.Text = Test3.procCaption[0];
            value4.Text = Test3.procCurrentClockSpeed[0] + " ГГц";
            value5.Text = Test3.procNumberOfCores[0];
            value6.Text = Test3.procThreadCount[0];
            //Тут что-то с тредами....
           
            //Thread timerThread = new Thread(InitializeTimer);
            //timerThread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiskDriveInfo Test = new DiskDriveInfo();
           
            VideoControllerInfo Test3 = new VideoControllerInfo();
            Test.GetInfo();
           
            Test3.GetInfo();
        }

        private void chartCPU_perf_Click(object sender, EventArgs e)
        {

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            ProcessorInfo Test2 = new ProcessorInfo();
            Test2.GetCpuClockSpeed();
            Test2.GetProcTime();
            if (chartCPU.Series["CPU Usage"].Points.Count == 60)
                chartCPU.Series["CPU Usage"].Points.Clear();
            if (Test2.procLoadPercentage.Count == 0)
                return;
            chartCPU.Series["CPU Usage"].Points.AddY(Int32.Parse(Test2.procLoadPercentage[0]));
            //CPU_UsageProgressBar.Value = Int32.Parse(Test2.procLoadPercentage[0]);
        }
        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.  
            chartCPU.Series["CPU Usage"].Points.AddY(0);
           
            myTimer.Interval = 500;
            myTimer.Tick += new EventHandler(timer_Tick);
            myTimer.Start();
            // Enable timer.  

        }

        private void MultiThreading()
        {
            Thread t = Thread.CurrentThread;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void cpu2_Click(object sender, EventArgs e)
        {

        }

        private void cpu3_Click(object sender, EventArgs e)
        {

        }
    }

    public class Performance
    {
        
    }
}
