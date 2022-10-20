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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double nota = Convert.ToDouble(txtNota.Text);

            if (nota >= 7)
            {

                DisplayAlert("Mensaje de alerta", "Tu nomre es: " + nombre + ", apellido es: " + apellido, "aprobaste con nota: " + nota);
            }
            else
            {
                DisplayAlert("Mensaje de alerta", "Tu nomre es: " + nombre + ", apellido es: " + apellido, "reprobaste con nota: " + nota);

            }
        }
    }
}