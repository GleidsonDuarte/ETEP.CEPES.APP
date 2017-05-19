using System;
using Xamarin.Forms;

namespace ETEP.CEPES.APP.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CadastrarUsuario(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Cadastro());
        }

        private async void LogarUsuario(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Pesquisa());
        }
    }
}
