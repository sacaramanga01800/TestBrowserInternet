﻿using CefSharp;
using CefSharp.Wpf;
using Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestBrowserInternet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : RibbonWindow
    {
        public MainWindow2()
        {
            //var settings = new CefSettings();
            //settings.BrowserSubprocessPath = @"x64\CefSharp.BrowserSubprocess.exe";

            //Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);
            InitializeComponent();
        }
    }
}
