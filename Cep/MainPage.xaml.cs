using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Cep.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Cep
{
    public partial class MainPage : ContentPage
    {
        async void Handle_Completed(object sender, System.EventArgs e)
        {
            var cliente = new HttpClient();
            string cep = txtCEP.Text;
            var json = await cliente.GetStringAsync($"http://viacep.com.br/ws/{cep}/json/");
            var dados = JsonConvert.DeserializeObject<Endereco>(json);

            lblLogradouro.Text  =  dados.logradouro;
            lblComplemento.Text =  dados.logradouro;
            lblBairro.Text      =  dados.logradouro;
            lblLocalidade.Text  =  dados.logradouro;
            lblUf.Text          =  dados.logradouro;
            lblUnidade.Text     =  dados.logradouro;
            lblIBGE.Text        =  dados.logradouro;
            lblGIA.Text         =  dados.logradouro;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
