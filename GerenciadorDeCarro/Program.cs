namespace GerenciadorDeCarro
{
    public class Program
    {
        static void Main(string[] args)
        {
            GerenciadorCarros gerenciador = new GerenciadorCarros();
            bool continuar = true;

            Console.WriteLine("=== Sistema de Gerenciamento de Carros ===");

            while (continuar)
            {
                Console.WriteLine("\n1 - Cadastrar carro");
                Console.WriteLine("2 - Alterar preço do carro");
                Console.WriteLine("3 - Listar carros");
                Console.WriteLine("4 - Calcular média de preços");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                    gerenciador.AdicionarCarro();
                else if (opcao == "2")
                    gerenciador.AlterarPreco();
                else if (opcao == "3")
                    gerenciador.ListarCarros();
                else if (opcao == "4")
                    gerenciador.CalcularMediaPrecos();
                else if (opcao == "5")
                    continuar = false;
                else
                    Console.WriteLine("Opção inválida!");
            }
        }
    }

}
