namespace AulaInterface
{
    public class Notbook : ICamera
    {
        public string Nome { get ; set ; }

        public void TirarFoto()
        {
            Console.WriteLine("Tirando foto com o notbook");
        }
    }
}
