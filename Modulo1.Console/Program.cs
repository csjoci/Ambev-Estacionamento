

using Modulo1.Console.Entidades;
using static Modulo1.Console.Entidades.Veiculo;

//Herança com Veiculo
Veiculo veiculo = new Veiculo("123", "fusca", "ford", "azul");
veiculo.MostrarDetalhes();

Carro carro = new Carro("123", "fusca", "ford", "azul");
carro.MostrarDetalhes();