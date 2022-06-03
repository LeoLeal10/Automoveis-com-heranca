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
    public partial class ucAviao : UserControl
    {
        public ucAviao()
        {
            InitializeComponent();
        }
        
        private void ucAviao_Load(object sender, EventArgs e)
        {
            cbModelo.DataSource = Dados.listaModelos;
            cbModelo.DisplayMember = "Descricao";

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Aviao item = new Aviao(txtID.Text,
                                  (Modelo)cbModelo.SelectedItem,                                 
                                  Convert.ToUInt16(txtCapacidadePassageiro.Text));

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
    }
}
