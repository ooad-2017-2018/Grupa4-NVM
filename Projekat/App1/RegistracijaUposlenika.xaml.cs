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
    public sealed partial class RegistracijaUposlenika : Page
    {
        RegistracijaUposlenikaViewModel rwm;
        private int od = 0;
        public RegistracijaUposlenika()
        {


            this.InitializeComponent();
            rwm = new RegistracijaUposlenikaViewModel();

        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {

            if (MainPage.sb  == 1)
            {
                Frame.Navigate(typeof(Admin));

            }
            else
            {
                Frame.Navigate(typeof(MainPage));
            }

        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            if (od==1)
            {
                Bazzza.registrujUposlenika(jmbg.Text, ime.Text, prezime.Text, adresa.Text, brojtelefona.Text, "", "");
                Debug.Write("evo");
            }
            else {
                Bazzza.registrujManagera(jmbg.Text, ime.Text, prezime.Text, adresa.Text, brojtelefona.Text, "", "");

            }
        }

        private void upo_Checked(object sender, RoutedEventArgs e)
        {
            od = 1;
        }

        private void men_Checked(object sender, RoutedEventArgs e)
        {
            od = 2;
        }
    }
}
