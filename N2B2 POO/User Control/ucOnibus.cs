using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2B2_POO
{
    public partial class ucOnibus : UserControl
    {
        
        public ucOnibus()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Onibus item = new Onibus(txtID.Text,
                                  (Modelo)cbModelo.SelectedItem,
                                  Convert.ToUInt16(txtCapacidadePassageiro.Text),
                                  Convert.ToUInt16(txtQtdEixos.Text),
                                  checkLeito.Checked);

                Dados.listaVeiculos.Add(item);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }

            txtID.Focus();
        }

        private void ucOnibus_Load(object sender, EventArgs e)
        {
            cbModelo.DataSource = Dados.listaModelos;
            cbModelo.DisplayMember = "Descricao";
        }
    }
}
