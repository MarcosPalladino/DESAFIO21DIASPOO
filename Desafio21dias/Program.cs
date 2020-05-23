using System;
using System.Collections.Generic;

namespace Desafio21dias
{
    class Program
    {
        static void Main(string[] args)
        {
            Receita chocolate = new Receita();
            chocolate.Peso = 1.5;
            chocolate.Tamanho = "GRANDE";
            chocolate.Preco = 35.00;
            chocolate.Nome = "Bolo de chocolate";

            Receita morango = new Receita();
            morango.Peso = 1.7;
            morango.Tamanho = "MEDIO";
            morango.Preco = 25.00;
            morango.Nome = "Bolo de morango";

            Receita abacaxi = new Receita();
            abacaxi.Peso = 2.5;
            abacaxi.Tamanho = "PEQUENO";
            abacaxi.Preco = 45.00;
            abacaxi.Nome = "Bolo de abacaxi";

            // teste Objeto
            List<Object> objetos = new List<Object>();

            List<Carro> frota = new List<Carro>();
            Carro veiculo = new Carro();
            veiculo.Marca = "TOYOTA";
            veiculo.Modelo = "COROLLA";
            veiculo.Cor = "AZUL";
            veiculo.ValorFipe = 45000.00;
            frota.Add(veiculo);

            // teste Objeto
            objetos.Add(veiculo);

            veiculo = new Carro();
            veiculo.Marca = "CITROEN";
            veiculo.Modelo = "C3";
            veiculo.Cor = "VERMELHO";
            veiculo.ValorFipe = 25600.00;
            frota.Add(veiculo);

            // teste Objeto
            objetos.Add(veiculo);

            veiculo = new Carro();
            veiculo.Marca = "FIAT";
            veiculo.Modelo = "UNO";
            veiculo.Cor = "PRATA";
            veiculo.ValorFipe = 7600.00;
            frota.Add(veiculo);

            // teste Objeto
            objetos.Add(veiculo);

            veiculo = new Carro();
            frota.Add(veiculo);

            // teste Objeto
            objetos.Add(veiculo);

            foreach (Carro _carro in frota)
                System.Console.WriteLine(_carro.Mostrar());


            List<Animal> animais = new List<Animal>();
            var animal = new Animal();
            animal.Nome = "PATO";
            animal.Sexo = "MACHO";
            animal.Tipo = "AVE";
            animais.Add(animal);

            // teste Objeto
            objetos.Add(animal);

            animal = new Animal();
            animal.Nome = "TUBARAO";
            animal.Sexo = "FEMEA";
            animal.Tipo = "PEIXE";
            animais.Add(animal);
            
            // teste Objeto
            objetos.Add(animal);

            animal = new Animal();
            animal.Nome = "TARTARUGA";
            animal.Sexo = "MACHO";
            animal.Tipo = "REPTIL";
            animais.Add(animal);

            // teste Objeto
            objetos.Add(animal);

            foreach (Animal _animal in animais)
                System.Console.WriteLine(_animal.Mostrar());


            List<Televisao> aparelhos = new List<Televisao>();
            var aparelho = new Televisao();
            aparelho.Marca = "SAMSUNG";
            aparelho.Tamanho = "40 POLEGADAS";
            aparelho.Preco = 1500.00;
            aparelho.Caracteristica = "4K FULL HD";
            aparelhos.Add(aparelho);

            // teste Objeto
            objetos.Add(aparelhos);


            aparelho = new Televisao();
            aparelho.Marca = "PHILIPS";
            aparelho.Tamanho = "60 POLEGADAS";
            aparelho.Preco = 3500.00;
            aparelho.Caracteristica = "OLED";
            aparelhos.Add(aparelho);

            // teste Objeto
            objetos.Add(aparelhos);

            aparelho = new Televisao();
            aparelho.Marca = "AOC";
            aparelho.Tamanho = "32 POLEGADAS";
            aparelho.Preco = 900.00;
            aparelho.Caracteristica = "ULTRA HD";
            aparelhos.Add(aparelho);

            // teste Objeto
            objetos.Add(aparelhos);

            foreach (Televisao _tv in aparelhos)
                System.Console.WriteLine(_tv.Mostrar());

            //foreach (Object objeto in objetos)
            //    System.Console.WriteLine(objeto.Mostrar());

            Console.ReadKey();
        }
    }
}
