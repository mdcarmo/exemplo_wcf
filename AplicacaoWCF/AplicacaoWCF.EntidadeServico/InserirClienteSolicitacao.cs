using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace AplicacaoWCF.EntidadeServico
{
    [DataContract, Serializable]
    public class InserirClienteSolicitacao
    {
        [DataMember]
        public string Nome { get; set; }
    }
}
