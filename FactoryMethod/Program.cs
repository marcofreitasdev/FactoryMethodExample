using FactoryMethod.AbstractFactory;
using FactoryMethod.ConcreteFactories;

Console.WriteLine("Factory Method Pattern Exemplo: Aluguel de Veículos\n");

Console.WriteLine("Escolha o veículo que deseja alugar:");
Console.WriteLine("1 - Patinete");
Console.WriteLine("2 - Bicicleta");
Console.WriteLine("3 - Carro Elétrico");

Console.Write("Digite o número correspondente ao veículo: ");

string? input = Console.ReadLine();

AluguelService? aluguelService = null;

switch (input)
{
    case "1":
        aluguelService = new AluguelPatineteService();
        break;
    case "2":
        aluguelService = new AluguelBicicletaService();
        break;
    case "3":
        aluguelService = new AluguelCarroEletricoService();
        break;
    default:
        Console.WriteLine("Opção inválida. Por favor, escolha um número válido.");
        return;
}

aluguelService.IniciarProcessoAluguel();