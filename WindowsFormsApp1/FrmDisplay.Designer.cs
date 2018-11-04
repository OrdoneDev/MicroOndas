namespace WindowsFormsApp1
{
    partial class frmDisplay
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStatus = new System.Windows.Forms.Label();
            this.tlpDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.pTempo = new System.Windows.Forms.Panel();
            this.lblStatusTempo = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.pPotencia = new System.Windows.Forms.Panel();
            this.lblStatusPotencia = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.tbTempo = new System.Windows.Forms.TrackBar();
            this.tbPotencia = new System.Windows.Forms.TrackBar();
            this.pFuncoes = new System.Windows.Forms.Panel();
            this.pFuncoesRapidas = new System.Windows.Forms.Panel();
            this.pNovasFuncoes = new System.Windows.Forms.Panel();
            this.btnNovasFuncoes = new System.Windows.Forms.Button();
            this.flpFuncoes = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpFuncoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFuncoes = new System.Windows.Forms.Label();
            this.tlpDisplay.SuspendLayout();
            this.pTempo.SuspendLayout();
            this.pPotencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPotencia)).BeginInit();
            this.pFuncoes.SuspendLayout();
            this.pFuncoesRapidas.SuspendLayout();
            this.pNovasFuncoes.SuspendLayout();
            this.tlpFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(368, 32);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Aguardando instrução..";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpDisplay
            // 
            this.tlpDisplay.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tlpDisplay.ColumnCount = 2;
            this.tlpDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDisplay.Controls.Add(this.pTempo, 0, 0);
            this.tlpDisplay.Controls.Add(this.pPotencia, 1, 0);
            this.tlpDisplay.Controls.Add(this.tbTempo, 0, 1);
            this.tlpDisplay.Controls.Add(this.tbPotencia, 1, 1);
            this.tlpDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDisplay.Location = new System.Drawing.Point(0, 32);
            this.tlpDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDisplay.Name = "tlpDisplay";
            this.tlpDisplay.RowCount = 2;
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDisplay.Size = new System.Drawing.Size(368, 115);
            this.tlpDisplay.TabIndex = 2;
            // 
            // pTempo
            // 
            this.pTempo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pTempo.Controls.Add(this.lblStatusTempo);
            this.pTempo.Controls.Add(this.lblTempo);
            this.pTempo.Location = new System.Drawing.Point(3, 3);
            this.pTempo.Name = "pTempo";
            this.pTempo.Size = new System.Drawing.Size(178, 51);
            this.pTempo.TabIndex = 0;
            // 
            // lblStatusTempo
            // 
            this.lblStatusTempo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblStatusTempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusTempo.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTempo.ForeColor = System.Drawing.Color.White;
            this.lblStatusTempo.Location = new System.Drawing.Point(0, 17);
            this.lblStatusTempo.Name = "lblStatusTempo";
            this.lblStatusTempo.Size = new System.Drawing.Size(178, 34);
            this.lblStatusTempo.TabIndex = 3;
            this.lblStatusTempo.Text = "00:00";
            this.lblStatusTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempo
            // 
            this.lblTempo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTempo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTempo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            this.lblTempo.Location = new System.Drawing.Point(0, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(178, 17);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPotencia
            // 
            this.pPotencia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pPotencia.Controls.Add(this.lblStatusPotencia);
            this.pPotencia.Controls.Add(this.lblPotencia);
            this.pPotencia.Location = new System.Drawing.Point(187, 3);
            this.pPotencia.Name = "pPotencia";
            this.pPotencia.Size = new System.Drawing.Size(178, 51);
            this.pPotencia.TabIndex = 1;
            // 
            // lblStatusPotencia
            // 
            this.lblStatusPotencia.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblStatusPotencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusPotencia.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPotencia.ForeColor = System.Drawing.Color.White;
            this.lblStatusPotencia.Location = new System.Drawing.Point(0, 17);
            this.lblStatusPotencia.Name = "lblStatusPotencia";
            this.lblStatusPotencia.Size = new System.Drawing.Size(178, 34);
            this.lblStatusPotencia.TabIndex = 5;
            this.lblStatusPotencia.Text = "10";
            this.lblStatusPotencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPotencia
            // 
            this.lblPotencia.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPotencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPotencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotencia.ForeColor = System.Drawing.Color.White;
            this.lblPotencia.Location = new System.Drawing.Point(0, 0);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(178, 17);
            this.lblPotencia.TabIndex = 4;
            this.lblPotencia.Text = "Potência";
            this.lblPotencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTempo
            // 
            this.tbTempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTempo.Location = new System.Drawing.Point(3, 60);
            this.tbTempo.Maximum = 120;
            this.tbTempo.Name = "tbTempo";
            this.tbTempo.Size = new System.Drawing.Size(178, 52);
            this.tbTempo.TabIndex = 2;
            this.tbTempo.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbTempo.Scroll += new System.EventHandler(this.tbTempo_Scroll);
            // 
            // tbPotencia
            // 
            this.tbPotencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPotencia.Location = new System.Drawing.Point(187, 60);
            this.tbPotencia.Minimum = 1;
            this.tbPotencia.Name = "tbPotencia";
            this.tbPotencia.Size = new System.Drawing.Size(178, 52);
            this.tbPotencia.TabIndex = 3;
            this.tbPotencia.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbPotencia.Value = 10;
            this.tbPotencia.Scroll += new System.EventHandler(this.tbPotencia_Scroll);
            // 
            // pFuncoes
            // 
            this.pFuncoes.Controls.Add(this.pFuncoesRapidas);
            this.pFuncoes.Controls.Add(this.tlpFuncoes);
            this.pFuncoes.Controls.Add(this.lblFuncoes);
            this.pFuncoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFuncoes.Location = new System.Drawing.Point(0, 147);
            this.pFuncoes.Name = "pFuncoes";
            this.pFuncoes.Size = new System.Drawing.Size(368, 303);
            this.pFuncoes.TabIndex = 11;
            // 
            // pFuncoesRapidas
            // 
            this.pFuncoesRapidas.Controls.Add(this.pNovasFuncoes);
            this.pFuncoesRapidas.Controls.Add(this.flpFuncoes);
            this.pFuncoesRapidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFuncoesRapidas.Location = new System.Drawing.Point(0, 13);
            this.pFuncoesRapidas.Name = "pFuncoesRapidas";
            this.pFuncoesRapidas.Size = new System.Drawing.Size(368, 253);
            this.pFuncoesRapidas.TabIndex = 15;
            // 
            // pNovasFuncoes
            // 
            this.pNovasFuncoes.Controls.Add(this.btnNovasFuncoes);
            this.pNovasFuncoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pNovasFuncoes.Location = new System.Drawing.Point(0, 221);
            this.pNovasFuncoes.Name = "pNovasFuncoes";
            this.pNovasFuncoes.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.pNovasFuncoes.Size = new System.Drawing.Size(368, 32);
            this.pNovasFuncoes.TabIndex = 16;
            // 
            // btnNovasFuncoes
            // 
            this.btnNovasFuncoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNovasFuncoes.Location = new System.Drawing.Point(290, 0);
            this.btnNovasFuncoes.Name = "btnNovasFuncoes";
            this.btnNovasFuncoes.Size = new System.Drawing.Size(75, 32);
            this.btnNovasFuncoes.TabIndex = 2;
            this.btnNovasFuncoes.Text = "+ Funções";
            this.btnNovasFuncoes.UseVisualStyleBackColor = true;
            this.btnNovasFuncoes.Click += new System.EventHandler(this.btnNovasFuncoes_Click);
            // 
            // flpFuncoes
            // 
            this.flpFuncoes.AutoScroll = true;
            this.flpFuncoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFuncoes.Location = new System.Drawing.Point(0, 0);
            this.flpFuncoes.Name = "flpFuncoes";
            this.flpFuncoes.Padding = new System.Windows.Forms.Padding(15);
            this.flpFuncoes.Size = new System.Drawing.Size(368, 253);
            this.flpFuncoes.TabIndex = 15;
            // 
            // tlpFuncoes
            // 
            this.tlpFuncoes.ColumnCount = 3;
            this.tlpFuncoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFuncoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFuncoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFuncoes.Controls.Add(this.btnLigar, 0, 0);
            this.tlpFuncoes.Controls.Add(this.btnPausar, 1, 0);
            this.tlpFuncoes.Controls.Add(this.btnCancelar, 2, 0);
            this.tlpFuncoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFuncoes.Location = new System.Drawing.Point(0, 266);
            this.tlpFuncoes.Name = "tlpFuncoes";
            this.tlpFuncoes.RowCount = 1;
            this.tlpFuncoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFuncoes.Size = new System.Drawing.Size(368, 37);
            this.tlpFuncoes.TabIndex = 13;
            // 
            // btnLigar
            // 
            this.btnLigar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLigar.Location = new System.Drawing.Point(3, 3);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(116, 31);
            this.btnLigar.TabIndex = 0;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPausar.Enabled = false;
            this.btnPausar.Location = new System.Drawing.Point(125, 3);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(116, 31);
            this.btnPausar.TabIndex = 1;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(247, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 31);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFuncoes
            // 
            this.lblFuncoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFuncoes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncoes.Location = new System.Drawing.Point(0, 0);
            this.lblFuncoes.Margin = new System.Windows.Forms.Padding(3);
            this.lblFuncoes.Name = "lblFuncoes";
            this.lblFuncoes.Size = new System.Drawing.Size(368, 13);
            this.lblFuncoes.TabIndex = 8;
            this.lblFuncoes.Text = "Funções";
            this.lblFuncoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.pFuncoes);
            this.Controls.Add(this.tlpDisplay);
            this.Controls.Add(this.lblStatus);
            this.Name = "frmDisplay";
            this.Text = "Display micro-ondas";
            this.tlpDisplay.ResumeLayout(false);
            this.tlpDisplay.PerformLayout();
            this.pTempo.ResumeLayout(false);
            this.pPotencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPotencia)).EndInit();
            this.pFuncoes.ResumeLayout(false);
            this.pFuncoesRapidas.ResumeLayout(false);
            this.pNovasFuncoes.ResumeLayout(false);
            this.tlpFuncoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TableLayoutPanel tlpDisplay;
        private System.Windows.Forms.Panel pTempo;
        private System.Windows.Forms.Label lblStatusTempo;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Panel pPotencia;
        private System.Windows.Forms.Label lblStatusPotencia;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.TrackBar tbTempo;
        private System.Windows.Forms.TrackBar tbPotencia;
        private System.Windows.Forms.Panel pFuncoes;
        private System.Windows.Forms.Panel pFuncoesRapidas;
        private System.Windows.Forms.Panel pNovasFuncoes;
        private System.Windows.Forms.Button btnNovasFuncoes;
        private System.Windows.Forms.FlowLayoutPanel flpFuncoes;
        private System.Windows.Forms.TableLayoutPanel tlpFuncoes;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFuncoes;
    }
}

