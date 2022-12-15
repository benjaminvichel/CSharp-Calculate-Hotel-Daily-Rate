using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        RepositoryValores repositoryValores = new RepositoryValores();
        DateTime data1;
        DateTime data2;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCalcularDiarias_Click(object sender, EventArgs e)
        {

            try
            {
                data1 = dateTimePicker1.Value.Date;
                data2 = dateTimePicker2.Value.Date;

                int res = DateTime.Compare(data1, data2);
                if (res > 0) { throw new Exception("verifique a data!"); }

                data2 = res == 0 ? dateTimePicker2.Value.Date : dateTimePicker2.Value.Date.AddDays(-1);
                // calcula numero diarias                                                         
                TimeSpan interval = dateTimePicker2.Value.Date - dateTimePicker1.Value.Date;
                if (repositoryValores.VerificarSeExisteDiaNoBanco(data1, data2) == false)
                { throw new Exception("Uma das datas não existe no banco!"); }

                var valores = repositoryValores.ConsultarSomaDosValores(data1, data2);
                //valor cada diaria
                textValorDiariaCasal.Text = (valores.TotalCasal / interval.Days).ToString("c");
                textValorDiariaSolteiro.Text = (valores.TotalSolteiro / interval.Days).ToString("c");
                textValorDiariaTriplo.Text = (valores.TotalTriplo / interval.Days).ToString("c");
                textValorDiariaQuadruplo.Text = (valores.TotalQuadruplo / interval.Days).ToString("c");
                textValorDiariaQuintuplo.Text = (valores.TotalQuintuplo / interval.Days).ToString("c");
                //numero diarias
                textNumeroDiarias.Text = (interval.Days).ToString();
                //total diarias
                textValorTotalCasal.Text = valores.TotalCasal.ToString("c");
                textValorTotalSolteiro.Text = valores.TotalSolteiro.ToString("c");
                textValorTotalTriplo.Text = valores.TotalTriplo.ToString("c");
                textValorTotalQuadruplo.Text = valores.TotalQuadruplo.ToString("c");
                textValorTotalQuintuplo.Text = valores.TotalQuintuplo.ToString("c");

                //recebe quantidade crianca de 03 a 06 anos
                int quantidadeCriancas03A06 = Int32.Parse(String.IsNullOrEmpty(textCrianca03A06.Text) ? "0" : textCrianca03A06.Text);
                double somaValorCrianca03A06 = quantidadeCriancas03A06 * valores.TotalCrianca03A06;
                //recebe quantidade criança de 07 a 10 anos
                int quantidadeCriancas07A10 = Int32.Parse(String.IsNullOrEmpty(textCrianca07A10.Text) ? "0" : textCrianca07A10.Text);
                double somaValorCrianca07A10 = quantidadeCriancas07A10 * valores.TotalCrianca07A10;
                //recebe quantidade quantidade solteiros
                int quantidadeSolteirosCustom = Int32.Parse(String.IsNullOrEmpty(textSolteiroCustom.Text) ? "0" : textSolteiroCustom.Text);
                double somaValorSolteirosCustom = quantidadeSolteirosCustom * valores.TotalSolteiro;
                //calcula valor total do custom
                double valorTotal = (valores.TotalCasal + somaValorSolteirosCustom + somaValorCrianca03A06 + somaValorCrianca07A10);
                //imprime valor da diaria custom
                textValorDiariaCustom.Text = (valorTotal / interval.Days).ToString("c");
                //imprime valor total custom
                textValorTotalCustom.Text = valorTotal.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form2 novaform2 = new Form2();
            novaform2.Show();
            repositoryValores.VerifyIfconnectedToDataBase();
        }

    }
}
