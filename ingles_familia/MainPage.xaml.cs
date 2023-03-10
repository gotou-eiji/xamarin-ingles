using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ingles_familia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btCores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCores());
        }

        private void btNumeros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageNumeros());
        }

        private void btFamilia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageFamilia());
        }

        private void btSair_Clicked(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch
            {

            }
        }
    }
}
