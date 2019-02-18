using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            webView1.Navigate(new Uri("ms-appx-web:///index.html"));
            webView1.ScriptNotify += WebView1_ScriptNotify;
        }

        private void WebView1_ScriptNotify(object sender, NotifyEventArgs e)
        {
            text1.Text = e.Value;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //string functionString = String.Format("window.myCallBack('nameDiv')");
            //string str = await webView1.InvokeScriptAsync("eval", new string[] { functionString });
            string str = await webView1.InvokeScriptAsync("myCallBack", new string[] { text1.Text });
        }
    }
}
