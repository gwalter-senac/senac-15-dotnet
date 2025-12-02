namespace AulaOrientacaoAObjetos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = "Guilherme",
                Cpf = "03890096012",
                DataNascimento = new DateTime(1999, 6, 17),
                Telefone = "999887766"
            };

            Console.WriteLine($"O cpf da pessoa é {pessoa.Cpf}");

            pessoa.SeComunicar();

            Cachorro cachorro = new Cachorro
            {
                Nome = "Junior",
                Adestrado = true,
                DataNascimento = new DateTime(2016, 1, 1),
                Genero = 'M',
                Raca = "Pinscher"
            };

            Console.WriteLine($"O nome do cachorro é {cachorro.Nome} e raça é {cachorro.Raca}");
            cachorro.SeComunicar();

            Console.WriteLine("\nExemplo de polimorfismo");
            List<Animal> animais = new List<Animal>
            {
                pessoa, cachorro
            };

            foreach (Animal animal in animais)
            {
                animal.SeComunicar();
            }
        }
    }
}
