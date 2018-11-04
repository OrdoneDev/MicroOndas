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

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader sr;
            String[] elements;
            string line;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listTemp = new List<FuncoesDoUsuario>();
                sr = new System.IO.StreamReader(openFileDialog1.FileName);

                try
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        elements = line.Split(',');
                        listTemp.Add(new FuncoesDoUsuario(new OpcoesAjuste(Convert.ToInt32(elements[2]), Convert.ToInt32(elements[3])), elements[0], elements[1][0]));
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                sr.Close();

                funcoesDoUsuarioBindingSource.DataSource = listTemp;
            }
        }
    }
}
