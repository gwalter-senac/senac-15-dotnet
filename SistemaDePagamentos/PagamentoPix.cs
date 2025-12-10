namespace SistemaPagamentos
{
    public class PagamentoPix : IPagamento
    {
        public double ValorFinal { get; set; }

        public void Pagar(double valor)
        {
            ValorFinal = valor - valor * 0.07;

            Console.WriteLine($"Processando pagamento de R$ {ValorFinal:F2} no pix...");
        }
    }
}
