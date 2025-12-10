namespace AulaInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();
            Notbook notbook = new Notbook();

            IList<ICamera> cameras = new List<ICamera>
            {
                notbook, celular
            };

            foreach (ICamera camera in cameras)
            {
                camera.TirarFoto();
            }
        }
    }
}
