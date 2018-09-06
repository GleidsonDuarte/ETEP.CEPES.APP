using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ETEP.CEPES.APP.Model
{
    //public class WebService<T> 
    //{
    //public async Task<HttpResponseMessage> Chamda(String endereco, HttpMethod metodo )
    //{
    //    var request = new HttpClient();
    //    request.BaseAddress = new Uri(host);

    //    var e = new HttpRequestMessage(metodo, endereco);

    //    var json = JsonConvert.SerializeObject(Usuario);
    //    var content = new StringContent(json, Encoding.UTF8, "application/json");

    //    request.DefaultRequestHeaders.Accept.Clear();
    //    request.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    //    return await request.SendAsync(e);
    //}

    //public async Task Chamada(Usuario usuario, bool isNewItem = false)
    //{

    //    }

    public class Cadastrar
    {
        public async Task CadastrarUsuario(Usuario usuario, bool novoItem = true)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8080/");
                //var uri = new Uri(string.Format(restUri));

                var json = JsonConvert.SerializeObject(usuario);
                var objetoSerealizado = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (novoItem)
                {
                    response = await client.PostAsync("api/CadastrarUsuario", objetoSerealizado);
                }
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"             Usuario successfully saved.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task CadastrarEstabelecimento(Estabelecimento estabelecimento, bool novoItem = true)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8080/");
                //var uri = new Uri(string.Format(restUri));

                var json = JsonConvert.SerializeObject(estabelecimento);
                var objetoSerealizado = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (novoItem)
                {
                    response = await client.PostAsync("api/CadastrarEstabelecimento", objetoSerealizado);
                }
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"             Usuario successfully saved.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}