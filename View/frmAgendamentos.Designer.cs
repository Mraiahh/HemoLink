namespace SistDoacaoSangue.View
{
    partial class frmAgendamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendamentos));
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdHospital = new System.Windows.Forms.Label();
            this.txtIdHospital = new System.Windows.Forms.TextBox();
            this.lblDataAgendada = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblListagem = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.tlpAgendamentos = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDataAgendada = new System.Windows.Forms.DateTimePicker();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pbAgendamentos = new System.Windows.Forms.PictureBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnPdf = new System.Windows.Forms.Button();
            this.tlpAgendamentos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgendamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
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
            this.lblIdHospital.Location = new System.Drawing.Point(35, 73);
            this.lblIdHospital.Name = "lblIdHospital";
            this.lblIdHospital.Size = new System.Drawing.Size(63, 13);
            this.lblIdHospital.TabIndex = 7;
            this.lblIdHospital.Text = "IdHospital:";
            // 
            // txtIdHospital
            // 
            this.txtIdHospital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdHospital.Location = new System.Drawing.Point(137, 69);
            this.txtIdHospital.Name = "txtIdHospital";
            this.txtIdHospital.Size = new System.Drawing.Size(292, 20);
            this.txtIdHospital.TabIndex = 19;
            // 
            // lblDataAgendada
            // 
            this.lblDataAgendada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataAgendada.AutoSize = true;
            this.lblDataAgendada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDataAgendada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblDataAgendada.Location = new System.Drawing.Point(22, 126);
            this.lblDataAgendada.Name = "lblDataAgendada";
            this.lblDataAgendada.Size = new System.Drawing.Size(90, 13);
            this.lblDataAgendada.TabIndex = 8;
            this.lblDataAgendada.Text = "Data Agendada:";
            this.lblDataAgendada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCadastro
            // 
            this.lblCadastro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblCadastro.Location = new System.Drawing.Point(30, -11);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(392, 53);
            this.lblCadastro.TabIndex = 26;
            this.lblCadastro.Text = "Cadastro";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblListagem
            // 
            this.lblListagem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblListagem.BackColor = System.Drawing.Color.Transparent;
            this.lblListagem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblListagem.Location = new System.Drawing.Point(37, 321);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(385, 49);
            this.lblListagem.TabIndex = 25;
            this.lblListagem.Text = "Listagem";
            this.lblListagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblStatus.Location = new System.Drawing.Point(46, 180);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatus.Location = new System.Drawing.Point(137, 177);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(292, 20);
            this.txtStatus.TabIndex = 24;
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
            this.tlpAgendamentos.Controls.Add(this.txtIdHospital, 1, 1);
            this.tlpAgendamentos.Controls.Add(this.lblDataAgendada, 0, 2);
            this.tlpAgendamentos.Controls.Add(this.lblStatus, 0, 3);
            this.tlpAgendamentos.Controls.Add(this.txtStatus, 1, 3);
            this.tlpAgendamentos.Controls.Add(this.dtpDataAgendada, 1, 2);
            this.tlpAgendamentos.Location = new System.Drawing.Point(12, 45);
            this.tlpAgendamentos.Name = "tlpAgendamentos";
            this.tlpAgendamentos.RowCount = 4;
            this.tlpAgendamentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAgendamentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAgendamentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAgendamentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAgendamentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgendamentos.Size = new System.Drawing.Size(432, 215);
            this.tlpAgendamentos.TabIndex = 23;
            // 
            // dtpDataAgendada
            // 
            this.dtpDataAgendada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDataAgendada.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dtpDataAgendada.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtpDataAgendada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtpDataAgendada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataAgendada.Location = new System.Drawing.Point(139, 121);
            this.dtpDataAgendada.Name = "dtpDataAgendada";
            this.dtpDataAgendada.Size = new System.Drawing.Size(288, 22);
            this.dtpDataAgendada.TabIndex = 25;
            this.dtpDataAgendada.Value = new System.DateTime(2025, 5, 24, 17, 59, 1, 0);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnExcluir.Location = new System.Drawing.Point(292, 8);
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
            this.btnEditar.Location = new System.Drawing.Point(158, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 279);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 39);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnCadastrar.Location = new System.Drawing.Point(24, 8);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 23);
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
            this.lblMensagem.Location = new System.Drawing.Point(517, 2);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(463, 165);
            this.lblMensagem.TabIndex = 30;
            this.lblMensagem.Text = "Agendamentos";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbAgendamentos
            // 
            this.pbAgendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAgendamentos.BackColor = System.Drawing.Color.Transparent;
            this.pbAgendamentos.Image = ((System.Drawing.Image)(resources.GetObject("pbAgendamentos.Image")));
            this.pbAgendamentos.Location = new System.Drawing.Point(498, 167);
            this.pbAgendamentos.Name = "pbAgendamentos";
            this.pbAgendamentos.Size = new System.Drawing.Size(500, 500);
            this.pbAgendamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAgendamentos.TabIndex = 31;
            this.pbAgendamentos.TabStop = false;
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(37, 373);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(404, 274);
            this.dgvLista.TabIndex = 40;
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPdf.Location = new System.Drawing.Point(304, 346);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(134, 21);
            this.btnPdf.TabIndex = 41;
            this.btnPdf.Text = "Exportar para PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // frmAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(976, 659);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.pbAgendamentos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.lblListagem);
            this.Controls.Add(this.tlpAgendamentos);
            this.Name = "frmAgendamentos";
            this.Text = "Agendamentos";
            this.tlpAgendamentos.ResumeLayout(false);
            this.tlpAgendamentos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAgendamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblIdHospital;
        private System.Windows.Forms.TextBox txtIdHospital;
        private System.Windows.Forms.Label lblDataAgendada;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblListagem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TableLayoutPanel tlpAgendamentos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpDataAgendada;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox pbAgendamentos;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPdf;
    }
}