using System;
using System.Collections.Generic;
using DecimoTerceiroDia;

namespace DecimoTerceiroDia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fisica usuario = new Fisica("Marcos Palladino");
            Console.WriteLine(usuario.NomePersonalizado());
            Fisica.SalvarInstancia(usuario);

            new Fisica("Marcos Palladino 1").Salvar();
            new Fisica("Marcos Palladino 2").Buscar();
            new Fisica("Marcos Palladino 3").Excluir();

            var lista = Fisica.BuscaPorNome("Marcos");
            foreach(var pessoa in lista)
            {
                Console.WriteLine(pessoa.Nome);
            }

            new Juridica("Marcos Palladino 1").Salvar();
            new Juridica("Marcos Palladino 2").Buscar("");
            new Juridica("Marcos Palladino 3").Excluir();

            var lista2 = Juridica.BuscaPorNome("Marcos");
            foreach (var pessoa in lista2)
            {
                Console.WriteLine(pessoa.Nome);
            }

            //new IAnimal()
            */

            Gato animal = new Gato() {Nome = "Teste nome"};
            try
            {
                animal.Andar();
            }
            catch (AnimalException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            
        }
    }
}
