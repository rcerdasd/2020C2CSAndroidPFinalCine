using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace PFinalCine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            b_verCartelera.Clicked += B_verCartelera_Clicked;
            b_reservar.Clicked += B_reservar_Clicked;
            b_verReservas.Clicked += B_verReservas_Clicked; //FALTA PROGRAMAR ESTE BOTON
            b_cerrarSesion.Clicked += B_cerrarSesion_Clicked;
        }

        private void B_cerrarSesion_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }

        private void B_verReservas_Clicked(object sender, EventArgs e)
        {
            //FALTA PROGRAMAR ESTE BOTON
            Android.Widget.Toast.MakeText(Android.App.Application.Context, "ESTE BOTON AUN NO HA SIDO PROGRAMADO", ToastLength.Short).Show();
        }

        private void B_reservar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Reserva());
        }

        private void B_verCartelera_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Cartelera());
        }


    }
}