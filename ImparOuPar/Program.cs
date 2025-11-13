namespace ImparOuPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para verificar se é impar ou par");

            string numeroInput = Console.ReadLine();

            ImparPar imparPar = new ImparPar();

            int validacao;

            if (int.TryParse(numeroInput, out validacao))
            {
                int numeroZeroUm = int.Parse(numeroInput);

                bool ehPar = imparPar.EhPar(numeroZeroUm);

                if (ehPar)
                {
                    Console.WriteLine($"Número informado: {numeroZeroUm} é par");
                }
                else
                {
                    Console.WriteLine($"Número informado: {numeroZeroUm} é impar");
                }
            }
            else
            {
                Console.WriteLine("Número informado não é válido");
            }
        }
    }
}
