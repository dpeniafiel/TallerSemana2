using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerSemana2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "dpeniafiel";
            string clave = "123";

            string tUsuario = txtUsuario.Text;
            string tContrasenia = txtContrasenia.Text;

            if (usuario == tUsuario & clave == tContrasenia)
            {
                DisplayAlert("Info", "Usuario correcto", "ok");
                Navigation.PushAsync(new Registro());
            }
            else
            {
                DisplayAlert("Error", "Usuario  incorrecto", "cerrar");

            }
        }
    }
}