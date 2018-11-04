using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDisplay : Form
    {
        public frmDisplay()
        {
            InitializeComponent();
            criarFuncoesPadroes();
            criarFuncoesUsuario();
        }

        private void setTempoDisplay(int value)
        {
            string tempo = "";

            tempo = Math.Round((double)(value / 60)).ToString("00") + ":" + Math.Round((double)(value % 60)).ToString("00");

            lblStatusTempo.Text = tempo;
            tbTempo.Value = value;
        }

        private void setPotenciaDisplay(int value)
        {
            lblStatusPotencia.Text = value.ToString();
            tbPotencia.Value = value;
        }

        private void setStatusAquecimentoDisplay(string statusDisplay)
        {
            lblStatus.Text = statusDisplay;
        }

        private void setEnableBotoes(Boolean status)
        {
            btnPausar.Enabled = status;
            btnCancelar.Enabled = status;
            btnLigar.Enabled = !status;
            pFuncoesRapidas.Enabled = !status;
        }

        private void Aquecer(FuncoesDoUsuario funcao)
        {
            MicroOndas.Instance.DefinirAquecimento(new OpcoesAjuste(funcao.tempo, funcao.potencia));

            setEnableBotoes(true);

            //Refactor to thread
            for (int i = MicroOndas.Instance.ajuste.tempo; i >= 0; i--)
            {
                Application.DoEvents();
                setTempoDisplay(i);
                setStatusAquecimentoDisplay("Aquecimento " + funcao.nome + new string(funcao.caracter, ((MicroOndas.Instance.ajuste.tempo - i) * MicroOndas.Instance.ajuste.potencia) % 40));
                System.Threading.Thread.Sleep(1000);
            }

            setEnableBotoes(false);
            SystemSounds.Beep.Play();
            lblStatus.Text = "Aquecida";
        }

        private void btnFuncao(object sender, EventArgs e)
        {
            int index = (int)((Button)sender).Tag;
            FuncoesDoUsuario funcao = MicroOndas.Instance.listFuncoesUsuario[index];

            Aquecer(funcao);
        }

        private void criarFuncoesPadroes()
        {
            MicroOndas.Instance.listFuncoesUsuario = new List<FuncoesDoUsuario>
            {
                new FuncoesDoUsuario(new OpcoesAjuste(120, 8), "Arroz", '-'),
                new FuncoesDoUsuario(new OpcoesAjuste(55, 2), "Pipoca", '*'),
                new FuncoesDoUsuario(new OpcoesAjuste(80, 4), "Macarrão", '_'),
                new FuncoesDoUsuario(new OpcoesAjuste(100, 10), "Frango", '!'),
                new FuncoesDoUsuario(new OpcoesAjuste(120, 10), "Bolo", '@')
            };
        }

        private void criarBotaoFuncaoUsuario(FuncoesDoUsuario funcao, int index)
        {
            Button btn = new Button();
            btn.Width = 105;
            btn.Height = 30;
            btn.Text = funcao.nome;
            btn.Tag = index;
            btn.Click += btnFuncao;

            flpFuncoes.Controls.Add(btn);
        }

        private void criarFuncoesUsuario()
        {
            int i = 0;

            flpFuncoes.Controls.Clear();

            foreach(FuncoesDoUsuario funcao in MicroOndas.Instance.listFuncoesUsuario)
            {
                criarBotaoFuncaoUsuario(funcao, i++);
            }
        }

        private void tbTempo_Scroll(object sender, EventArgs e)
        {
            setTempoDisplay(((TrackBar)sender).Value);
        }

        private void tbPotencia_Scroll(object sender, EventArgs e)
        {
            setPotenciaDisplay(((TrackBar)sender).Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Operação cancelada.";
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (tbTempo.Value == 0)
            {
                setTempoDisplay(30);
                setPotenciaDisplay(8);
            }

            try
            {
                Aquecer(new FuncoesDoUsuario(new OpcoesAjuste(tbTempo.Value, tbPotencia.Value), "rápido", '.'));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovasFuncoes_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncoes frmCadastroFuncoes = new FrmCadastroFuncoes();
            frmCadastroFuncoes.ShowDialog();
            criarFuncoesUsuario();
        }
    }
}
