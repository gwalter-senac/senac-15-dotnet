namespace OrientacaoAObjetos
{
    public class Cachorro
    {
        public string Nome { get; set; }

        public string Raca { get; set; }

        public string Cor { get; set; }

        public double Altura { get; set; }

        public void Comunicar()
        {
            Console.WriteLine("Au au");
        }
    }
}
