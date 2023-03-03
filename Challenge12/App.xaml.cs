﻿using System;
using System.Windows;

namespace Challenge12
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            SplashScreen splashScreen = new SplashScreen("sp2.xaml");
            splashScreen.Show(false);

            splashScreen.Close(TimeSpan.FromSeconds(0.5));
        }
    }
}