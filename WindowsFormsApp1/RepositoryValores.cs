using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RepositoryValores
    {
        MySqlConnection objcon;
        MySqlCommand cmd;


        public RepositoryValores()
        {
            try
            {
                GC.Collect(2);
                objcon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=pousadabetania;Allow User Variables=True");
                objcon.Open();

                // objcon.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("nao conectou" + error);
            }

        }

        public void VerifyIfconnectedToDataBase()
        {
            try
            {
                GC.Collect(2);
                objcon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=pousadabetania;Allow User Variables=True");
                objcon.Open();
                MessageBox.Show("conectado");
                
            }
            catch (Exception error)
            {
                MessageBox.Show("nao conectou" + error);
            }
        }

        public Valores ConsultarSomaDosValores(DateTime data1, DateTime data2)
        {
            cmd = new MySqlCommand("SELECT sum(valor_casal) TotalCasal,sum(valor_solteiro) TotalSolteiro,sum(valor_triplo) TotalTriplo," +
                      "sum(valor_quadruplo) TotalQuadruplo,sum(valor_quintuplo) TotalQuintuplo,sum(valor_criancaDe03A06) TotalCrianca03A06," +
                      "sum(valor_criancaDe07A10) TotalCrianca07A10 FROM valores where data between @data1 and @data2");
            cmd.Connection = objcon;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@data1", data1.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@data2", data2.ToString("yyyy-MM-dd HH:mm:ss"));
            //executa o comando
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            var valores = new Valores()
            {

                TotalCasal = reader.GetFieldValue<double>(reader.GetOrdinal("TotalCasal")),
                TotalSolteiro = reader.GetFieldValue<double>(reader.GetOrdinal("TotalSolteiro")),
                TotalTriplo = reader.GetFieldValue<double>(reader.GetOrdinal("TotalTriplo")),
                TotalQuadruplo = reader.GetFieldValue<double>(reader.GetOrdinal("TotalQuadruplo")),
                TotalQuintuplo = reader.GetFieldValue<double>(reader.GetOrdinal("TotalQuintuplo")),
                TotalCrianca03A06 = reader.GetFieldValue<double>(reader.GetOrdinal("TotalCrianca03A06")),
                TotalCrianca07A10 = reader.GetFieldValue<double>(reader.GetOrdinal("TotalCrianca07A10"))
            };
            reader.Close();
            return valores;

        }


        public Valores carregarValoresParaCrud(DateTime data)
        {
            cmd = new MySqlCommand("select(select count(*) from valores where data = @data)as numero_linhas");
            cmd.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd HH:mm:ss"));

            cmd.Connection = objcon;
            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
            { return null; }


            cmd.CommandText = "SELECT data data, sum(valor_casal)TotalCasal, sum(valor_solteiro)TotalSolteiro, sum(valor_triplo)TotalTriplo," +
                          " sum(valor_quadruplo)TotalQuadruplo, sum(valor_quintuplo)TotalQuintuplo, sum(valor_criancaDe03A06)TotalCrianca03A06," +
                        "sum(valor_criancaDe07A10)TotalCrianca07A10  FROM valores where data = @data";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd HH:mm:ss"));

            //executa o comando
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();



            reader.Read();

            var valores = new Valores()
            {
                Data = reader.GetFieldValue<DateTime>(reader.GetOrdinal("data")),
                TotalCasal = reader.GetFieldValue<double>(reader.GetOrdinal("TotalCasal")),
                TotalSolteiro = reader.GetFieldValue<double>(reader.GetOrdinal("TotalSolteiro")),
                TotalTriplo = reader.GetFieldValue<double>(reader.GetOrdinal("TotalTriplo")),
                TotalQuadruplo = reader.GetFieldValue<double>(reader.GetOrdinal("TotalQuadruplo")),
                TotalQuintuplo = reader.GetFieldValue<double>(reader.GetOrdinal("TotalQuintuplo")),
                TotalCrianca03A06 = reader.GetFieldValue<double>(reader.GetOrdinal("TotalCrianca03A06")),
                TotalCrianca07A10 = reader.GetFieldValue<double>(reader.GetOrdinal("TotalCrianca07A10"))
            };
            reader.Close();
            return valores;



        }
        public void UpdateValoresNoDataBase(Valores Valores)
        {
            cmd = new MySqlCommand("select(select count(*) from valores where data = @data)as numero_linhas");
            cmd.Parameters.AddWithValue("@data", Valores.Data.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Connection = objcon;
            int resultado = Convert.ToInt32(cmd.ExecuteScalar());
            if (resultado == 1)
            {
                cmd.CommandText = "UPDATE valores SET valor_casal=@casal,valor_solteiro=@solteiro,valor_triplo=@triplo,valor_quadruplo=@quadruplo," +
                    "valor_quintuplo=@quintuplo,valor_criancaDe03A06=@03A06,valor_criancaDe07a10=@07A10 WHERE data=@data";

                cmd.Parameters.AddWithValue("@casal", Valores.TotalCasal);
                cmd.Parameters.AddWithValue("@solteiro", Valores.TotalSolteiro);
                cmd.Parameters.AddWithValue("@triplo", Valores.TotalTriplo);
                cmd.Parameters.AddWithValue("@quadruplo", Valores.TotalQuadruplo);
                cmd.Parameters.AddWithValue("@quintuplo", Valores.TotalQuintuplo);
                cmd.Parameters.AddWithValue("@03A06", Valores.TotalCrianca03A06);
                cmd.Parameters.AddWithValue("@07a10", Valores.TotalCrianca07A10);

                //executa o comando


                cmd.ExecuteNonQuery();
                MessageBox.Show("alterado com sucesso! Clique em load para ver as mudanças!");
            }
            else { MessageBox.Show("Dia nao existe no banco!"); }


        }

        public void InserirValoresNoDataBase(Valores Valores)
        {
            cmd = new MySqlCommand("select(select count(*) from valores where data = @data)as numero_linhas");
            cmd.Connection = objcon;
            cmd.Parameters.AddWithValue("@data", Valores.Data.ToString("yyyy-MM-dd HH:mm:ss"));
            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
            {
                cmd.CommandText = "INSERT INTO valores (data,valor_casal,valor_solteiro,valor_triplo," +
                    "valor_quadruplo,valor_quintuplo,valor_criancaDe03A06,valor_criancaDe07A10)" +
                                       "Values(@data,@casal,@solteiro, @triplo, @quadruplo, @quintuplo, @03A06, @07a10)";
                cmd.Connection = objcon;
                cmd.Parameters.AddWithValue("@casal", Valores.TotalCasal);
                cmd.Parameters.AddWithValue("@solteiro", Valores.TotalSolteiro);
                cmd.Parameters.AddWithValue("@triplo", Valores.TotalTriplo);
                cmd.Parameters.AddWithValue("@quadruplo", Valores.TotalQuadruplo);
                cmd.Parameters.AddWithValue("@quintuplo", Valores.TotalQuintuplo);
                cmd.Parameters.AddWithValue("@03A06", Valores.TotalCrianca03A06);
                cmd.Parameters.AddWithValue("@07a10", Valores.TotalCrianca07A10);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserido com sucesso! Clique em load para ver as mudanças!");
            }
            else { MessageBox.Show("dia ja existe no banco!"); }
        }

        public void DeletarDiaNoDataBase(DateTime diaADeletar)
        {
            cmd = new MySqlCommand("select(select count(*) from valores where data = @data)as numero_linhas");
            cmd.Connection = objcon;
            cmd.Parameters.AddWithValue("@data", diaADeletar.ToString("yyyy-MM-dd HH:mm:ss"));
            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 1)
            {
                cmd.CommandText = "DELETE FROM valores WHERE data = @data";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deletado com sucesso! Clique em load para ver as mudanças!");
            }
            else { MessageBox.Show("Dia nao existe no banco para ser deletado!"); }

        }
        public Boolean VerificarSeExisteDiaNoBanco(DateTime data1, DateTime data2)
        {
            cmd = new MySqlCommand("select(select count(*) from valores where data = @data1)as total_linhas;");
            cmd.Parameters.AddWithValue("@data1", data1.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@data2", data2.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Connection = objcon;
            int data1ExisteNoBanco = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.CommandText = "select(select count(*) from valores where data = @data2)as total_linhas";

            int data2ExisteNoBanco = Convert.ToInt32(cmd.ExecuteScalar());

            if (data1ExisteNoBanco == 0 || data2ExisteNoBanco == 0)

            {
                return false;
            }
            return true;
        }
    }
}
