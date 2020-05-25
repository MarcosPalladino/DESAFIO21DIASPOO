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
        public static string ConectionString()
        {
            return ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }

        public List<IPessoa> Todos()
        {
            var lista = new List<IPessoa>();
            string sql;

            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConectionString()))
            {
                if(pessoa.GetType() == typeof(Juridica))
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

            foreach(DataRow linha in table.Rows)
            {
                if(linha["tipo"].ToString() == "J")
                {
                    lista.Add(new Juridica() 
                    { Nome = linha["nome"].ToString(),
                        Id = Convert.ToInt32(linha["id"]),
                        Endereco = linha["endereco"].ToString(),
                        Cnpj = linha["cpfcnpj"].ToString()
                    });
                }
                else
                {
                    lista.Add(new Fisica()
                    {
                        Nome = linha["nome"].ToString(),
                        Id = Convert.ToInt32(linha["id"]),
                        Endereco = linha["endereco"].ToString(),
                        Cpf = linha["cpfcnpj"].ToString()
                    });
                }
            }
            return lista;
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
