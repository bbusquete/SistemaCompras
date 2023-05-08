using MediatR;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System;
using System.Collections.Generic;

namespace SistemaCompra.Application.SolicitacaoCompra.Command.SolicitacaoCompra
{
    public class RegistrarSolicitacaoCompraCommand : IRequest<bool>
    {
        public string UsuarioSolicitante { get; set; }
        public string NomeFornecedor { get; set; }
        public DateTime Data { get; set; }
        public Decimal TotalGeral { get; set; }
        public int Situacao { get; set; }
        public int CondicaoPagamento { get; set; }
        public IList<Item> Itens { get; set; }
    }
}
