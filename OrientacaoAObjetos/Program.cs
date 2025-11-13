namespace OrientacaoAObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Guilherme", "Walter", new DateTime(1999, 6, 17));

            Console.WriteLine($"Nome da pessoa é {pessoa.Nome}");
            Console.WriteLine($"Sobrenome da pessoa é {pessoa.Sobrenome}");
            pessoa.AtribuirAtivo(true);

            Console.WriteLine($"Pessoa ativa {pessoa.Ativo}");

            pessoa.Comunicar();

            Pessoa pessoa2 = new Pessoa("Douglas", "Walter", new DateTime(1994, 11, 20));

            Console.WriteLine($"Nome da pessoa2 é {pessoa2.Nome}");
            Console.WriteLine($"Sobrenome da pessoa2 é {pessoa2.Sobrenome}");
        }
    }
}
