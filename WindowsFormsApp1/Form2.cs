using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void buttonEntrarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Insira a senha!");
            }
            else if (txtSenha.Text == "nathanota10")
            {
                Form3 novaform3 = new Form3();
                novaform3.Show();
                this.Close();
            }
        }
    }
}
