namespace SistDoacaoSangue.View
{
    partial class frmDoacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoacoes));
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblListagem = new System.Windows.Forms.Label();
            this.tlpAgendamentos = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdHospital = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.dtpDoacao = new System.Windows.Forms.DateTimePicker();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pbAgendamentos = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnPdf = new System.Windows.Forms.Button();
            this.tlpAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgendamentos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblCadastro.Location = new System.Drawing.Point(10, -10);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(392, 53);
            this.lblCadastro.TabIndex = 33;
            this.lblCadastro.Text = "Cadastro";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblListagem
            // 
            this.lblListagem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblListagem.BackColor = System.Drawing.Color.Transparent;
            this.lblListagem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblListagem.Location = new System.Drawing.Point(53, 322);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(376, 49);
            this.lblListagem.TabIndex = 32;
            this.lblListagem.Text = "Listagem";
            this.lblListagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tlpAgendamentos
            // 
            this.tlpAgendamentos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpAgendamentos.AutoSize = true;
            this.tlpAgendamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.tlpAgendamentos.ColumnCount = 2;
            this.tlpAgendamentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.01852F));
            this.tlpAgendamentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.98148F));
            this.tlpAgendamentos.Controls.Add(this.lblIdUsuario, 0, 0);
            this.tlpAgendamentos.Controls.Add(this.txtIdUsuario, 1, 0);
            this.tlpAgendamentos.Controls.Add(this.lblIdHospital, 0, 1);
            this.tlpAgendamentos.Controls.Add(this.lblLocal, 0, 2);
            this.tlpAgendamentos.Controls.Add(this.txtLocal, 1, 2);
            this.tlpAgendamentos.Controls.Add(this.lblObservacao, 0, 3);
            this.tlpAgendamentos.Controls.Add(this.txtObservacao, 1, 3);
            this.tlpAgendamentos.Controls.Add(this.dtpDoacao, 1, 1);
            this.tlpAgendamentos.Location = new System.Drawing.Point(1, 59);
            this.tlpAgendamentos.Name = "tlpAgendamentos";
            this.tlpAgendamentos.RowCount = 4;
            this.tlpAgendamentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAgendamentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAgendamentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAgendamentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAgendamentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgendamentos.Size = new System.Drawing.Size(432, 215);
            this.tlpAgendamentos.TabIndex = 30;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblIdUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblIdUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblIdUsuario.Location = new System.Drawing.Point(37, 20);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(60, 13);
            this.lblIdUsuario.TabIndex = 5;
            this.lblIdUsuario.Text = "IdUsuário:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdUsuario.Location = new System.Drawing.Point(137, 16);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(292, 20);
            this.txtIdUsuario.TabIndex = 17;
            // 
            // lblIdHospital
            // 
            this.lblIdHospital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdHospital.AutoSize = true;
            this.lblIdHospital.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblIdHospital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblIdHospital.Location = new System.Drawing.Point(21, 73);
            this.lblIdHospital.Name = "lblIdHospital";
            this.lblIdHospital.Size = new System.Drawing.Size(92, 13);
            this.lblIdHospital.TabIndex = 7;
            this.lblIdHospital.Text = "Data de Doação:";
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblLocal.Location = new System.Drawing.Point(49, 126);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(36, 13);
            this.lblLocal.TabIndex = 8;
            this.lblLocal.Text = "Local:";
            this.lblLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocal.Location = new System.Drawing.Point(137, 122);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(292, 20);
            this.txtLocal.TabIndex = 20;
            // 
            // lblObservacao
            // 
            this.lblObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblObservacao.Location = new System.Drawing.Point(32, 180);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(70, 13);
            this.lblObservacao.TabIndex = 12;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacao.Location = new System.Drawing.Point(137, 177);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(292, 20);
            this.txtObservacao.TabIndex = 24;
            // 
            // dtpDoacao
            // 
            this.dtpDoacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDoacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoacao.Location = new System.Drawing.Point(137, 69);
            this.dtpDoacao.Name = "dtpDoacao";
            this.dtpDoacao.Size = new System.Drawing.Size(291, 20);
            this.dtpDoacao.TabIndex = 25;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 40.25F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblMensagem.Location = new System.Drawing.Point(477, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(463, 154);
            this.lblMensagem.TabIndex = 28;
            this.lblMensagem.Text = "Doações";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbAgendamentos
            // 
            this.pbAgendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAgendamentos.BackColor = System.Drawing.Color.Transparent;
            this.pbAgendamentos.Image = ((System.Drawing.Image)(resources.GetObject("pbAgendamentos.Image")));
            this.pbAgendamentos.Location = new System.Drawing.Point(464, 177);
            this.pbAgendamentos.Name = "pbAgendamentos";
            this.pbAgendamentos.Size = new System.Drawing.Size(500, 500);
            this.pbAgendamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAgendamentos.TabIndex = 29;
            this.pbAgendamentos.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnExcluir.Location = new System.Drawing.Point(302, 8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnCadastrar.Location = new System.Drawing.Point(26, 8);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 280);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 39);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEditar.Location = new System.Drawing.Point(164, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(53, 374);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(376, 281);
            this.dgvLista.TabIndex = 40;
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPdf.Location = new System.Drawing.Point(308, 347);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(120, 21);
            this.btnPdf.TabIndex = 42;
            this.btnPdf.Text = "Exportar para PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // frmDoacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(937, 660);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.lblListagem);
            this.Controls.Add(this.tlpAgendamentos);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbAgendamentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoacoes";
            this.Text = "Doações";
            this.tlpAgendamentos.ResumeLayout(false);
            this.tlpAgendamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgendamentos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblListagem;
        private System.Windows.Forms.TableLayoutPanel tlpAgendamentos;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblIdHospital;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox pbAgendamentos;
        private System.Windows.Forms.DateTimePicker dtpDoacao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPdf;
    }
}