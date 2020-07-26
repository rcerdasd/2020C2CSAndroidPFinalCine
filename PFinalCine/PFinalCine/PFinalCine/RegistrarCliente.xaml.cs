using Android.Widget;
using PFinalCine.Clases;
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
    public partial class RegistrarCliente : ContentPage
    {
        public RegistrarCliente()
        {
            InitializeComponent();
            b_registrar.Clicked += B_registrar_Clicked;
        }

        private void B_registrar_Clicked(object sender, EventArgs e)
        {
            if (e_cedula.Text != null && e_cedula.Text != "" && e_cedula.Text != " ")
            {
                MSSQLBaseDatos baseDeDatos = new MSSQLBaseDatos();
                if (baseDeDatos.AgregarUsuario("INSERT INTO CLIENTES (cedula) VALUES (" + e_cedula.Text.Trim() +")") == true)
                {
                    Android.Widget.Toast.MakeText(Android.App.Application.Context, "Usuario registrado con exito", ToastLength.Short).Show();
                }
            }
        }
    }
}