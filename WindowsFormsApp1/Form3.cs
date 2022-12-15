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
    public partial class Form3 : Form
    {
        DateTime data3;
        DateTime data4;
        MySqlConnection objcon;
        MySqlCommand cmd;
        RepositoryValores repositoryValores = new RepositoryValores();

        public Form3()
        {
            InitializeComponent();
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("DATA", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("valor_Casal", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Solteiro", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("valor_triplo", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("valor_quadruplo", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("valor_quintuplo", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Crianca03A06", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Crianca07A10", 120, HorizontalAlignment.Left);
        }
        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();

                data3 = dateTimePicker3.Value.Date;
                data4 = dateTimePicker4.Value.Date;

                int resultadoCompareDias = DateTime.Compare(data3, data4);
                if (resultadoCompareDias > 0) { throw new Exception(); }

                TimeSpan diferencaDeDiasEntreDataInicialEDataFinal = Convert.ToDateTime(data4) - Convert.ToDateTime(data3);
                int totalDiasDeDiferenca = diferencaDeDiasEntreDataInicialEDataFinal.Days;
                int contador = 1;

                for (int i = 0; i <= totalDiasDeDiferenca; i++)
                {

                    var valores = repositoryValores.carregarValoresParaCrud(data3);
                    if (valores == null) { data3 = dateTimePicker3.Value.Date.AddDays(contador); contador++; continue; }
                    var linha_listView = new ListViewItem(valores.Data.ToString());
                    linha_listView.SubItems.Add(valores.TotalCasal.ToString());
                    linha_listView.SubItems.Add(valores.TotalSolteiro.ToString());
                    linha_listView.SubItems.Add(valores.TotalTriplo.ToString());
                    linha_listView.SubItems.Add(valores.TotalQuadruplo.ToString());
                    linha_listView.SubItems.Add(valores.TotalQuintuplo.ToString());
                    linha_listView.SubItems.Add(valores.TotalCrianca03A06.ToString());
                    linha_listView.SubItems.Add(valores.TotalCrianca07A10.ToString());
                    listView1.Items.Add(linha_listView);
                    data3 = dateTimePicker3.Value.Date.AddDays(contador);
                    contador++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na data!");
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePickerInserir != null)
                {
                    var updateValores = new Valores()
                    {
                        Data = dateTimePickerInserir.Value.Date,

                        TotalCasal = Convert.ToDouble(txtCasal.Text),
                        TotalSolteiro = Convert.ToDouble(txtSolteiro.Text),
                        TotalTriplo = Convert.ToDouble(txtTriplo.Text),
                        TotalQuadruplo = Convert.ToDouble(txtQuadruplo.Text),
                        TotalQuintuplo = Convert.ToDouble(txtQuintuplo.Text),
                        TotalCrianca03A06 = Convert.ToDouble(txt03A06Anos.Text),
                        TotalCrianca07A10 = Convert.ToDouble(txt07A10Anos.Text),
                    };
                    repositoryValores.UpdateValoresNoDataBase(updateValores);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                //coloca 0 nos campos vazios ou nulos
                txtCasal.Text = String.IsNullOrEmpty(txtCasal.Text) ? "0" : txtCasal.Text;
                txtSolteiro.Text = String.IsNullOrEmpty(txtSolteiro.Text) ? "0" : txtSolteiro.Text;
                txtTriplo.Text = String.IsNullOrEmpty(txtTriplo.Text) ? "0" : txtTriplo.Text;
                txtQuadruplo.Text = String.IsNullOrEmpty(txtQuadruplo.Text) ? "0" : txtQuadruplo.Text;
                txtQuintuplo.Text = String.IsNullOrEmpty(txtQuintuplo.Text) ? "0" : txtQuintuplo.Text;
                txt03A06Anos.Text = String.IsNullOrEmpty(txt03A06Anos.Text) ? "0" : txt03A06Anos.Text;
                txt07A10Anos.Text = String.IsNullOrEmpty(txt07A10Anos.Text) ? "0" : txt07A10Anos.Text;

                if (dateTimePickerInserir != null)
                {
                    var updateValores = new Valores()
                    {
                        Data = dateTimePickerInserir.Value.Date,
                        TotalCasal = Convert.ToDouble(txtCasal.Text),
                        TotalSolteiro = Convert.ToDouble(txtSolteiro.Text),
                        TotalTriplo = Convert.ToDouble(txtTriplo.Text),
                        TotalQuadruplo = Convert.ToDouble(txtQuadruplo.Text),
                        TotalQuintuplo = Convert.ToDouble(txtQuintuplo.Text),
                        TotalCrianca03A06 = Convert.ToDouble(txt03A06Anos.Text),
                        TotalCrianca07A10 = Convert.ToDouble(txt07A10Anos.Text),
                    };
                    repositoryValores.InserirValoresNoDataBase(updateValores);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = listView1.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                dateTimePickerInserir.Value = Convert.ToDateTime(item.SubItems[0].Text);
                txtCasal.Text = item.SubItems[1].Text;
                txtSolteiro.Text = item.SubItems[2].Text;
                txtTriplo.Text = item.SubItems[3].Text;
                txtQuadruplo.Text = item.SubItems[4].Text;
                txtQuintuplo.Text = item.SubItems[5].Text;
                txt03A06Anos.Text = item.SubItems[6].Text;
                txt07A10Anos.Text = item.SubItems[7].Text;
            }
        }
        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            DateTime diaADeletar = dateTimePickerInserir.Value.Date;
            string message = "Do you want to Delete?";
            string title = "Delete Action";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                repositoryValores.DeletarDiaNoDataBase(diaADeletar);
            }
        }
    }
}
