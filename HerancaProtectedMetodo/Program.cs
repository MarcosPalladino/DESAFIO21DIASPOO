using System;

namespace HerancaProtectedMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var fisica = new Fisica();
            fisica.Nome = "Marcos Palladino";
            fisica.Endereco = "Rua x, 21";
            fisica.Cpf = "120.252.525-96";
            fisica.Rg = "20.252.252-52";

            System.Console.WriteLine(String.Format("{0} - {1} - {2} - {3}", fisica.Nome, fisica.Endereco, fisica.Cpf, fisica.Rg));

            var juridica = new Juridica();
            juridica.Nome = "AMP SERVICOS";
            juridica.Endereco = "Rua SDFASDF, 35";
            juridica.Cnpj = "01.020.252/0525-96";
            juridica.NomeFantasia = "AMP SERV";

            System.Console.WriteLine(String.Format("{0} - {1} - {2} - {3}", juridica.Nome, juridica.Endereco, juridica.Cnpj, juridica.NomeFantasia));

            System.Console.ReadKey();

            var dados = Fisica.Base;
            */

            Fisica usuario = new Fisica("Marcos Palladino");
            Console.WriteLine(usuario.Nome);
            Console.WriteLine(usuario.NomePersonalizadoProtected());
            Console.WriteLine(usuario.NomePersonalizadoVirtual());

            System.Console.ReadKey();
        }
    }
}
