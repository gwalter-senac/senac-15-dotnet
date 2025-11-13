namespace OrientacaoAObjetos
{
    public class Pessoa
    {
        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public bool Ativo { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public double Altura { get; set; }

        public Pessoa(string nome, string sobrenome, DateTime dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
        }

        public void Comunicar()
        {
            Console.WriteLine("Olá, tudo bem?");
        }

        public void AtribuirAtivo(bool ativo)
        {
            Ativo = ativo;
        }
    }
}
