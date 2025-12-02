namespace AulaOrientacaoAObjetos2
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public abstract void SeComunicar();
    }
}
