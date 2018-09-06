using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETEP.CEPES.APP.Model
{
    public class Estabelecimento
    {
        /// <summary>
        /// Adiciona um número para IDentificação do estabelecimento no banco de dados
        /// </summary>
        public int IdEstabelecimento { get; set; }
        /// <summary>
        /// Nome do estabelecimento
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Bairro onde se encontra o estabelecimento
        /// </summary>
        public string Bairro { get; set; }
        /// <summary>
        /// Região onde se encontra o estabelecimento
        /// </summary>
        public string Regiao { get; set; }
    }
}
