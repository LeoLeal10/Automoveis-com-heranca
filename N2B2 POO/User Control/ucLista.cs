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
    public partial class ucLista : UserControl
    {
        public ucLista(string dados)
        {
            InitializeComponent();
            if(!String.IsNullOrEmpty(dados)) txtLista.Text += dados;
        }
    }
}
