using ETEP.CEPES.APP.Model;
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
            // Criando um objeto do tipo Usuário
            Usuario usuario = new Usuario();

            // Pegando as informações das views e passando para o objeto "usuario"
            usuario.Nome = NomeUsuario.Text;
            usuario.Email = Email.Text;
            usuario.Senha = SenhaCadastro.Text;
            usuario.RA = RA.Text;

            // Criando um objeto do tipo Estabelecimento
            Estabelecimento estabelecimento = new Estabelecimento();

            // Pegando as informações das views e passando para o objeto "estabelecimento"
            estabelecimento.Nome = NomeSupermercado.Text;
            estabelecimento.Bairro = Bairro.Text;
            estabelecimento.Regiao = Regiao.Text;

            // Cria um objeto do tipo Cadastrar
            Cadastrar cadastrar = new Cadastrar();

            // Passando o objeto "usuario" para ser cadastrado
            await cadastrar.CadastrarUsuario(usuario);

            // Passando o objeto "estabelecimento" para ser cadastrado
            await cadastrar.CadastrarEstabelecimento(estabelecimento);
        }
    }
}
