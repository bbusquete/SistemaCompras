using System;

namespace SistemaCompra.Domain.SolicitacaoCompraAggregate
{
    public interface ISolicitacaoCompraRepository
    {
        void Atualizar(SolicitacaoCompra solicitacaoCompra);
        void Excluir(SolicitacaoCompra solicitacaoCompra);
        SolicitacaoCompra Obter(Guid id);
        void Registrar(SolicitacaoCompra solicitacaoCompra);
    }
}
