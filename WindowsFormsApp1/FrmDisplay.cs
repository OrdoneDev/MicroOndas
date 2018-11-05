using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDisplay : Form
    {
        private static Thread task;
        private delegate void SetTextCallback(string texto);
        private FuncoesDoUsuario funcao;

        public frmDisplay()
        {
            InitializeComponent();
            criarFuncoesPadroes();
            criarFuncoesUsuario();
        }

        private void setTempoDisplay(string value)
        {
            string tempo = "";

            tempo = Math.Round((double)(Convert.ToInt32(value) / 60)).ToString("00") + ":" + Math.Round((double)(Convert.ToInt32(value) % 60)).ToString("00");

            lblStatusTempo.Text = tempo;
            tbTempo.Value = Convert.ToInt32(value);
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

        private void MostrarStatusSobreAquecimento()
        {
            SetTextCallback d;

            for (int i = MicroOndas.Instance.ajuste.tempo; i >= 0; i--)
            {
                Application.DoEvents();
                d = new SetTextCallback(setStatusAquecimentoDisplay);
                this.Invoke(d, new object[] { "Aquecimento " + funcao.nome + new string(funcao.caracter, ((MicroOndas.Instance.ajuste.tempo - i) * MicroOndas.Instance.ajuste.potencia) % 40) });
                d = new SetTextCallback(setTempoDisplay);
                this.Invoke(d, new object[] { i.ToString() });
                Thread.Sleep(1000);
            }

            SystemSounds.Beep.Play();
            lblStatus.Text = "Aquecida";
            task = null;
            setEnableBotoes(false);
        }

        private void PrepararParaAquecer()
        {
            setEnableBotoes(true);

            if (task == null)
            {
                task = new Thread(MostrarStatusSobreAquecimento);

                MicroOndas.Instance.DefinirAquecimento(new OpcoesAjuste(funcao.tempo, funcao.potencia));
                setPotenciaDisplay(MicroOndas.Instance.ajuste.potencia);

                task.Start();
            }
            else
                task.Resume();
        }

        private void btnFuncao(object sender, EventArgs e)
        {
            int index = (int)((Button)sender).Tag;
            funcao = MicroOndas.Instance.listFuncoesUsuario[index];

            PrepararParaAquecer();
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
            setTempoDisplay(((TrackBar)sender).Value.ToString());
        }

        private void tbPotencia_Scroll(object sender, EventArgs e)
        {
            setPotenciaDisplay(((TrackBar)sender).Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            task.Abort();
            setEnableBotoes(false);
            setTempoDisplay("0");
            setPotenciaDisplay(10);
            lblStatus.Text = "Operação cancelada.";
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (tbTempo.Value == 0)
            {
                setTempoDisplay("30");
                setPotenciaDisplay(8);
            }

            try
            {
                funcao = new FuncoesDoUsuario(new OpcoesAjuste(tbTempo.Value, tbPotencia.Value), "rápido", '.');
                PrepararParaAquecer();
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

        private void btnPausar_Click(object sender, EventArgs e)
        {
            task.Suspend();
            setEnableBotoes(false);
        }
    }
}
