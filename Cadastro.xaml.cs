using Xamarin.Forms;

namespace ETEP.CEPES.APP.View
{
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private async void ConcluirCadastro(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
