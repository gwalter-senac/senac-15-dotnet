namespace Senac.GerenciamentoVeiculos.Domain
{
    public interface ICarroService
    {
        IList<Carro> ObterCarros();

        Carro ObterCarro(int id);

        void CadastrarCarro(Carro carro);

        void DeletarCarro(int id);

        void AtualizarCarro(int id, Carro carro);
    }
}
