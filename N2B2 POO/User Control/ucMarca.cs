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
    public partial class ucMarca : UserControl
    {
        
        
        public ucMarca()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Marca item = new Marca(Convert.ToUInt16(txtCod.Text), txtDesc.Text);
                Dados.listaMarcas.Add(item);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        private void ucMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
