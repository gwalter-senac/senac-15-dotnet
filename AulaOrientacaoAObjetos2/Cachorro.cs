namespace AulaOrientacaoAObjetos2
{
    public class Cachorro : Animal
    {
        public string Raca { get; set; }

        public char Genero { get; set; }

        public bool Adestrado { get; set; }

        public override void SeComunicar()
        {
            Console.WriteLine("Au au");
        }
    }
}
