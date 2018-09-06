using Xamarin.Forms;

namespace ETEP.CEPES.APP.View
{
    public partial class Pesquisa : ContentPage
    {
        public Pesquisa()
        {
            InitializeComponent();
        }

        private async void EnviarPesquisa(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
