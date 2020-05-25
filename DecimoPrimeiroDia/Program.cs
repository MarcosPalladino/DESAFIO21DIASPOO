using System;

namespace DecimoQuintoDia
{
    class Program
    {
        static void Main(string[] args)
        {
            var fisicas = new Fisica().Todos();
            var juridicas = new Juridica().Todos();

            foreach(var item in fisicas)
            {
                Console.WriteLine(item);
            }

            foreach (var item in juridicas)
            {
                Console.WriteLine(item);
            }

            new Fisica() { Nome = "Marcos Palladino", Endereco = "Rua y, 25", Id = 1 }.Salvar();
            new Juridica() { Nome = "Empresa Danilo", Endereco = "Rua x, 25", Id = 2 }.Salvar();
        }
    }
}
