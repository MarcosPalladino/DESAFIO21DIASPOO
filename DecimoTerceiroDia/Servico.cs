using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DecimoQuintoDia
{
    public class Servico
    {
        public static List<Fisica> TabelaFisica = new List<Fisica>();
        public static List<Juridica> TabelaJuridica = new List<Juridica>();
        private IPessoa pessoa;

        public Servico(IPessoa iPpessoa)
        {
            this.pessoa = iPpessoa;
        }

        public Servico() { }

        public static string ConectionString()
        {
            return ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }

        public static T Todos<T>()
        {
            string sql;

            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConectionString()))
            {
                if(typeof(T) == typeof(List<Juridica>))
                    sql = "select * from pessoa where tipo = 'J' and id is not null";
                else
                    sql = "select * from pessoa where tipo = 'F' and id is not null";

                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                    {
                        a.Fill(table);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if(typeof(T) == typeof(List<Juridica>))
            {
                var listaJuridica = new List<Juridica>();

                foreach (DataRow linha in table.Rows)
                {
                    listaJuridica.Add(new Juridica()
                    {
                        Nome = linha["nome"].ToString(),
                        Id = Convert.ToInt32(linha["id"]),
                        Endereco = linha["endereco"].ToString(),
                        Cnpj = linha["cpfcnpj"].ToString()
                    });
                }
                return (T)Convert.ChangeType(listaJuridica, typeof(T));
            }
            else
            {
                var listaFisica = new List<Fisica>();

                foreach (DataRow linha in table.Rows)
                {
                    listaFisica.Add(new Fisica()
                    {
                        Nome = linha["nome"].ToString(),
                        Id = Convert.ToInt32(linha["id"]),
                        Endereco = linha["endereco"].ToString(),
                        Cpf = linha["cpfcnpj"].ToString()
                    });
                }
                return (T)Convert.ChangeType(listaFisica, typeof(T));
            }
        }

        public static void Salvar(IPessoa pessoa)
        {
            using (SqlConnection conn = new SqlConnection(ConectionString()))
            {
                string sql = "insert into Pessoas (id, nome, endereco, tipo, cpfcnpj) values ( @id, @nome, @endereco, @tipo, @cpfcnpj)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = pessoa.Id;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = pessoa.Nome;

                cmd.Parameters.Add("@endereco", SqlDbType.VarChar);
                cmd.Parameters["@endereco"].Value = pessoa.Endereco;

                cmd.Parameters.Add("@tipo", SqlDbType.VarChar);
                cmd.Parameters["@tipo"].Value = pessoa.GetType().Name.Substring(0, 1);

                cmd.Parameters.Add("@cpfcnpj", SqlDbType.VarChar);
                cmd.Parameters["@cpfcnpj"].Value = pessoa.getDocumento();

                try
                {
                    conn.Open();
                    cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static T ProcurarPorId<T>(int id)
        {
            if(typeof(T) == typeof(Fisica))
            {
                throw new Exception("Não implementado");
                //return (T)Convert.ChangeType(new Servico(new Fisica()).Todos(), typeof(T));
            }
            else
            {
                throw new Exception("Não implementado");
            }
        }




        public static void Excluir(IPessoa pessoa)
        {
            using (SqlConnection conn = new SqlConnection(ConectionString()))
            {
                string sql = "delete from pessoas where id = " + pessoa.Id;

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
