using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace TestApp
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // 1. Obtain the current application process
            Process currentProcess = Process.GetCurrentProcess();

            // 2. Obtain the used memory by the process
            long usedMemory = currentProcess.PrivateMemorySize64;

            // 3. Display value
            text_label.Text = "Memory " + usedMemory.ToString();
        }
    }
}
