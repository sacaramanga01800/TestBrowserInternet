using CefSharp;
using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace TestBrowserInternet
{


    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var settings = new CefSettings();
            settings.BrowserSubprocessPath = @"x64\CefSharp.BrowserSubprocess.exe";

            Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);
        }
    }
}
