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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace complexcalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class fp : Page
    {
        public fp()
        {
            this.InitializeComponent();
            fadeout.Begin();
        }
        
      
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            welc.Begin();
            
        }
        private void welcome_Completed(object sender, object e)
        {
            cal.Begin();
        }

        private void cal_Completed(object sender, object e)
        {
            sp.Begin();
        }

        private void sp_Completed(object sender, object e)
        {
            ms.Begin();
        }

        private void ms_Completed(object sender, object e)
        {
            ss.Begin();
        }

        private void ss_Completed(object sender, object e)
        {
            sk.Begin();
        }
        private void sk_Completed(object sender, object e)
        {
            clic.Begin();
        }

        
        private void clic_Completed(object sender, object e)
        {
            clicfade.Begin();
        }

        private void clicfade_Completed(object sender, object e)
        {
            clic.Begin();
        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
                       
            Frame.Navigate(typeof(page3));
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(developed));
        }
    }
}
