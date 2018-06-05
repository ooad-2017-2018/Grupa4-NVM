using App1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    public sealed partial class BrisanjePoslovnice : Page
    {
        int i = 0;
        BrisanjePoslovniceViewModel RWM;
        public BrisanjePoslovnice()
        {
            this.InitializeComponent();
            RWM = new BrisanjePoslovniceViewModel();
            lista.
            foreach (Poslovnica k in MikroKreditnaGrupaNVM.listaPoslovnica)
            {
                lista.Items.Add(k.Adresa);
            }
        }



        private void nazad_Click_1(object sender, RoutedEventArgs e)
        {

            if (MainPage.sb == 1)
            {
                Frame.Navigate(typeof(Admin));

            }
            else
            {
                Frame.Navigate(typeof(MainPage));
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bazzza.obrisiPoslovnicu(MikroKreditnaGrupaNVM.listaPoslovnica[lista.SelectedIndex].PoslovnicaID);
        }
    }
}