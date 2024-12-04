using FactoryMethod.AbstractFactory;
using FactoryMethod.AbstractProducts;
using FactoryMethod.ConcreteProducts;

namespace FactoryMethod.ConcreteFactories;

public class AluguelCarroEletricoService : AluguelService
{
    public override IVeiculo CriarVeiculo()
    {
        return new CarroEletrico();
    }
}