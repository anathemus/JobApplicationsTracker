using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using JobApplicationsTracker.Model;

namespace JobApplicationsTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, EventArgs e)
        {
            StreamReadWrite.InitializeTextReadWrite();
            MainWindow window = new MainWindow();
            window.Show();
        }
    }
}
