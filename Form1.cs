using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiskDriveInfo Test = new DiskDriveInfo();
            ProcessorInfo Test2 = new ProcessorInfo();
            Test.GetInfo();
            Test2.GetInfo();
        }
    }
}
