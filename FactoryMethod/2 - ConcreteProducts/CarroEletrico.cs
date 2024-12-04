using FactoryMethod.AbstractProducts;

namespace FactoryMethod.ConcreteProducts;

public class CarroEletrico : IVeiculo
{
    public void IniciarAluguel()
    {
        Console.WriteLine("Carro Elétrico alugado! Dirija com segurança!");
    }
}