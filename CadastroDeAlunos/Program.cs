namespace CadastroDeAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool deveContinuar = true;
            IList<Aluno> alunos = new List<Aluno>();

            while (deveContinuar)
            {
                Console.WriteLine("Bem vindo ao cadastro de alunos");
                Console.WriteLine("Escolha uma opção para continuar");
                Console.WriteLine("1 - Adicionar\n2 - Remover\n3 - Listar\n0 - Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o cpf do aluno");
                        string cpfAlunoASerAdicionado = Console.ReadLine();

                        bool alunoJaExiste = alunos.Any(aluno => aluno.Cpf == cpfAlunoASerAdicionado);

                        if (alunoJaExiste)
                        {
                            Console.WriteLine($"Já existe um aluno cadastrado com o CPF {cpfAlunoASerAdicionado}");
                            break;
                        }

                        Console.WriteLine("Digite o nome do aluno:");
                        string nomeAlunoASerAdicionado = Console.ReadLine();

                        Console.WriteLine("Digite a data de nascimento do aluno: (YYYY-MM-DD)");
                        string dataNascimentoAlunoASerAdicionado = Console.ReadLine();

                        bool isDataValida = DateTime.TryParse(dataNascimentoAlunoASerAdicionado, out DateTime dataNascimentoResultado);

                        Aluno aluno = new Aluno();
                        if (isDataValida)
                        {
                            aluno.Cpf = cpfAlunoASerAdicionado;
                            aluno.Nome = nomeAlunoASerAdicionado;
                            aluno.DataNascimento = dataNascimentoResultado;
                        }
                        else
                        {
                            Console.WriteLine($"Data de nascimento {dataNascimentoAlunoASerAdicionado} é inválida");
                            break;
                        }

                        alunos.Add(aluno);

                        Console.WriteLine($"Aluno {nomeAlunoASerAdicionado} foi adicionado");
                        break;

                    case "2":
                        Console.WriteLine("Digite o Cpf do aluno a ser removido:");
                        string cpfAlunoASerRemovido = Console.ReadLine();
                        Aluno alunoARemover = alunos.FirstOrDefault(aluno => aluno.Cpf == cpfAlunoASerRemovido);

                        if (alunoARemover != null)
                        {
                            alunos.Remove(alunoARemover);
                            Console.WriteLine($"Aluno {alunoARemover.Nome} foi removido.");
                        }
                        else
                        {
                            Console.WriteLine($"Aluno com o Cpf {cpfAlunoASerRemovido} não foi encontrado.");
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Lista de alunos");
                        foreach (Aluno alunoAExibir in alunos)
                        {
                            int idade = DateTime.Now.Year - alunoAExibir.DataNascimento.Year;
                            Console.WriteLine($"Aluno: {alunoAExibir.Nome}; CPF: {alunoAExibir.Cpf}; Idade: {idade}");
                        }

                        break;
                    case "0":
                        deveContinuar = false;
                        Console.Clear();
                        Console.WriteLine("Fechando programa...");

                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
