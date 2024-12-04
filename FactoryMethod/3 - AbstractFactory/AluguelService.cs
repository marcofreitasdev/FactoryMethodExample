using FactoryMethod.AbstractProducts;

namespace FactoryMethod.AbstractFactory;

public abstract class AluguelService
{
    public abstract IVeiculo CriarVeiculo();

    public void IniciarProcessoAluguel()
    {
        Console.WriteLine("Iniciando processo de aluguel...");
        var vehicle = CriarVeiculo();
        vehicle.IniciarAluguel();
        Console.WriteLine("Aluguel finalizado com sucesso.\n");
    }
}