using FactoryMethod.AbstractFactory;
using FactoryMethod.AbstractProducts;
using FactoryMethod.ConcreteProducts;

namespace FactoryMethod.ConcreteFactories;

public class AluguelBicicletaService : AluguelService
{
    public override IVeiculo CriarVeiculo()
    {
        return new Bicicleta();
    }
}