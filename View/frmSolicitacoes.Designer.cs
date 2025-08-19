namespace SistDoacaoSangue.View
{
    partial class frmSolicitacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitacoes));
            this.lblListagem = new System.Windows.Forms.Label();
            this.tlpSolicitacoes = new System.Windows.Forms.TableLayoutPanel();
            this.txtQtdNecessaria = new System.Windows.Forms.TextBox();
            this.lblQtdNecessaria = new System.Windows.Forms.Label();
            this.lblIdHospital = new System.Windows.Forms.Label();
            this.txtIdHospital = new System.Windows.Forms.TextBox();
            this.lblTipoSanguineo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblDataSolicitacao = new System.Windows.Forms.Label();
            this.dtpDataDoacao = new System.Windows.Forms.DateTimePicker();
            this.cbTipoSanguineo = new System.Windows.Forms.ComboBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pbAgendamentos = new System.Windows.Forms.PictureBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnPdf = new System.Windows.Forms.Button();
            this.tlpSolicitacoes.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgendamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListagem
            // 
            this.lblListagem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblListagem.BackColor = System.Drawing.Color.Transparent;
            this.lblListagem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblListagem.Location = new System.Drawing.Point(50, 342);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(385, 35);
            this.lblListagem.TabIndex = 32;
            this.lblListagem.Text = "Listagem";
            this.lblListagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tlpSolicitacoes
            // 
            this.tlpSolicitacoes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpSolicitacoes.AutoSize = true;
            this.tlpSolicitacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.tlpSolicitacoes.ColumnCount = 2;
            this.tlpSolicitacoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.01852F));
            this.tlpSolicitacoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.98148F));
            this.tlpSolicitacoes.Controls.Add(this.txtQtdNecessaria, 1, 2);
            this.tlpSolicitacoes.Controls.Add(this.lblQtdNecessaria, 0, 2);
            this.tlpSolicitacoes.Controls.Add(this.lblIdHospital, 0, 0);
            this.tlpSolicitacoes.Controls.Add(this.txtIdHospital, 1, 0);
            this.tlpSolicitacoes.Controls.Add(this.lblTipoSanguineo, 0, 1);
            this.tlpSolicitacoes.Controls.Add(this.lblStatus, 0, 4);
            this.tlpSolicitacoes.Controls.Add(this.txtStatus, 1, 4);
            this.tlpSolicitacoes.Controls.Add(this.lblDataSolicitacao, 0, 3);
            this.tlpSolicitacoes.Controls.Add(this.dtpDataDoacao, 1, 3);
            this.tlpSolicitacoes.Controls.Add(this.cbTipoSanguineo, 1, 1);
            this.tlpSolicitacoes.Location = new System.Drawing.Point(6, 52);
            this.tlpSolicitacoes.Name = "tlpSolicitacoes";
            this.tlpSolicitacoes.RowCount = 5;
            this.tlpSolicitacoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSolicitacoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSolicitacoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSolicitacoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSolicitacoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSolicitacoes.Size = new System.Drawing.Size(432, 252);
            this.tlpSolicitacoes.TabIndex = 30;
            // 
            // txtQtdNecessaria
            // 
            this.txtQtdNecessaria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtdNecessaria.Location = new System.Drawing.Point(137, 115);
            this.txtQtdNecessaria.Name = "txtQtdNecessaria";
            this.txtQtdNecessaria.Size = new System.Drawing.Size(292, 20);
            this.txtQtdNecessaria.TabIndex = 41;
            // 
            // lblQtdNecessaria
            // 
            this.lblQtdNecessaria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQtdNecessaria.AutoSize = true;
            this.lblQtdNecessaria.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblQtdNecessaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblQtdNecessaria.Location = new System.Drawing.Point(22, 118);
            this.lblQtdNecessaria.Name = "lblQtdNecessaria";
            this.lblQtdNecessaria.Size = new System.Drawing.Size(89, 13);
            this.lblQtdNecessaria.TabIndex = 40;
            this.lblQtdNecessaria.Text = "Qtd. Necessária:";
            // 
            // lblIdHospital
            // 
            this.lblIdHospital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdHospital.AutoSize = true;
            this.lblIdHospital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblIdHospital.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblIdHospital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblIdHospital.Location = new System.Drawing.Point(35, 18);
            this.lblIdHospital.Name = "lblIdHospital";
            this.lblIdHospital.Size = new System.Drawing.Size(63, 13);
            this.lblIdHospital.TabIndex = 5;
            this.lblIdHospital.Text = "IdHospital:";
            // 
            // txtIdHospital
            // 
            this.txtIdHospital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdHospital.Location = new System.Drawing.Point(137, 15);
            this.txtIdHospital.Name = "txtIdHospital";
            this.txtIdHospital.Size = new System.Drawing.Size(292, 20);
            this.txtIdHospital.TabIndex = 17;
            // 
            // lblTipoSanguineo
            // 
            this.lblTipoSanguineo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoSanguineo.AutoSize = true;
            this.lblTipoSanguineo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTipoSanguineo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblTipoSanguineo.Location = new System.Drawing.Point(21, 68);
            this.lblTipoSanguineo.Name = "lblTipoSanguineo";
            this.lblTipoSanguineo.Size = new System.Drawing.Size(92, 13);
            this.lblTipoSanguineo.TabIndex = 25;
            this.lblTipoSanguineo.Text = "Tipo Sanguíneo:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblStatus.Location = new System.Drawing.Point(46, 219);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatus.Location = new System.Drawing.Point(137, 216);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(292, 20);
            this.txtStatus.TabIndex = 24;
            // 
            // lblDataSolicitacao
            // 
            this.lblDataSolicitacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataSolicitacao.AutoSize = true;
            this.lblDataSolicitacao.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDataSolicitacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblDataSolicitacao.Location = new System.Drawing.Point(21, 168);
            this.lblDataSolicitacao.Name = "lblDataSolicitacao";
            this.lblDataSolicitacao.Size = new System.Drawing.Size(92, 13);
            this.lblDataSolicitacao.TabIndex = 8;
            this.lblDataSolicitacao.Text = "Data Solicitação:";
            this.lblDataSolicitacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDataDoacao
            // 
            this.dtpDataDoacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDataDoacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDoacao.Location = new System.Drawing.Point(139, 165);
            this.dtpDataDoacao.Name = "dtpDataDoacao";
            this.dtpDataDoacao.Size = new System.Drawing.Size(288, 20);
            this.dtpDataDoacao.TabIndex = 39;
            this.dtpDataDoacao.Value = new System.DateTime(2025, 5, 24, 17, 59, 1, 0);
            // 
            // cbTipoSanguineo
            // 
            this.cbTipoSanguineo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoSanguineo.FormattingEnabled = true;
            this.cbTipoSanguineo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbTipoSanguineo.Location = new System.Drawing.Point(137, 64);
            this.cbTipoSanguineo.Name = "cbTipoSanguineo";
            this.cbTipoSanguineo.Size = new System.Drawing.Size(292, 21);
            this.cbTipoSanguineo.TabIndex = 42;
            // 
            // lblCadastro
            // 
            this.lblCadastro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblCadastro.Location = new System.Drawing.Point(43, -4);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(392, 53);
            this.lblCadastro.TabIndex = 33;
            this.lblCadastro.Text = "Cadastro";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnExcluir, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCadastrar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(50, 310);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(385, 39);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnExcluir.Location = new System.Drawing.Point(277, 8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEditar.Location = new System.Drawing.Point(149, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnCadastrar.Location = new System.Drawing.Point(26, 8);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 40.25F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblMensagem.Location = new System.Drawing.Point(544, 6);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(463, 165);
            this.lblMensagem.TabIndex = 37;
            this.lblMensagem.Text = "Solicitações";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbAgendamentos
            // 
            this.pbAgendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAgendamentos.BackColor = System.Drawing.Color.Transparent;
            this.pbAgendamentos.Image = ((System.Drawing.Image)(resources.GetObject("pbAgendamentos.Image")));
            this.pbAgendamentos.Location = new System.Drawing.Point(531, 174);
            this.pbAgendamentos.Name = "pbAgendamentos";
            this.pbAgendamentos.Size = new System.Drawing.Size(500, 500);
            this.pbAgendamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAgendamentos.TabIndex = 38;
            this.pbAgendamentos.TabStop = false;
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(33, 380);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(402, 281);
            this.dgvLista.TabIndex = 39;
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPdf.Location = new System.Drawing.Point(315, 356);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(120, 21);
            this.btnPdf.TabIndex = 43;
            this.btnPdf.Text = "Exportar para PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // frmSolicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1003, 673);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.pbAgendamentos);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lblListagem);
            this.Controls.Add(this.tlpSolicitacoes);
            this.Controls.Add(this.lblCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSolicitacoes";
            this.Text = "Solicitações";
            this.Load += new System.EventHandler(this.frmSolicitacoes_Load);
            this.tlpSolicitacoes.ResumeLayout(false);
            this.tlpSolicitacoes.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAgendamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListagem;
        private System.Windows.Forms.TableLayoutPanel tlpSolicitacoes;
        private System.Windows.Forms.Label lblIdHospital;
        private System.Windows.Forms.TextBox txtIdHospital;
        private System.Windows.Forms.Label lblDataSolicitacao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblTipoSanguineo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox pbAgendamentos;
        private System.Windows.Forms.DateTimePicker dtpDataDoacao;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtQtdNecessaria;
        private System.Windows.Forms.Label lblQtdNecessaria;
        private System.Windows.Forms.ComboBox cbTipoSanguineo;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPdf;
    }
}