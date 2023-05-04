// See https://aka.ms/new-console-template for more information
using testandoIde;

var carros = new List<Carro>();

carros.Add(new Carro
{
    Ano = 2014,
    Cor = "Azul",
    Modelo = "Corolla",
    UnicoDono = false 
});

carros.Add(new Carro
{
    Ano = 2022,
    Cor = "Preto",
    Modelo = "Camaro",
    UnicoDono = true
});

carros.Add(new Carro
{
    Ano = 1968,
    Cor = "Amarelo",
    Modelo = "Corsa",
    UnicoDono = false
});

Console.WriteLine("Veja os nossos Carros a venda");
Console.WriteLine("Descreva seu modelo");

foreach (var carro in carros)  //vai rodar pra cada carro q tiver na lista de carros 
{
    Console.WriteLine(carro.Ano);
    Console.WriteLine(carro.Cor);
    Console.WriteLine(carro.Modelo);
    Console.WriteLine(carro.UnicoDono);

}
carros.FirstOrDefault(carro => carro.Modelo == "Camaro");

/*
 1 - Fazer a lista ficar bonita
 2 - Opção pra escolha do carro
 3 - Mostrar as ações do carro
 4 - executar a ação escolhida
 
 */