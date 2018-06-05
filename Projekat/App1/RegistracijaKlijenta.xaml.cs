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
    public sealed partial class RegistracijaKlijenta : Page
    {
        int i = 0;
        RegistracijaKlijentaViewModel RWM;
        public RegistracijaKlijenta()
        {
            this.InitializeComponent();
            RWM = new RegistracijaKlijentaViewModel();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            if (MainPage.sb == 1) {
                Frame.Navigate(typeof(Admin));

            }
            else
            {
                Frame.Navigate(typeof(MainPage));
            }
            
        }

        private void registruj_Click(object sender, RoutedEventArgs e)
        {
            Bazzza.registrujKlijenta(jmbg.Text, ime.Text, prezime.Text, adresa.Text, brojtelefona.Text,Convert.ToDouble( plata.Text),us.Text,pw.Text);
        }

        private void slikica_Click(object sender, RoutedEventArgs e)
        {
            var capture = new CameraCaptureUI
            {
                PhotoSettings =
    {
        Format = CameraCaptureUIPhotoFormat.Jpeg
    }
            };
            var file =  capture.CaptureFileAsync(CameraCaptureUIMode.Photo);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}