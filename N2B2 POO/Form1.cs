using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace N2B2_POO
{
    public partial class frmPrincipal : Form
    {       
        
        public frmPrincipal()
        {   
            InitializeComponent(); 
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            panelCadastro.Controls.Clear();

            switch ((int)cbCadastro.SelectedIndex)
            {

                case 0:
                    UserControl carro = new ucCarro();
                    panelCadastro.Controls.Add(carro);
                    carro.Dock = DockStyle.Fill;
                    carro.BringToFront();
                    break;

                case 1:
                    UserControl caminhao = new ucCaminhao();
                    panelCadastro.Controls.Add(caminhao);
                    caminhao.Dock = DockStyle.Fill;
                    caminhao.BringToFront();
                    break;

                case 2:
                    UserControl onibus = new ucOnibus();
                    panelCadastro.Controls.Add(onibus);
                    onibus.Dock = DockStyle.Fill;
                    onibus.BringToFront();
                    break;

                case 3:
                    UserControl moto = new ucMoto();
                    panelCadastro.Controls.Add(moto);
                    moto.Dock = DockStyle.Fill;
                    moto.BringToFront();
                    break;

                case 4:
                    UserControl aviao = new ucAviao();
                    panelCadastro.Controls.Add(aviao);
                    aviao.Dock = DockStyle.Fill;
                    aviao.BringToFront();
                    break;

                case 5:
                    UserControl aviaoguerra = new ucAviaoGuerra();
                    panelCadastro.Controls.Add(aviaoguerra);
                    aviaoguerra.Dock = DockStyle.Fill;
                    aviaoguerra.BringToFront();
                    break;

                case 6:
                    UserControl navio = new ucNavio();
                    panelCadastro.Controls.Add(navio);
                    navio.Dock = DockStyle.Fill;
                    navio.BringToFront();
                    break;

                case 7:
                    UserControl navioguerra = new ucNavioGuerra();
                    panelCadastro.Controls.Add(navioguerra);
                    navioguerra.Dock = DockStyle.Fill;
                    navioguerra.BringToFront();
                    break;

                case 8:
                    UserControl trem = new ucTrem();
                    panelCadastro.Controls.Add(trem);
                    trem.Dock = DockStyle.Fill;
                    trem.BringToFront();
                    break;

                case 9:
                    UserControl marca = new ucMarca();
                    panelCadastro.Controls.Add(marca);
                    marca.Dock = DockStyle.Fill;
                    marca.BringToFront();
                    break;

                case 10:
                    UserControl modelo = new ucModelo();
                    panelCadastro.Controls.Add(modelo);
                    modelo.Dock = DockStyle.Fill;
                    modelo.BringToFront();
                    break;

                case 11:
                    UserControl pedagio = new ucPedagio();
                    panelCadastro.Controls.Add(pedagio);
                    pedagio.Dock = DockStyle.Fill;
                    pedagio.BringToFront();
                    break;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            panelCadastro.Controls.Clear();
            StringBuilder sb = new StringBuilder();
            UserControl lista;
            
            switch ((int)cbCadastro.SelectedIndex)
            {
                case -1:
                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if(item is Carro) sb.Append(item.ToString());
                    }

                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Caminhao) sb.Append(item.ToString());
                    }

                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Onibus) sb.Append(item.ToString());
                    }

                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Moto) sb.Append(item.ToString());
                    }

                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Aviao) sb.Append(item.ToString());
                    }

                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is AviaoGuerra) sb.Append(item.ToString());
                    }

                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Navio) sb.Append(item.ToString());
                    }

                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is NavioGuerra) sb.Append(item.ToString());
                    }

                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Trem) sb.Append(item.ToString());
                    }

                    foreach (var item in Dados.listaMarcas)
                    {
                        sb.Append(item.ToString());
                    }

                    foreach (var item in Dados.listaModelos)
                    {
                        sb.Append(item.ToString());
                    }

                    foreach (var item in Dados.listaPedagios)
                    {
                        sb.Append(item.ToString());
                    }

                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 0:
                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Carro) sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 1:
                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Caminhao) sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 2:
                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Onibus) sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 3:
                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Moto) sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 4:
                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Aviao) sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 5:
                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is AviaoGuerra) sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 6:
                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Navio) sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 7:
                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is NavioGuerra) sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 8:
                    foreach (VeiculoBase item in Dados.listaVeiculos)
                    {
                        if (item is Trem) sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 9:
                    foreach (var item in Dados.listaMarcas)
                    {
                        sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 10:
                    foreach (var item in Dados.listaModelos)
                    {
                        sb.Append(item.ToString());
                    }
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;

                case 11:
                    double valorTotal = 0;
                    foreach (var item in Dados.listaPedagios)
                    {
                        sb.Append(item.ToString());
                        valorTotal += item.ValorRecebido;
                    }
                    sb.AppendLine("Valor total pago com pedágios: R$ " + valorTotal.ToString("0.00"));
                    lista = new ucLista(sb.ToString());
                    panelCadastro.Controls.Add(lista);
                    lista.Dock = DockStyle.Fill;
                    lista.BringToFront();
                    break;
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            object item;
            
            item = new Marca(1, "Toyota");
            Dados.listaMarcas.Add((Marca)item);

            item = new Marca(2, "Ford");
            Dados.listaMarcas.Add((Marca)item);

            item = new Modelo(1, "Etios", Dados.listaMarcas[0]);
            Dados.listaModelos.Add((Modelo)item);

            item = new Modelo(2, "Ka", Dados.listaMarcas[1]);
            Dados.listaModelos.Add((Modelo)item);

            item = new Carro("Carro para teste",
                            Dados.listaModelos[0],
                            5,
                            4);
            Dados.listaVeiculos.Add((Carro)item);

            item = new Caminhao("Caminhão para teste",
                                Dados.listaModelos[1],
                                3,
                                8,
                                200,
                                780);
            Dados.listaVeiculos.Add((Caminhao)item);

            item = new Onibus("Ônibus para teste",
                             Dados.listaModelos[0],
                             25,
                             6,
                             true);
            Dados.listaVeiculos.Add((Onibus)item);

            item = new Moto("Moto para teste",
                            Dados.listaModelos[0],
                            2);
            Dados.listaVeiculos.Add((Moto)item);

            item = new Aviao("Avião para teste",
                            Dados.listaModelos[1],
                            9);
            Dados.listaVeiculos.Add((Aviao)item);

            item = new AviaoGuerra("Avião de guerra para teste",
                            Dados.listaModelos[0],
                            2);
            Dados.listaVeiculos.Add((AviaoGuerra)item);

            item = new Navio("Navio para teste",
                            Dados.listaModelos[1],
                            290);
            Dados.listaVeiculos.Add((Navio)item);

            item = new NavioGuerra("Navio de guerra para teste",
                            Dados.listaModelos[0],
                            370);
            Dados.listaVeiculos.Add((NavioGuerra)item);

            item = new Trem("Trem para teste",
                            Dados.listaModelos[0],
                            100,
                            5);
            Dados.listaVeiculos.Add((Trem)item);

            item = new Pedagio("Pedágio 1", "km 22 ");
            Dados.listaPedagios.Add((Pedagio)item);

            item = new Pedagio("Pedágio 2", "km 102 ");
            Dados.listaPedagios.Add((Pedagio)item);

            item = new Pedagio("Pedágio 3", "km 253 ");
            Dados.listaPedagios.Add((Pedagio)item);
        }

        private void btnPesquisaAcoes_Click(object sender, EventArgs e)
        {
            panelAcoes.Controls.Clear();
            try
            {
                UserControl pesquisaAcoes = new ucAcoes(txtPesquisa.Text);
                panelAcoes.Controls.Add(pesquisaAcoes);
                pesquisaAcoes.Dock = DockStyle.Fill;
                pesquisaAcoes.BringToFront();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Json.Serializar(Dados.listaVeiculos, @"dados/veiculos.json");
            Json.Serializar(Dados.listaMarcas, @"dados/marcas.json");
            Json.Serializar(Dados.listaModelos, @"dados/modelos.json");
            Json.Serializar(Dados.listaPedagios, @"dados/pedagios.json");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Dados.listaVeiculos = (List<VeiculoBase>)Json.DeserializarVeiculos(@"dados/veiculos.json");
            Dados.listaMarcas = (List<Marca>)Json.DeserializarMarcas(@"dados/marcas.json");
            Dados.listaModelos = (List<Modelo>)Json.DeserializarModelos(@"dados/modelos.json");
            Dados.listaPedagios = (List<Pedagio>)Json.DeserializarPedagios(@"dados/pedagios.json");
        }

        

        private void btnLimpadores_Click(object sender, EventArgs e)
        {
            foreach (VeiculoBase v in Dados.listaVeiculos)
            {
                if (v is ILimpador)
                    (v as ILimpador).Limpador();
            }
        }

        private void btnAtacarTodosVeiculos_Click(object sender, EventArgs e)
        {
            foreach (VeiculoBase v in Dados.listaVeiculos)
            {
                if (v is IVeiculoGuerra)
                    (v as IVeiculoGuerra).Atacar();
            }
        }

        private void btnEmpinarTodosVeiculos_Click(object sender, EventArgs e)
        {
            foreach (VeiculoBase v in Dados.listaVeiculos)
            {
                if (v is Moto)
                    (v as Moto).Empinar();
            }
        }

        private void btnAtracarTodosNavios_Click(object sender, EventArgs e)
        {
            foreach (VeiculoBase v in Dados.listaVeiculos)
            {
                if (v is VeiculoAquatico)
                    (v as VeiculoAquatico).Atracar();
            }
        }

        public void atualizaTela(object sender, EventArgs e)
        {
            btnListar_Click(sender, e);
        }
    }
}
