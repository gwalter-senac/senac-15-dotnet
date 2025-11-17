namespace GerenciadorDeCarro
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public double Preco;

        public Carro(string marca, string modelo, double preco)
        {
            Marca = marca;
            modelo = modelo;
            Preco = preco;
        }

        public void Exibir()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Preço: R$" + Preco.ToString("F2"));
        }
    }
}
