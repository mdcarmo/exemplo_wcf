using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace AplicacaoWCF.EntidadeServico
{
    [DataContract, Serializable]
    public class InserirClienteResposta
    {
        [DataMember]
        public int Identificador { get; set; }
    }
}
