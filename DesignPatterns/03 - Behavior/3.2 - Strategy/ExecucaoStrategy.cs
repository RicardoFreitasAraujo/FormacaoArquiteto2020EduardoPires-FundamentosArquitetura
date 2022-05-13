using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Behavior._3._2___Strategy
{
    public class ExecucaoStrategy
    {
        public static void Executar()
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto { Nome = "Tenis Adidas", Valor = new Random().Next(500)},
                new Produto { Nome = "Camisa Boliche", Valor = new Random().Next(500)},
                new Produto { Nome = "Raquete Tenis", Valor = new Random().Next(500)},
            };

            Pedido pedido = new Pedido
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var meioPagamentoCredito = new Pagamento
            {
                MeioPagamento = MeioPagamento.CartaoCredito,
                CartaoCredito = "5555 2222 5555 9999"
            };

            var meioPagamentoBoleto = new Pagamento
            {
                MeioPagamento = MeioPagamento.Boleto
            };

            var meioPagamentoTransferencia = new Pagamento
            {
                MeioPagamento = MeioPagamento.TransferenciaBancaria,
                CartaoCredito = "5555 2222 5555 9999"
            };

            #region Forma Simples

            #endregion




        }
    }
}
