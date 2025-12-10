namespace SistemaPagamentos
{
    public class PagamentoCartaoCredito : IPagamento
    {
        public double ValorFinal { get; set; }

        public void Pagar(double valor)
        {
            ValorFinal = valor + valor * 0.10;

            Console.WriteLine($"Processando pagamento de R$ {ValorFinal:F2} no cartão de crédito...");
        }
    }
}
