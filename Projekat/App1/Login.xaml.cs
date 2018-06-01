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
        public MainPage()
        {
            //Bazzza.registrujKlijenta("1406997190017","Mirza","Delic","Travnicka cesta 44","387603083506",0);
            /*Bazzza.dajKlijenta();
            Debug.WriteLine("Broj Klijenata 1 : " +MikroKreditnaGrupaNVM.listaKlijenata.Count().ToString());
            for (int i = 0; i < 10000; i++)
            {
                int a = 0;
                int b = 0;
                int c = a + b;
            }
            foreach (Klijent k in MikroKreditnaGrupaNVM.listaKlijenata) Debug.WriteLine("Klijent : " + k.ispisiKlijenta());*/
            this.InitializeComponent();
            /*Bazzza.dajKlijenta();
            Debug.WriteLine("Broj Klijenata 2 : " + MikroKreditnaGrupaNVM.listaKlijenata.Count().ToString());
            for(int i = 0; i < 10000; i++)
            {
                int a = 0;
                int b = 0;
                int c = a + b;
            }
            foreach (Klijent k in MikroKreditnaGrupaNVM.listaKlijenata) Debug.WriteLine("Klijent : " + k.ispisiKlijenta());*/
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
        }
    }
}
