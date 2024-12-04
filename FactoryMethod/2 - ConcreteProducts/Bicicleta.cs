using FactoryMethod.AbstractProducts;

namespace FactoryMethod.ConcreteProducts;

public class Bicicleta : IVeiculo
{
    public void IniciarAluguel()
    {
        Console.WriteLine("Bicicleta alugada! Pedale com segurança!");
    }
}