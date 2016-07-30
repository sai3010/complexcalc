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
using Windows.Security.Credentials;
using System.Windows;
using Windows.UI.Popups;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace complexcalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class login : Page
    {
        public login()
        {
            this.InitializeComponent();
        }
        // Create sample file; replace if exists.
        // Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
        // Windows.Storage.StorageFile sampleFile = await.storageFolder.CreateFileAsync("sample.txt",Windows.Storage.CreationCollisionOption.OpenIfExists);
        //var vault = new Windows.Security.Credentials.PasswordVault();
        //vault.Add(new Windows.Security.Credentials.PasswordCredential( "complexcalc", user, password));


       async private void Login_Click(object sender, RoutedEventArgs e)
        {
            if(User.Text=="sai"&&Pass.Password=="3010")
            {
                Frame.Navigate(typeof(MainPage));
            }
            else
            {
                var dialog = new MessageDialog("Invalid Credentials");
                dialog.Commands.Add(new UICommand("Retry", new UICommandInvokedHandler(commandhandler)));
                dialog.Commands.Add(new UICommand("Close", new UICommandInvokedHandler(commandhandler)));

                await dialog.ShowAsync();


            }
        }
        private void commandhandler(IUICommand command)
        {
            var commandlabel = command.Label;
                switch(commandlabel)
            {
                case "Retry":
                    Frame.Navigate(typeof(login));
                    break;
                case "Close":
                    Frame.Navigate(typeof(fp));
                    break;
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(fp));
        }
    }
}
