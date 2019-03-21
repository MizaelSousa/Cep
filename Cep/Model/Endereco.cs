using System;
namespace Cep.Model
{
    public class Endereco
    {
        public string cep { set; get; }
        public string logradouro { set; get; }
        public string complemento { set; get; }
        public string bairro { set; get; }
        public string localidade { set; get; }
        public string uf { set; get; }
        public string unidade { set; get; }
        public string ibge { set; get; }
        public string gia { set; get; }

public Endereco()
        {
        }
    }
}
