using FactoryMethod.AbstractProducts;

namespace FactoryMethod.ConcreteProducts;

public class Patinete : IVeiculo
{
    public void IniciarAluguel()
    {
        Console.WriteLine("Patinete alugado! Divirta-se com segurança!");
    }
}