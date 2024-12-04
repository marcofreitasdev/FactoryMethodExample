using FactoryMethod.AbstractFactory;
using FactoryMethod.AbstractProducts;
using FactoryMethod.ConcreteProducts;

namespace FactoryMethod.ConcreteFactories;

public class AluguelPatineteService : AluguelService
{
    public override IVeiculo CriarVeiculo()
    {
        return new Patinete();
    }
}