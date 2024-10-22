﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PFinalCine
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            b_ingresar.Clicked += B_ingresar_Clicked;
            b_registrar.Clicked += B_registrar_Clicked;
        }

        private void B_registrar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new RegistrarCliente());
        }

        private void B_ingresar_Clicked(object sender, EventArgs e)
        {
            if (e_user.Text == "admin" && e_passwd.Text == "admin123")
            {
                ((NavigationPage)this.Parent).PushAsync(new Menu());
                e_passwd.Text = "";
                e_user.Text = "";
            }
            else
            {
                AlertaMensajeError("El usuario no ha sido registrado");
            }
            
        }

        private async void AlertaMensajeError(string mensaje)
        {
            await DisplayAlert("Alerta", mensaje, "OK");
        }
    }
}
