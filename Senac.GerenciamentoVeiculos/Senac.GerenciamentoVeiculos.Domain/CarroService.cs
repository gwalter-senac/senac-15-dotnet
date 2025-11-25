

namespace Senac.GerenciamentoVeiculos.Domain
{
    public class CarroService : ICarroService
    {
        private static IList<Carro> carros = new List<Carro>
            {
                new Carro
                {
                    Id = 1,
                    Marca = "Honda",
                    Modelo = "City",
                    Ano = 2015
                },
                new Carro
                {
                    Id = 2,
                    Marca = "Honda",
                    Modelo = "Civic",
                    Ano = 2016
                },
                new Carro
                {
                    Id = 3,
                    Marca = "Fiat",
                    Modelo = "Uno",
                    Ano = 1999
                }
            };

        public void AtualizarCarro(int id, Carro carro)
        {
            Carro carroEncontrado = carros.FirstOrDefault(c => c.Id == id);

            carroEncontrado.Cor = carro.Cor;
            carroEncontrado.Placa = carro.Placa;
            carroEncontrado.Preco = carro.Preco;
        }

        public void CadastrarCarro(Carro carro)
        {
            carros.Add(carro);
        }

        public void DeletarCarro(int id)
        {
            Carro carro = carros.FirstOrDefault(c => c.Id == id);

            carros.Remove(carro);
        }

        public Carro ObterCarro(int id)
        {
            Carro carro = carros.FirstOrDefault(c => c.Id == id);

            return carro;
        }

        public IList<Carro> ObterCarros()
        {
            return carros;
        }
    }
}
