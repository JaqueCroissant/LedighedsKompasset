﻿

#pragma checksum "C:\Users\mathi_000\Documents\Visual Studio 2013\LedighedsKompasset\LedighedsApp\LedighedsApp\View\UserControls\TutorialUC.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "972858CB61AE18D9537C39EB7325FCA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LedighedsApp.View.UserControls
{
    partial class TutorialUc : global::Windows.UI.Xaml.Controls.UserControl, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 10 "..\..\..\..\View\UserControls\TutorialUC.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.UserControl_Loaded;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 30 "..\..\..\..\View\UserControls\TutorialUC.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).LayoutUpdated += this.TextBlock_LayoutUpdated;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 32 "..\..\..\..\View\UserControls\TutorialUC.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.CloseButton_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 37 "..\..\..\..\View\UserControls\TutorialUC.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.BackwardButton_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 42 "..\..\..\..\View\UserControls\TutorialUC.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ForwardButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


