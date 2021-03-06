﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using LedighedsApp.Model.Handler;

namespace LedighedsApp.View
{

    public sealed partial class SettingsView : Page
    {
       
        public SettingsView()
        {
            this.InitializeComponent();
        }

        private void GoBack_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
