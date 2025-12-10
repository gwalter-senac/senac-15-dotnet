namespace AulaInterface
{
    public class Celular : ICamera
    {
        public string Nome { get ; set ; }

        public void TirarFoto()
        {
            Console.WriteLine("Tirando foto com o celular");
        }
    }
}
