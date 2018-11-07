using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCadastroFuncoes : Form
    {
        public FrmCadastroFuncoes()
        {
            InitializeComponent();
            new CadastroDeFuncoes();
            VincularListAoDataSource();
        }

        private void VincularListAoDataSource()
        {
            funcoesDoUsuarioBindingSource.DataSource = CadastroDeFuncoes.listTemp;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroDeFuncoes.SalvarModificacoes();
            Close();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    funcoesDoUsuarioBindingSource.DataSource = CadastroDeFuncoes.CarregarArqFuncoes(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
