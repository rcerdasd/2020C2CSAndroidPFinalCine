using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PFinalCine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cartelera : ContentPage
    {
        public Cartelera()
        {
            InitializeComponent();
            b_regresar.Clicked += B_regresar_Clicked;
        }

        private void B_regresar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}