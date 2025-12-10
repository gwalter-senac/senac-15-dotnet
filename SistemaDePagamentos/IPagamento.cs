namespace SistemaPagamentos
{
    public interface IPagamento
    {
        double ValorFinal { get; set; }

        void Pagar(double valor);
    }
}
