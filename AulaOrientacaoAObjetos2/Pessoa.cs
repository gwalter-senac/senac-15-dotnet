namespace AulaOrientacaoAObjetos2
{
    public class Pessoa : Animal
    {
        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public override void SeComunicar()
        {
            Console.WriteLine($"Olá, o meu nome é {Nome}");
        }
    }
}