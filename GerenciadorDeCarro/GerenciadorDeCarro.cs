namespace GerenciadorDeCarro
{
    public class GerenciadorCarros
    {
        private List<Carro> carros = new();

        public void AdicionarCarro()
        {
            Console.Write("Digite a marca: ");
            string marca = Console.ReadLine();

            Console.Write("Digite o modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Digite o preço: ");
            double preco = Convert.ToInt32(Console.ReadLine());

            var carro = new Carro(marca, modelo, preco);
            carros.Add(carro);

            Console.WriteLine("Carro cadastrado com sucesso!");
        }

        public void AlterarPreco()
        {
            Console.Write("Digite o modelo do carro: ");
            string modelo = Console.ReadLine();

            var carro = carros.Find(c => c.Modelo == modelo);

            if (carro == null)
            {
                Console.WriteLine("Carro não encontrado!");
                return;
            }

            Console.Write("Digite o novo preço: ");
            double novoPreco = double.Parse(Console.ReadLine());

            if (novoPreco < 0)
                carro.Preco = 0;
            else
                carro.Preco = novoPreco;

            Console.WriteLine("Preço atualizado!");
        }

        public void ListarCarros()
        {
            foreach (var carro in carros)
            {
                carro.Exibir();
                Console.WriteLine("--------------------");
            }
        }

        public void CalcularMediaPrecos()
        {
            double soma = 0;
            for (int i = 1; i <= carros.Count; i++)
            {
                soma += carros[i].Preco;
            }

            double media = soma / carros.Count;
            Console.WriteLine($"Média de preços: R${media}");
        }
    }
}
