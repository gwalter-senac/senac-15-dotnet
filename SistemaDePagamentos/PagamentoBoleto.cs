namespace SistemaPagamentos
{
    public class PagamentoBoleto : IPagamento
    {
        public double ValorFinal { get; set; }

        public void Pagar(double valor)
        {
            ValorFinal = valor - valor * 0.05;

            Console.WriteLine($"Processando pagamento de R$ {ValorFinal:F2} no boleto...");
        }
    }
}
