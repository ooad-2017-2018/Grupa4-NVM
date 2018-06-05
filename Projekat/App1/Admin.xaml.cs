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
    public sealed partial class Admin : Page
    {
        AdminViewModel lwm;
        public Admin()
        {


            this.InitializeComponent();
            lwm = new AdminViewModel();
            Bazzza.dajKlijente();

            Bazzza.dajUposlene();
            Bazzza.dajManagere();
        }

        private void rkl_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegistracijaKlijenta));
        }

        private void rpo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegistracijaPoslovnice2));
        }

        private void rupo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegistracijaUposlenika));
        }

        private void okl_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BrisanjeKlijenta));
        }

        private void opo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BrisanjePoslovnice));
        }

        private void oupo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BrisanjeUposlenika));
        }
    }
}
