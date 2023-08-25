using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2B2_POO
{
    public partial class ucAcoes : UserControl
    {
        int indexVeiculo;
        int identificacaoPedagio;
        
        public ucAcoes()
        {
            InitializeComponent();
        }

        public ucAcoes(string idVeiculo)
        {
            indexVeiculo = Dados.listaVeiculos.FindIndex(veiculoProcurado => veiculoProcurado.GetIdentificacao() == idVeiculo);

            if (indexVeiculo < 0) 
                throw new Exception("Veículo não encontrado!!!");

            InitializeComponent();
        }        

        private void ucAcoes_Load(object sender, EventArgs e)
        {
            cbPedagio.DataSource = Dados.listaPedagios;
            cbPedagio.DisplayMember = "Identificacao";

            if(Dados.listaVeiculos[indexVeiculo] is IPedagio)
            {
                btnPedagio.Visible = true;
                cbPedagio.Visible = true;
                btnPedagioTodosVeiculos.Visible = true;
            }

            if(Dados.listaVeiculos[indexVeiculo] is ILimpador)
            {
                btnLimpador.Visible = true;
            }
            
            if(Dados.listaVeiculos[indexVeiculo] is IVeiculoGuerra)
            {
                btnAtacar.Visible = true;
            }
            
            if(Dados.listaVeiculos[indexVeiculo] is Moto)
            {               
                btnEmpinar.Visible = true;
            }

            if(Dados.listaVeiculos[indexVeiculo] is Caminhao)
            {                
                gbCaminhaoAcoes.Visible = true;
            }            

            if(Dados.listaVeiculos[indexVeiculo] is Aviao)
            {
                gbAviao.Visible = true;               
            }

            if(Dados.listaVeiculos[indexVeiculo] is AviaoGuerra)
            {
                gbAviao.Visible = true;               

            }

            if(Dados.listaVeiculos[indexVeiculo] is Navio)
            {
                gbNavio.Visible = true;
            }

            if(Dados.listaVeiculos[indexVeiculo] is NavioGuerra)
            {
                gbNavio.Visible = true;
                btnAtacar.Visible = true;
            }
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            try
            {
                Dados.listaVeiculos[indexVeiculo].Acelerar();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }     
        }

        private void btnFrear_Click(object sender, EventArgs e)
        {
            Dados.listaVeiculos[indexVeiculo].Frear();
        }

        private void btnLimpador_Click(object sender, EventArgs e)
        {
            if(Dados.listaVeiculos[indexVeiculo] is ILimpador)            
                (Dados.listaVeiculos[indexVeiculo] as ILimpador).Limpador();           

        }

        private void btnEmpinar_Click(object sender, EventArgs e)
        {
            Moto moto = (Moto)Dados.listaVeiculos[indexVeiculo];
            moto.Empinar();
        }

        private void btnPedagio_Click(object sender, EventArgs e)
        {
            identificacaoPedagio = cbPedagio.SelectedIndex;

            Dados.listaPedagios[identificacaoPedagio].RecebePagamento((Dados.listaVeiculos[indexVeiculo] as IPedagio).PagarPedagio());            
        }            

        private void btnCarregarCaminhao_Click(object sender, EventArgs e)
        {
            try
            {
                Caminhao veiculo = (Caminhao)Dados.listaVeiculos[indexVeiculo];
                veiculo.Carregar(Convert.ToDouble(txtCarregarCaminhao.Text));
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnDescarregarCaminhao_Click(object sender, EventArgs e)
        {
            Caminhao veiculo = (Caminhao)Dados.listaVeiculos[indexVeiculo];
            veiculo.Descarregar();

        }

        private void btnAtracar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoAquatico veiculo = (VeiculoAquatico)Dados.listaVeiculos[indexVeiculo];
                veiculo.Atracar();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        private void btnAtacarNavio_Click(object sender, EventArgs e)
        {
            if (Dados.listaVeiculos[indexVeiculo] is IVeiculoGuerra)
            {
                if(Dados.listaVeiculos[indexVeiculo] is NavioGuerra)
                {
                    NavioGuerra veiculo = (NavioGuerra)Dados.listaVeiculos[indexVeiculo];
                    veiculo.Atacar();
                }

                if (Dados.listaVeiculos[indexVeiculo] is AviaoGuerra)
                {
                    AviaoGuerra veiculo = (AviaoGuerra)Dados.listaVeiculos[indexVeiculo];
                    veiculo.Atacar();
                }

            }
        }

        private void btnDecolar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoAereo veiculo = (VeiculoAereo)Dados.listaVeiculos[indexVeiculo];
                veiculo.Decolar();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }               
        }

        private void btnArremeter_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoAereo veiculo = (VeiculoAereo)Dados.listaVeiculos[indexVeiculo];
                veiculo.Arremeter();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }            
        }

        private void btnPousar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoAereo veiculo = (VeiculoAereo)Dados.listaVeiculos[indexVeiculo];
                veiculo.Pousar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }            
        }

        private void btnEjetar_Click(object sender, EventArgs e)
        {
            try
            {
                AviaoGuerra veiculo = (AviaoGuerra)Dados.listaVeiculos[indexVeiculo];
                veiculo.Ejetar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }            
        }

        private void btnPedagioTodosVeiculos_Click(object sender, EventArgs e)
        {
            foreach (VeiculoBase v in Dados.listaVeiculos)
            {
                identificacaoPedagio = cbPedagio.SelectedIndex;
                if (v is IPedagio)                
                    Dados.listaPedagios[identificacaoPedagio].RecebePagamento((v as IPedagio).PagarPedagio());                           
            }
        }

        private void btnAtracarTodosNavios_Click(object sender, EventArgs e)
        {
            
        }
    }
}
