using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using MVVMTemplate.ViewModel;

namespace MVVMTemplate
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow window = new MainWindow();
            var windowmodel = new MainWindowViewModel(window);
            window.DataContext = windowmodel;
            window.Show();
        }
    }
}
