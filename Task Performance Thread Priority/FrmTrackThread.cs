using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Task_Performance_Thread_Priority
{
    public partial class FrmTrackThread : Form
    {
        public FrmTrackThread()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine("---Thread Start---");

            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadC = new Thread(new ThreadStart(MyThreadClass.Thread2));
            Thread threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));

        }
    }
}
