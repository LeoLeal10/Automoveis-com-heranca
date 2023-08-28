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
    public partial class ucModelo : UserControl
    {
        

        public ucModelo() 
        { 
            InitializeComponent();
            
        }

        private void ucModelo_Load(object sender, EventArgs e)
        {
            if (Dados.listaMarcas.Count != 0)
            {
                cbMarcas.DataSource = Dados.listaMarcas;
                cbMarcas.DisplayMember = "Descricao";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToUInt16(txtCod.Text);
                string descricao = txtDesc.Text.ToString();
                Marca marca = (Marca)cbMarcas.SelectedItem;

                Modelo item = new Modelo(codigo, descricao, marca);
                Dados.listaModelos.Add(item);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
