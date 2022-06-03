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
    public partial class ucCaminhao : UserControl
    {
        
        public ucCaminhao()
        {
            InitializeComponent();
        }

        private void ucCaminhao_Load(object sender, EventArgs e)
        {
            cbModelo.DataSource = Dados.listaModelos;
            cbModelo.DisplayMember = "Descricao";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Caminhao item = new Caminhao(txtID.Text,
                                        (Modelo)cbModelo.SelectedItem,                                       
                                        Convert.ToInt32(txtCapacidadePassageiro.Text),
                                        Convert.ToInt32(txtQtdEixos.Text),
                                        Convert.ToDouble(txtPesoCarga),
                                        Convert.ToDouble(txtCapacidadeCarga));

                Dados.listaVeiculos.Add(item);
            }
            catch(Exception erro)
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
