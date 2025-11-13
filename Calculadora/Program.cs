namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            bool deveContinuar = true;

            while (deveContinuar)
            {
                Console.WriteLine("----------------Calculadora----------------");

                Console.WriteLine("Escolha uma opção:\n1 - Iniciar calculadora\n0 - Sair");
                string opcaoInicial = Console.ReadLine();

                if (opcaoInicial == "0")
                {
                    deveContinuar = false;
                    break;
                }

                Console.WriteLine($"Digite o primeiro valor:");
                string numeroUmInput = Console.ReadLine();

                double numeroUm = 0;
                try
                {
                    numeroUm = double.Parse(numeroUmInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"O valor {numeroUmInput} não é um valor numérico válido");
                    break;
                }

                Console.WriteLine($"Digite o segundo valor:");
                string numeroDoisInput = Console.ReadLine();

                double numeroDois = 0;
                try
                {
                    numeroDois = double.Parse(numeroDoisInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"O valor {numeroDoisInput} não é um valor numérico válido");
                    break;
                }

                Console.WriteLine("Digite a operação:\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir");
                string operacaoInput = Console.ReadLine();

                double resultado = 0;
                if (operacaoInput == "1")
                {
                    resultado = calculadora.Somar(numeroUm, numeroDois);
                }
                else if (operacaoInput == "2")
                {
                    resultado = calculadora.Subtrair(numeroUm, numeroDois);
                }
                else if (operacaoInput == "3")
                {
                    resultado = calculadora.Multiplicar(numeroUm, numeroDois);
                }
                else if (operacaoInput == "4")
                {
                    resultado = calculadora.Dividir(numeroUm, numeroDois);
                }
                else
                {
                    Console.WriteLine($"A operação escolhida é inválida.");
                    break;
                }

                Console.WriteLine($"Resultado operação {resultado}");
            }
        }
    }
}
