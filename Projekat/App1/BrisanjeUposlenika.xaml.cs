﻿using App1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public sealed partial class BrisanjeUposlenika : Page
    {
        int i = 0;
        BrisanjeUposlenikaViewModel RWM;
        public BrisanjeUposlenika()
        {
            this.InitializeComponent();
            RWM = new BrisanjeUposlenikaViewModel();
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

        private void upo1_Checked(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            Debug.Write(MikroKreditnaGrupaNVM.listaUposlenika.Count());
            foreach (Uposlenik k in MikroKreditnaGrupaNVM.listaUposlenika)
            {
                lista.Items.Add(k.Ime);
            }
        }

        private void men1_Checked(object sender, RoutedEventArgs e)
        {

            lista.Items.Clear();

            Debug.Write(MikroKreditnaGrupaNVM.listaManagera.Count());
            foreach (Manager k in MikroKreditnaGrupaNVM.listaManagera)
            {
                lista.Items.Add(k.Ime);
            }
        }
    }
}