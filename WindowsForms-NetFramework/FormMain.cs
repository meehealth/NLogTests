using NLog;
using System;
using System.Windows.Forms;

namespace WindowsForms_NetFramework
{
    public partial class FormMain : Form
    {
        private static ILogger Logger = LogManager.GetCurrentClassLogger();
        static ILogger LoggerAudit = LogManager.GetLogger("MeeHealth.Audit.FormMain");
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnLogTest_Click(object sender, EventArgs e)
        {
            LoggerAudit.Info("Enter btnLogTest_Click");
            Logger.Trace("This is a trace from {name}", "Wagner");
            Logger.Debug("This is a debug from {name}", "Wagner");
            Logger.Info("This is a info from {name}", "Wagner");
            Logger.Warn("This is a warning from {name}", "Wagner");
            Logger.Error("This is a error from {name}", "Wagner");
            Logger.Fatal("This is a fatal from {name}", "Wagner");
            try
            {
                TriggerException();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Exception caught");
            }
        }

        private void TriggerException()
        {
            throw new Exception("This is a test exception");
        }
    }
}