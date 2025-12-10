namespace SistemaPagamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool deveContinuar = true;
            IList<IPagamento> pagamentos = new List<IPagamento>();

            while (deveContinuar)
            {
                Console.WriteLine("--- Sistema Pagamentos ---");

                Console.WriteLine("Escolha uma opção para seguir");
                Console.WriteLine("1 - Registrar pagamento\n2 - Listar pagamentos\n0 - Sair");

                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("Qual é a forma de pagamento?");
                    Console.WriteLine("1 - Cartao de credito (+10%)\n2 - Boleto (-5%)\n3 - Pix (-7%)");
                    string formaPagamento = Console.ReadLine();

                    Console.WriteLine("Digite o valor do pagamento");
                    string valorPagoInput = Console.ReadLine();

                    double valorPago = 0;
                    try
                    {
                        valorPago = double.Parse(valorPagoInput);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Valor {valorPago} inválido. Insira um valor númerico válido.");
                    }

                    IPagamento pagamento = null;
                    if (formaPagamento == "1")
                    {
                        pagamento = new PagamentoCartaoCredito();
                    }
                    else if (formaPagamento == "2")
                    {
                        pagamento = new PagamentoBoleto();
                    }
                    else if (formaPagamento == "3")
                    {
                        pagamento = new PagamentoPix();
                    }
                    else
                    {
                        if (pagamento == null)
                        {
                            Console.WriteLine("Opção de pagamento inválida");
                            continue;
                        }
                    }

                    pagamento.Pagar(valorPago);
                    pagamentos.Add(pagamento);
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("--- Lista pagamentos ---");
                    foreach (IPagamento pagamento in pagamentos)
                    {
                        Console.WriteLine($"{pagamento.GetType().Name} no valor de {pagamento.ValorFinal}");
                    }
                }
                else if (opcao == "0")
                {
                    deveContinuar = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
        }
    }
}
