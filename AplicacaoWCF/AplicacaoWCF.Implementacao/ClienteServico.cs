using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacaoWCF.Contrato;
using AplicacaoWCF.EntidadeServico;

namespace AplicacaoWCF.Implementacao
{
    public class ClienteServico: ICliente
    {
        public InserirClienteResposta InserirCliente(InserirClienteSolicitacao solicitacao)
        {
            InserirClienteResposta resposta = new InserirClienteResposta();
            resposta.Identificador = 1;
            return resposta;
        }
    }
}
