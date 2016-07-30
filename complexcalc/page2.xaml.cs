using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
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
    public sealed partial class page2 : Page
    {
        public page2()
        {
            this.InitializeComponent();
        }
        double r1, i1;
        bool plusclicked = false;
        bool mc = false;

       async private void power_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (real.Text == string.Empty && imag.Text == string.Empty)
            {
                var dialog = new MessageDialog("Enter a Valid input");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(page2));
            }
            else {
                if (plusclicked == true)
                {

                    r1 = double.Parse(real.Text);
                    i1 = double.Parse(imag.Text);
                    double a = (r1 * r1) - (i1 * i1);
                    double b = (2 * r1 * i1);
                    resultTxtBox.Text = r1.ToString() + "+ i" + i1.ToString() + "=";
                    resultTxtBox.Text += ""+ a.ToString() + " + i " + b.ToString();
                }
               else
               if(mc==true)
                {
                    r1 = double.Parse(real.Text);
                    i1 = double.Parse(imag.Text);
                    double a = (r1 * r1) - (i1 * i1);
                    double b = (-2 * r1 * i1);
                    resultTxtBox.Text = r1.ToString() + "- i" + i1.ToString() + "=";
                    resultTxtBox.Text +=""+ a.ToString() + " + i " +"("+ b.ToString()+")";
                }
            }
        }

       async private void conj_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (real.Text == string.Empty && imag.Text == string.Empty)
            {
                var dialog = new MessageDialog("Enter a Valid input");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(page2));
            }
            else 
                if (plusclicked == true)
            { 
                r1 = double.Parse(real.Text);
                i1 = double.Parse(imag.Text);
                resultTxtBox.Text = r1.ToString() + "+ i" + i1.ToString()+"=";
                resultTxtBox.Text +=""+ r1.ToString() + " - i " + i1.ToString();
            }
            else
            {if (mc == true)
                {
                    r1 = double.Parse(real.Text);
                    i1 = double.Parse(imag.Text);
                    resultTxtBox.Text = r1.ToString() + "- i" + i1.ToString() + "=";
                    resultTxtBox.Text += "" + r1.ToString() + " + i " + i1.ToString();
                }
            }
            
        }

       async private void pol_Tapped(object sender, TappedRoutedEventArgs e)
        {

            if (real.Text == string.Empty && imag.Text == string.Empty)
            {
                var dialog = new MessageDialog("Enter a Valid input");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(page2));
            }
            else {
                if (plusclicked == true)
                {
                    r1 = double.Parse(real.Text);
                    i1 = double.Parse(imag.Text);
                    double r = Math.Sqrt((r1 * r1) + (i1 * i1));
                    double theeta = Math.Atan(i1 / r1);
                    resultTxtBox.Text = r1.ToString() + "+ i" + i1.ToString() + "=";
                    resultTxtBox.Text +=""+ r.ToString() + "(" + "cos" + " ( " + theeta.ToString() + ")" + " + i" + "sin" + " ( " + theeta.ToString() + " ) ";
                }
                else
                    if(mc==true)
                {
                    r1 = double.Parse(real.Text);
                    i1 = double.Parse(imag.Text);
                    double r = Math.Sqrt((r1 * r1) + (i1 * i1));
                    double alpha = Math.Atan(i1 / r1);
                    double theeta = 360 - alpha;
                    resultTxtBox.Text = r1.ToString() + "- i" + i1.ToString() + "=";
                    resultTxtBox.Text += ""+ r.ToString() + "(" + "cos" + " ( " + theeta.ToString() + ")" + " + i" + "sin" + " ( " + theeta.ToString() + " ) ";
                
                 }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            real.Text = string.Empty;
            imag.Text = string.Empty;
            resultTxtBox.Text = string.Empty;
            mc = false;
            plusclicked = false;
        }

      async private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (real.Text == string.Empty && imag.Text == string.Empty)
            {
                var dialog = new MessageDialog("Enter a Valid input");
                await dialog.ShowAsync();
            }
            else {
                plusclicked = true;
                r1 = double.Parse(real.Text);
                resultTxtBox.Text = r1.ToString() + "+" + "i";
            }
               
          }

     async private void minus_Click(object sender, RoutedEventArgs e)
        {

            if (real.Text == string.Empty && imag.Text == string.Empty)
            {
                var dialog = new MessageDialog("Enter a Valid input");
                await dialog.ShowAsync();
            }
            else
            {
                mc= true;
                r1 = double.Parse(real.Text);
                resultTxtBox.Text = r1.ToString() + "-" + "i";
            }
        }

        async private void reci_Tapped(object sender, TappedRoutedEventArgs e)
        {

            if (real.Text == string.Empty && imag.Text == string.Empty)
            {
                var dialog = new MessageDialog("Enter a Valid input");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(page2));
            }
            else {
                if (plusclicked == true)
                {
                    r1 = double.Parse(real.Text);
                    i1 = double.Parse(imag.Text);
                    double a = ((r1) / ((r1 * r1) + (i1 * i1)));
                    double b = ((-i1) / ((r1 * r1) + (i1 * i1)));
                    resultTxtBox.Text = r1.ToString() + "+ i" + i1.ToString() + "=";
                    resultTxtBox.Text += a.ToString() + " + i " + "("+b.ToString()+")";
                }
                else
                {
                    if(mc==true)
                    {
                        r1 = double.Parse(real.Text);
                        i1 = double.Parse(imag.Text);
                        double a = ((r1) / ((r1 * r1) + (i1 * i1)));
                        double b = ((i1) / ((r1 * r1) + (i1 * i1)));
                        resultTxtBox.Text = r1.ToString() + "- i" + i1.ToString() + "=";
                        resultTxtBox.Text += a.ToString() + " + i "  + b.ToString() ;
                    }
                }
            }
        }
    }
}
