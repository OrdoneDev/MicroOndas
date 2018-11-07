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
        private delegate void SetBoolCallback(bool status);

        public frmDisplay()
        {
            InitializeComponent();
            criarFuncoesUsuario();
        }

        private string valueToTime(string value)
        {
            string minutos = "";
            string segundos = "";
            string tempo = "";

            minutos = Math.Round((double)(Convert.ToInt32(value) / 60)).ToString("00");
            segundos = Math.Round((double)(Convert.ToInt32(value) % 60)).ToString("00");
            tempo = minutos + ":" + segundos;

            return tempo;
        }

        private void setTempoDisplay(string value)
        {
            lblStatusTempo.Text = valueToTime(value);
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
            SetTextCallback textCallBack;
            SetBoolCallback boolCallBack;

            for (int i = MicroOndas.Instance.funcao.tempo; i >= 0; i--)
            {
                Application.DoEvents();
                textCallBack = new SetTextCallback(setStatusAquecimentoDisplay);
                this.Invoke(textCallBack, new object[] { "Aquecimento " + MicroOndas.Instance.funcao.nome + new string(MicroOndas.Instance.funcao.caracter, ((MicroOndas.Instance.funcao.tempo - i) * MicroOndas.Instance.funcao.potencia) % 40) });
                textCallBack = new SetTextCallback(setTempoDisplay);
                this.Invoke(textCallBack, new object[] { i.ToString() });
                Thread.Sleep(1000);
            }

            SystemSounds.Beep.Play();
            textCallBack = new SetTextCallback(setStatusAquecimentoDisplay);
            this.Invoke(textCallBack, new object[] { "Aquecida" });
            boolCallBack = new SetBoolCallback(setEnableBotoes);
            this.Invoke(boolCallBack, new object[] { false });
            task = null;
        }

        private void PrepararParaAquecer()
        {
            setEnableBotoes(true);

            if (task == null)
            {
                task = new Thread(MostrarStatusSobreAquecimento);

                setPotenciaDisplay(MicroOndas.Instance.funcao.potencia);

                task.Start();
            }
            else
                task.Resume();
        }

        private void btnFuncao(object sender, EventArgs e)
        {
            int index = (int)((Button)sender).Tag;
            task = null;

            MicroOndas.Instance.CarregarFuncaoUsuario(index);
            PrepararParaAquecer();
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

        private void DefinirConfiguracoes()
        {
            OpcoesAjusteMicroOndas ajuste;
            FuncoesDoUsuario funcao;

            if (tbTempo.Value == 0)
            {
                MicroOndas.Instance.DefinirFuncaoRapida();
            }
            else
            {
                ajuste = new OpcoesAjusteMicroOndas(tbTempo.Value, tbPotencia.Value);
                funcao = new FuncoesDoUsuario(ajuste, "rápido", '.');

                MicroOndas.Instance.DefinirFuncao(funcao);
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
            task = null;
            setEnableBotoes(false);
            setTempoDisplay((0).ToString());
            setPotenciaDisplay(10);
            lblStatus.Text = "Operação cancelada.";
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            DefinirConfiguracoes();

            try
            {
                PrepararParaAquecer();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovasFuncoes_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncoesDoUsuario frmCadastroFuncoes = new FrmCadastroFuncoesDoUsuario();
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
