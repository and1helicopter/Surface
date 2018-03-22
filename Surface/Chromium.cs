using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using CefSharp;
using CefSharp.WinForms;
using Surface;

namespace embebbedChromium
{
    class CefCustomObject
    {
        // Declare a local instance of chromium and the main form in order to execute things from here in the main thread
        private static ChromiumWebBrowser _instanceBrowser = null;
        // The form class needs to be changed according to yours
        private static Form1 _instanceMainForm = null;


        public CefCustomObject(ChromiumWebBrowser originalBrowser, Form1 mainForm)
        {
            _instanceBrowser = originalBrowser;
            _instanceMainForm = mainForm;
        }

        public void showDevTools()
        {
            _instanceBrowser.ShowDevTools();
        }
        
        public dynamic saveToFile(dynamic file)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                DefaultExt = @".json",
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);

            }
            return false;
        }

        //public void opencmd()
        //{
        //	ProcessStartInfo start = new ProcessStartInfo("cmd.exe", "/c pause");
        //	Process.Start(start);
        //}
    }
}