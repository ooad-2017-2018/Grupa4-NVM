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
using System.Diagnostics;
using App1.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        LoginViewModel lwm;
        public static int sb=0;
        public MainPage()
        {

            
            this.InitializeComponent();
            lwm = new LoginViewModel();
            
            
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void prijavi_Click(object sender, RoutedEventArgs e)
        {
         //   Bazzza.dajKlijente();

            if(user.Text=="admin" && pass.Password == "admin")
            {
                sb = 1;
                Frame.Navigate(typeof(Admin));
            }
        }

        private void registrujSe_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegistracijaKlijenta));
        }
    }
}
