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
    public partial class FrmCadastroFuncoes : Form
    {
        private List<FuncoesDoUsuario> listTemp = new List<FuncoesDoUsuario>();

        public FrmCadastroFuncoes()
        {
            InitializeComponent();
            CarregarFuncoesCadastradas();
        }

        private void CarregarFuncoesCadastradas()
        {
            foreach(FuncoesDoUsuario funcao in MicroOndas.Instance.listFuncoesUsuario)
            {
                listTemp.Add(new FuncoesDoUsuario(new OpcoesAjuste(funcao.tempo, funcao.potencia), funcao.nome, funcao.caracter));
            }

            funcoesDoUsuarioBindingSource.DataSource = listTemp;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MicroOndas.Instance.listFuncoesUsuario = listTemp;
            Close();
        }
    }
}
