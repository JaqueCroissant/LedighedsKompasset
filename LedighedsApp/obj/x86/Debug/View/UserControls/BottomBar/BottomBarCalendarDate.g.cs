﻿

#pragma checksum "C:\Users\mathi_000\Documents\Visual Studio 2013\LedighedsKompasset\LedighedsApp\LedighedsApp\View\UserControls\BottomBar\BottomBarCalendarDate.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DC1AAF9574BD18464F72B0BBE410BD50"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LedighedsApp.View.UserControls.BottomBar
{
    partial class BottomBarCalendarDate : global::Windows.UI.Xaml.Controls.UserControl, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 9 "..\..\..\..\..\View\UserControls\BottomBar\BottomBarCalendarDate.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.UserControl_Loaded;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 40 "..\..\..\..\..\View\UserControls\BottomBar\BottomBarCalendarDate.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.ButtonAdd_Tapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 48 "..\..\..\..\..\View\UserControls\BottomBar\BottomBarCalendarDate.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.ButtonShow_Tapped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 56 "..\..\..\..\..\View\UserControls\BottomBar\BottomBarCalendarDate.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.ButtonDelete_Tapped;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 20 "..\..\..\..\..\View\UserControls\BottomBar\BottomBarCalendarDate.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.CalendarTypeListView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


