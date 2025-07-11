using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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

namespace LearnSplashScreen
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50); // Simulate some work being done
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Loading data, please wait...");
            // Simulate a long-running operation
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50); // Simulate some work being done
            }
            SplashScreenManager.CloseForm(false);
        }
    }
}