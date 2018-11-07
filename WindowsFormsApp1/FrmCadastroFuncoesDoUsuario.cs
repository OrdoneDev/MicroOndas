using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCadastroFuncoesDoUsuario : Form
    {
        public FrmCadastroFuncoesDoUsuario()
        {
            InitializeComponent();
            CadastroDeFuncoesDoUsuario.CarregarFuncoesCadastradas();
            VincularListAoDataSource();
        }

        private void VincularListAoDataSource()
        {
            funcoesDoUsuarioBindingSource.DataSource = CadastroDeFuncoesDoUsuario.ListTemp;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroDeFuncoesDoUsuario.SalvarModificacoes();
            Close();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    funcoesDoUsuarioBindingSource.DataSource = CadastroDeFuncoesDoUsuario.CarregarArqFuncoes(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
