namespace AulaLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeUm = "Guilherme";
            string nomeDois = "Douglas";
            string nomeTres = "José";

            IList<string> listaNomes = new List<string>();
            listaNomes.Add(nomeUm);
            listaNomes.Add(nomeDois);
            listaNomes.Add(nomeTres);

            foreach (string nome in listaNomes)
            {
                Console.WriteLine(nome);
            }

            foreach (string nome in listaNomes)
            {
                if (nome == "Guilherme")
                {
                    Console.WriteLine("O nome Guilherme foi encontrado");
                }
            }

            listaNomes.Remove(nomeUm);
            Console.WriteLine("O nome Guilherme foi removido");

            foreach (string nome in listaNomes)
            {
                Console.WriteLine(nome);
            }

            IList<int> listaNumeros = new List<int>
            {
                5, 10, 20, 3, 7
            };

            foreach (int numero in listaNumeros)
            {
                Console.WriteLine($"Numero: {numero}");
            }

            IList<Pessoa> listaPessoas = new List<Pessoa>
            {
                new Pessoa
                {
                    Nome = "Luiz",
                    Sobrenome = "Borges",
                    Altura = 1.73,
                    DataNascimento = new DateTime(1997, 12, 4)
                },
                new Pessoa
                {
                    Nome = "Pedro",
                    Sobrenome = "Napar",
                    Altura = 1.75,
                    DataNascimento = new DateTime(2005, 4, 1)
                },
                new Pessoa
                {
                    Nome = "Pedro",
                    Sobrenome = "Vieira",
                    Altura = 1.80,
                    DataNascimento = new DateTime(2005, 4, 1)
                },
                new Pessoa
                {
                    Nome = "Bruno",
                    Sobrenome = "Isaac",
                    Altura = 1.99,
                    DataNascimento = new DateTime(2005, 4, 1)
                }
            };

            foreach (Pessoa pessoa in listaPessoas)
            {
                Console.WriteLine($"Nome da pessoa {pessoa.Nome}");
                Console.WriteLine($"Altura da pessoa {pessoa.Altura}");
            }

            Pessoa primeiraPessoa = listaPessoas.FirstOrDefault();

            Console.WriteLine($"Primeira pessoa encontrada {primeiraPessoa.Nome}");

            Pessoa pessoaPedro = listaPessoas.FirstOrDefault(pessoa => pessoa.Nome == "Pedro");

            Console.WriteLine($"Pessoa pedro {pessoaPedro.Nome} {pessoaPedro.Sobrenome}");

            Pessoa pessoaGuilherme = listaPessoas.FirstOrDefault(pessoa => pessoa.Nome == "Guilherme");

            //Console.WriteLine($"Pessoa Guilherme {pessoaGuilherme.Nome}");

            IEnumerable<Pessoa> pessoasFiltradasPorNome = listaPessoas.Where(pessoa => pessoa.Nome == "Pedro");

            Console.WriteLine("Pessoas somente com o nome Pedro");
            foreach (Pessoa pessoa in pessoasFiltradasPorNome)
            {
                Console.WriteLine($"Nome pessoa {pessoa.Nome} {pessoa.Sobrenome}");
            }

            IEnumerable<string> listaSomenteNomesPessoas = listaPessoas.Select(pessoa =>
            {
                return pessoa.Nome;
            });

            Console.WriteLine("Somente nomes das pessoas");
            foreach (string nome in listaSomenteNomesPessoas)
            {
                Console.WriteLine($"Somente nome {nome}");
            }

            IEnumerable<PessoaResponse> listaPessoasResponse = listaPessoas.Select(pessoa =>
            {
                return new PessoaResponse
                {
                    Nome = pessoa.Nome,
                    Sobrenome = pessoa.Sobrenome
                };
            });

            Console.WriteLine("Pessoas response");
            foreach(PessoaResponse pessoaResponse in listaPessoasResponse)
            {
                Console.WriteLine($"Nome {pessoaResponse.Nome}; Sobrenome {pessoaResponse.Sobrenome}");
            }

            IEnumerable<Pessoa> pessoasOrdenadas = listaPessoas.OrderBy(pessoa => pessoa.Nome);

            Console.WriteLine("Pessoas ordenadas");
            foreach (Pessoa pessoa in pessoasOrdenadas)
            {
                Console.WriteLine($"Nome {pessoa.Nome} {pessoa.Sobrenome}");
            }
        }
    }
}
