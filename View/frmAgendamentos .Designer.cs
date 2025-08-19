namespace SistDoacaoSangue.View
{
    partial class frmHospitais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHospitais));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pbHospital = new System.Windows.Forms.PictureBox();
            this.tlpHospitais = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomeHospital = new System.Windows.Forms.Label();
            this.txtNomeHospital = new System.Windows.Forms.TextBox();
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.lblListagem = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHospital)).BeginInit();
            this.tlpHospitais.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 40.25F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.Location = new System.Drawing.Point(540, -8);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(463, 362);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Hospitais";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbHospital
            // 
            this.pbHospital.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHospital.BackColor = System.Drawing.Color.Transparent;
            this.pbHospital.Image = ((System.Drawing.Image)(resources.GetObject("pbHospital.Image")));
            this.pbHospital.Location = new System.Drawing.Point(696, 357);
            this.pbHospital.Name = "pbHospital";
            this.pbHospital.Size = new System.Drawing.Size(307, 328);
            this.pbHospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHospital.TabIndex = 1;
            this.pbHospital.TabStop = false;
            // 
            // tlpHospitais
            // 
            this.tlpHospitais.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpHospitais.AutoSize = true;
            this.tlpHospitais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.tlpHospitais.ColumnCount = 2;
            this.tlpHospitais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.01852F));
            this.tlpHospitais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.98148F));
            this.tlpHospitais.Controls.Add(this.lblNomeHospital, 0, 0);
            this.tlpHospitais.Controls.Add(this.txtNomeHospital, 1, 0);
            this.tlpHospitais.Controls.Add(this.lblEmailUsuario, 0, 1);
            this.tlpHospitais.Controls.Add(this.txtEmailUsuario, 1, 1);
            this.tlpHospitais.Controls.Add(this.lblTelefone, 0, 2);
            this.tlpHospitais.Controls.Add(this.txtTelefone, 1, 2);
            this.tlpHospitais.Controls.Add(this.lblCidade, 0, 3);
            this.tlpHospitais.Controls.Add(this.txtCidade, 1, 3);
            this.tlpHospitais.Controls.Add(this.lblEstado, 0, 4);
            this.tlpHospitais.Controls.Add(this.txtEstado, 1, 4);
            this.tlpHospitais.Location = new System.Drawing.Point(12, 54);
            this.tlpHospitais.Name = "tlpHospitais";
            this.tlpHospitais.RowCount = 5;
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHospitais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHospitais.Size = new System.Drawing.Size(432, 215);
            this.tlpHospitais.TabIndex = 16;
            // 
            // lblNomeHospital
            // 
            this.lblNomeHospital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeHospital.AutoSize = true;
            this.lblNomeHospital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblNomeHospital.Location = new System.Drawing.Point(48, 15);
            this.lblNomeHospital.Name = "lblNomeHospital";
            this.lblNomeHospital.Size = new System.Drawing.Size(38, 13);
            this.lblNomeHospital.TabIndex = 5;
            this.lblNomeHospital.Text = "Nome:";
            // 
            // txtNomeHospital
            // 
            this.txtNomeHospital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeHospital.Location = new System.Drawing.Point(137, 11);
            this.txtNomeHospital.Name = "txtNomeHospital";
            this.txtNomeHospital.Size = new System.Drawing.Size(292, 20);
            this.txtNomeHospital.TabIndex = 17;
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Location = new System.Drawing.Point(49, 58);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblEmailUsuario.TabIndex = 7;
            this.lblEmailUsuario.Text = "Email:";
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailUsuario.Location = new System.Drawing.Point(137, 54);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(292, 20);
            this.txtEmailUsuario.TabIndex = 19;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(41, 101);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone.Location = new System.Drawing.Point(137, 97);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(292, 20);
            this.txtTelefone.TabIndex = 20;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(45, 144);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.Location = new System.Drawing.Point(137, 140);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(292, 20);
            this.txtCidade.TabIndex = 24;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(45, 187);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstado.Location = new System.Drawing.Point(137, 183);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(292, 20);
            this.txtEstado.TabIndex = 25;
            // 
            // lbLista
            // 
            this.lbLista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(56, 382);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(388, 290);
            this.lbLista.TabIndex = 17;
            // 
            // lblListagem
            // 
            this.lblListagem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblListagem.BackColor = System.Drawing.Color.Transparent;
            this.lblListagem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblListagem.Location = new System.Drawing.Point(56, 272);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(385, 107);
            this.lblListagem.TabIndex = 18;
            this.lblListagem.Text = "Listagem";
            this.lblListagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCadastro
            // 
            this.lblCadastro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblCadastro.Location = new System.Drawing.Point(49, -2);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(392, 53);
            this.lblCadastro.TabIndex = 19;
            this.lblCadastro.Text = "Cadastro";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnAtualizar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 288);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 39);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizar.Location = new System.Drawing.Point(26, 8);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Location = new System.Drawing.Point(149, 8);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Location = new System.Drawing.Point(277, 8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // frmHospitais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1001, 684);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.lblListagem);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.tlpHospitais);
            this.Controls.Add(this.pbHospital);
            this.Controls.Add(this.lblMensagem);
            this.Name = "frmHospitais";
            this.Text = "Hospitais";
            ((System.ComponentModel.ISupportInitialize)(this.pbHospital)).EndInit();
            this.tlpHospitais.ResumeLayout(false);
            this.tlpHospitais.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox pbHospital;
        private System.Windows.Forms.TableLayoutPanel tlpHospitais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.Label lblNomeHospital;
        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNomeHospital;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Label lblListagem;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
    }
}