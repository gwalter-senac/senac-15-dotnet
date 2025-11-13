namespace ContadorERaizQuadrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador de 1 a 10\n");
            Console.WriteLine("Número\t Raiz Quadrada");
            Console.WriteLine("----------------------");

            for (int i = 1; i <= 10; i++)
            {
                double raiz = Math.Sqrt(i);

                Console.WriteLine($"{i}\t{raiz:F2}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Contagem concluída");
        }
    }
}
