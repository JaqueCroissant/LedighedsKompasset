﻿

#pragma checksum "C:\Users\mathi_000\Documents\Visual Studio 2013\LedighedsKompasset\LedighedsApp\LedighedsApp\View\HandleActivityView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "384798F0076E827180C4F7E5465A362E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LedighedsApp.View
{
    partial class HandleActivityView : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 11 "..\..\..\View\HandleActivityView.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.Loaded;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 40 "..\..\..\View\HandleActivityView.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.GoBack_OnTapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


