using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Windows;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace complexcalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

   

    public sealed partial class MainPage : Page
    {
        TextBox temp;
        double r1, r2, i1, i2, totalimag, totalreal;
           
        public MainPage()
        {
            this.InitializeComponent();
            
            temp = real;
           if(temp==real)
            {
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255,255, 0, 0);
                real.Background = mySolidColorBrush;
            }

          

        }

        StorageFolder localFolder = ApplicationData.Current.LocalFolder;

        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;
        bool plclicked = false;
        bool miclicked = false;

       

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            temp.Text = temp.Text + "0";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            temp.Text = temp.Text + "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            temp.Text = temp.Text + "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            temp.Text = temp.Text + "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            temp.Text = temp.Text + "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            temp.Text = temp.Text + "5";
        }

        //button9 == btn6 
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            temp.Text = temp.Text + "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            temp.Text = temp.Text + "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            temp.Text = temp.Text + "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            temp.Text = temp.Text + "9";
        }
        

       async private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

           if ((real.Text == String.Empty) || (imag.Text == String.Empty))
            {
                var dialog = new MessageDialog("Enter a Valid Input");
                await dialog.ShowAsync();

            }
            else
            {

                r1 = double.Parse(real.Text);
                i1 = double.Parse(imag.Text);
                resultTxtBox.Text = "(" + (r1.ToString() + " + i" + i1.ToString())+ ")" + '+' ;
                real.Text = "";
                imag.Text = "";
                temp = real;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
                real.Background = mySolidColorBrush;
                SolidColorBrush brush = new SolidColorBrush();
                brush.Color = Color.FromArgb(255, 0, 0, 0);
                imag.Background = brush;

                plusButtonClicked = true;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = false;
                plclicked = false;
                miclicked = false;
            }
        }

      async private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            if ((real.Text == String.Empty) || (imag.Text == String.Empty))
            {
                var dialog = new MessageDialog("Enter a Valid Input");
                await dialog.ShowAsync();


            }
            else
            {
                r1 = double.Parse(real.Text);
                i1 = double.Parse(imag.Text);
                resultTxtBox.Text = "("+(r1.ToString() + " + i" + i1.ToString()) +")" + '-';

                real.Text = "";
                imag.Text = "";
                temp = real;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
                real.Background = mySolidColorBrush;
                SolidColorBrush brush = new SolidColorBrush();
                brush.Color = Color.FromArgb(255, 0, 0, 0);
                imag.Background = brush;

                plusButtonClicked = false;
                minusButtonClicked = true;
                multiplyButtonClicked = false;
                divideButtonClicked = false;
                plclicked = false;
                miclicked = false;
            }
        }

       async private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if ((real.Text == String.Empty) || (imag.Text == String.Empty))
            {
                var dialog = new MessageDialog("Enter a Valid Input");
                await dialog.ShowAsync();


            }
            else
            {

                r1 = double.Parse(real.Text);
                i1 = double.Parse(imag.Text);
                resultTxtBox.Text = "("+(r1.ToString() + " + i" + i1.ToString()) +")" + '*';

                real.Text = "";
                imag.Text = "";
                temp = real;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
                real.Background = mySolidColorBrush;
                SolidColorBrush brush = new SolidColorBrush();
                brush.Color = Color.FromArgb(255, 0, 0, 0);
                imag.Background = brush;

                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = true;
                divideButtonClicked = false;
                plclicked = false;
                miclicked = false;
            }
        }

        async private void btnDivide_Click(object sender, RoutedEventArgs e)
        {

            if ((real.Text == String.Empty) || (imag.Text == String.Empty))
            {
                var dialog = new MessageDialog("Enter a Valid Input");
                await dialog.ShowAsync();


            }
        
            else
            {

               r1 = double.Parse(real.Text);
                i1 = double.Parse(imag.Text);
                resultTxtBox.Text = "(" + (r1.ToString() + " + i " + i1.ToString()) + ")" + '/';
                real.Text = "";
                imag.Text = "";
                temp = real;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
                real.Background = mySolidColorBrush;
                SolidColorBrush brush = new SolidColorBrush();
                brush.Color = Color.FromArgb(255, 0, 0, 0);
                imag.Background = brush;

                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = true;
                plclicked = false;
                miclicked = false;
            }
        }

        private void clear(object sender, RoutedEventArgs e)
        {
            if (temp == real)
            {
                string s = real.Text;

                if (s.Length >= 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
               // else
                //{
                   // s = "0";
                //}
               
                real.Text = s;
            }
            else
            {
                string s = imag.Text;

                if (s.Length >= 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    //s = "0";
                    temp = real;
                }

                imag.Text = s;
            }
        }
       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

       async private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
           
            if ((real.Text=="")||(imag.Text==""))
            {
                var dialog = new MessageDialog("Invalid Input");
                await dialog.ShowAsync();

                //textBlock1.Visibility = Visibility.Visible;
            }
            else
            {
                
                r2 = double.Parse(real.Text);
                i2 = double.Parse(imag.Text);
             
                real.Text = string.Empty;
                imag.Text = string.Empty;

                if (plusButtonClicked == true)
                {
                    totalreal = r1 + r2;
                    totalimag = i1 + i2;
                    resultTxtBox.Text += "(" + r2.ToString() + " + i" + i2.ToString() + " ) " + " = ";
                    resultTxtBox.Text += " ( "+ totalreal.ToString() + " + i" + totalimag.ToString() +" ) ";

                }
                else if (minusButtonClicked == true)
                {
                    totalreal = r1 - r2;
                    totalimag = i1 - i2;
                    resultTxtBox.Text += "(" + r2.ToString() + " + i" + i2.ToString() + " ) " + " = ";
                    resultTxtBox.Text += "(" + totalreal.ToString() + " + i " + totalimag.ToString() +" ) ";

                }
                else if (multiplyButtonClicked == true)
                {
                    totalreal = (r1 * r2 - (i1 * i2));
                    totalimag = (i1 * r2 + (i2 * r1));
                    resultTxtBox.Text += "(" + r2.ToString() + " + i" + i2.ToString() + " ) " + " = ";
                    resultTxtBox.Text += "(" + totalreal.ToString() + " + i " + totalimag.ToString() +" ) ";

                }
                else if (divideButtonClicked == true)
                {
                    if (((r2 * r2) + (i2 * i2)) != 0)
                    {
                        totalreal = (r1 * r2 + (i1 * i2)) / ((r2 * r2) + (i2 * i2));
                        totalimag = (i2 * r1 - (r1 * i2) / ((r2 * r2) + (i2 * i2)));
                        resultTxtBox.Text += "(" + r2.ToString() + " + i" + i2.ToString() + " ) " + " = ";
                        resultTxtBox.Text += "(" + totalreal.ToString() + " + i " + totalimag.ToString() + " ) ";
                        
                    }
                    else
                    {
                        resultTxtBox.Text += "(" + r2.ToString() + " + i" + i2.ToString() + " ) " + " = ";
                        var dialog = new MessageDialog("Divide By Zero Error");
                        await dialog.ShowAsync();
                    }
                }
            }
          
            writetext();
          
        }

       async private void button2_Click(object sender, RoutedEventArgs e)
        {

            var dialog = new MessageDialog("Thank YOu");
            dialog.Commands.Add(new UICommand("Cancel", new UICommandInvokedHandler(commandhandler)));
            dialog.Commands.Add(new UICommand("Close", new UICommandInvokedHandler(commandhandler)));
            await dialog.ShowAsync();
           // Application.Current.Exit();
            
        }
        private void commandhandler(IUICommand command)
        {
            var commandlabel = command.Label;
            switch (commandlabel)
            {
                case "Cancel":
                    Frame.Navigate(typeof(MainPage));
                    break;
                case "Close":
                    Application.Current.Exit();
                    break;
                case "Retry":
                    Frame.Navigate(typeof(MainPage));
                    break;

            }
        }

        async private void button2_Copy_Click(object sender, RoutedEventArgs e)
        {
            if ((plusButtonClicked==true)||(minusButtonClicked==true)||(multiplyButtonClicked==true)||(divideButtonClicked==true))
            {
                StorageFile textFile = await localFolder.GetFileAsync("sample.txt");
                using (IRandomAccessStream textStream = await textFile.OpenAsync(FileAccessMode.Read))
                {

                    using (DataReader textWriter = new DataReader(textStream))
                    {
                        
                       
                        resultTxtBox.Text = await FileIO.ReadTextAsync(textFile);

                       
                    }

                }
            }
            else
                if(resultTxtBox.Text==string.Empty)
                resultTxtBox.Text = "0";
         }

        private void real_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void sqrt_Click(object sender, RoutedEventArgs e)
        {
            double a = (totalreal * totalreal) - (totalimag * totalimag) ;
            double b = (2 * totalreal * totalimag);
            resultTxtBox.Text = a.ToString() + " + i " + b.ToString();
        }

        private void rand_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            double realnum1 = rnd.Next(1, 13);
            double imagnum1 = rnd.Next(1, 13);

            real.Text = realnum1.ToString();
            imag.Text = imagnum1.ToString();

        }

        private void reci_Click(object sender, RoutedEventArgs e)
        {
            double a = ((totalreal) / ((totalreal * totalreal) + (totalimag * totalimag)));
            double b=((totalimag)/ ((totalreal * totalreal) + (totalimag * totalimag)));
            resultTxtBox.Text = a.ToString() + " + i " + b.ToString();
            writetext();
        }

        private void conj_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = totalreal.ToString() + " - i " + totalimag.ToString();
            writetext();
        }

        private void polar_Click(object sender, RoutedEventArgs e)
        {
            double r = Math.Sqrt((totalreal*totalreal)+(totalimag* totalimag));
            double theeta = Math.Atan(totalimag / totalreal);
            resultTxtBox.Text = r.ToString() + "(" + "cos" + " ( " +theeta.ToString()+")"+ " + i"+ "sin"+ " ( "+theeta.ToString()+ " ) ";
            writetext();
        }

        private void mi_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }




        // Write a text file to the app's local folder. 
        async void writetext()
        {
            StorageFile textFile = await localFolder.CreateFileAsync("sample.txt", CreationCollisionOption.ReplaceExisting);
            using (IRandomAccessStream textStream = await textFile.OpenAsync(FileAccessMode.ReadWrite))
            {

                using (DataWriter textWriter = new DataWriter(textStream))
                {
                    textWriter.WriteString(resultTxtBox.Text);
                    await textWriter.StoreAsync();
                }

            }


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            real.Text = "";
            imag.Text = "";
            resultTxtBox.Text = "";
            temp = real;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
            real.Background = mySolidColorBrush;
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Color.FromArgb(255, 0, 0, 0);
            imag.Background = brush;
            // textBlock.Visibility = Visibility.Collapsed;
            // textBlock1.Visibility = Visibility.Collapsed;
            // button1.Visibility = Visibility.Visible;
            //rand.Visibility = Visibility.Collapsed;

        }
        // Read the contents of a text file from the app's local folder.

        private void btnDecimalPoint_Click(object sender, RoutedEventArgs e) 
        {
            temp.Text += ".";
        }

        private void real_Tapped(object sender, TappedRoutedEventArgs e)
        {


        }

        private void imagine_Click(object sender, RoutedEventArgs e)
        {
            if (temp == real)
            {
                temp = imag;

                SolidColorBrush brush = new SolidColorBrush();
                brush.Color = Color.FromArgb(255, 0, 0, 0);
                real.Background = brush;

                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255,255, 0, 0);
                imag.Background = mySolidColorBrush;
            }
            else
            {
                SolidColorBrush brush = new SolidColorBrush();
                brush.Color = Color.FromArgb(255, 0, 0, 0);
                imag.Background = brush;

                temp = real;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
                real.Background = mySolidColorBrush;

            }
        }
       async private void imagin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if((plclicked==false)&&(miclicked==false))
            {
                var dialog = new MessageDialog("Please specify + or -");
                dialog.Commands.Add(new UICommand("Retry", new UICommandInvokedHandler(commandhandler)));
                await dialog.ShowAsync();
            }
            if (temp == real)
            {
                temp = imag;

                SolidColorBrush brush = new SolidColorBrush();
                brush.Color = Color.FromArgb(255, 0, 0, 0);
                real.Background = brush;

                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
                imag.Background = mySolidColorBrush;
            }
            else
            {
                SolidColorBrush brush = new SolidColorBrush();
                brush.Color = Color.FromArgb(255, 0, 0, 0);
                imag.Background = brush;

                temp = real;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
                real.Background = mySolidColorBrush;

            }
        }
    }
}



    

