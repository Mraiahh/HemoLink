namespace SistDoacaoSangue.View
{
    partial class frmCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrar));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTipoSanguineo = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUltimaDoacao = new System.Windows.Forms.Label();
            this.tlpLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbTipoSanguineo = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.dtpUltimaDoacao = new System.Windows.Forms.DateTimePicker();
            this.txtAptidao = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.lblAptidao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.tlpLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblMensagem.Enabled = false;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblMensagem.Location = new System.Drawing.Point(12, 13);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(971, 42);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "     CADASTRO:";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblNomeUsuario.Location = new System.Drawing.Point(42, 13);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(49, 19);
            this.lblNomeUsuario.TabIndex = 5;
            this.lblNomeUsuario.Text = "Nome:";
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblSenhaUsuario.Location = new System.Drawing.Point(42, 58);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(49, 19);
            this.lblSenhaUsuario.TabIndex = 6;
            this.lblSenhaUsuario.Text = "Senha:";
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblEmailUsuario.Location = new System.Drawing.Point(45, 103);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(44, 19);
            this.lblEmailUsuario.TabIndex = 7;
            this.lblEmailUsuario.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblTelefone.Location = new System.Drawing.Point(36, 148);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 19);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblDataNascimento.Location = new System.Drawing.Point(20, 193);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(93, 19);
            this.lblDataNascimento.TabIndex = 9;
            this.lblDataNascimento.Text = "Data de Nasc:";
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblSexo.Location = new System.Drawing.Point(47, 238);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 19);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblTipoSanguineo
            // 
            this.lblTipoSanguineo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoSanguineo.AutoSize = true;
            this.lblTipoSanguineo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblTipoSanguineo.Location = new System.Drawing.Point(14, 283);
            this.lblTipoSanguineo.Name = "lblTipoSanguineo";
            this.lblTipoSanguineo.Size = new System.Drawing.Size(106, 19);
            this.lblTipoSanguineo.TabIndex = 11;
            this.lblTipoSanguineo.Text = "Tipo Sanguíneo:";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblCidade.Location = new System.Drawing.Point(40, 328);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 19);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblEstado.Location = new System.Drawing.Point(40, 373);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 19);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado:";
            // 
            // lblUltimaDoacao
            // 
            this.lblUltimaDoacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUltimaDoacao.AutoSize = true;
            this.lblUltimaDoacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblUltimaDoacao.Location = new System.Drawing.Point(17, 418);
            this.lblUltimaDoacao.Name = "lblUltimaDoacao";
            this.lblUltimaDoacao.Size = new System.Drawing.Size(100, 19);
            this.lblUltimaDoacao.TabIndex = 14;
            this.lblUltimaDoacao.Text = "Última doação:";
            // 
            // tlpLabels
            // 
            this.tlpLabels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpLabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.tlpLabels.ColumnCount = 2;
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.01852F));
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.98148F));
            this.tlpLabels.Controls.Add(this.lblNivelAcesso, 0, 12);
            this.tlpLabels.Controls.Add(this.cbSexo, 1, 5);
            this.tlpLabels.Controls.Add(this.cbTipoSanguineo, 1, 6);
            this.tlpLabels.Controls.Add(this.dtpDataNascimento, 1, 4);
            this.tlpLabels.Controls.Add(this.dtpUltimaDoacao, 1, 9);
            this.tlpLabels.Controls.Add(this.txtAptidao, 1, 11);
            this.tlpLabels.Controls.Add(this.txtEstado, 1, 8);
            this.tlpLabels.Controls.Add(this.txtCidade, 1, 7);
            this.tlpLabels.Controls.Add(this.txtTelefone, 1, 3);
            this.tlpLabels.Controls.Add(this.txtEmailUsuario, 1, 2);
            this.tlpLabels.Controls.Add(this.txtSenhaUsuario, 1, 1);
            this.tlpLabels.Controls.Add(this.lblAptidao, 0, 11);
            this.tlpLabels.Controls.Add(this.lblNomeUsuario, 0, 0);
            this.tlpLabels.Controls.Add(this.lblSenhaUsuario, 0, 1);
            this.tlpLabels.Controls.Add(this.lblEmailUsuario, 0, 2);
            this.tlpLabels.Controls.Add(this.lblTelefone, 0, 3);
            this.tlpLabels.Controls.Add(this.lblDataNascimento, 0, 4);
            this.tlpLabels.Controls.Add(this.lblSexo, 0, 5);
            this.tlpLabels.Controls.Add(this.lblTipoSanguineo, 0, 6);
            this.tlpLabels.Controls.Add(this.lblCidade, 0, 7);
            this.tlpLabels.Controls.Add(this.lblEstado, 0, 8);
            this.tlpLabels.Controls.Add(this.lblUltimaDoacao, 0, 9);
            this.tlpLabels.Controls.Add(this.lblStatus, 0, 10);
            this.tlpLabels.Controls.Add(this.txtNomeUsuario, 1, 0);
            this.tlpLabels.Controls.Add(this.cbStatus, 1, 10);
            this.tlpLabels.Controls.Add(this.cbNivelAcesso, 1, 12);
            this.tlpLabels.Location = new System.Drawing.Point(274, 58);
            this.tlpLabels.Name = "tlpLabels";
            this.tlpLabels.RowCount = 13;
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.689466F));
            this.tlpLabels.Size = new System.Drawing.Size(432, 588);
            this.tlpLabels.TabIndex = 15;
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblNivelAcesso.Location = new System.Drawing.Point(14, 554);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(105, 19);
            this.lblNivelAcesso.TabIndex = 32;
            this.lblNivelAcesso.Text = "Nivel de acesso:";
            // 
            // cbSexo
            // 
            this.cbSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbSexo.Location = new System.Drawing.Point(137, 235);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(292, 27);
            this.cbSexo.TabIndex = 31;
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
            this.cbTipoSanguineo.Location = new System.Drawing.Point(137, 280);
            this.cbTipoSanguineo.Name = "cbTipoSanguineo";
            this.cbTipoSanguineo.Size = new System.Drawing.Size(292, 27);
            this.cbTipoSanguineo.TabIndex = 30;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDataNascimento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(137, 189);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(292, 26);
            this.dtpDataNascimento.TabIndex = 17;
            // 
            // dtpUltimaDoacao
            // 
            this.dtpUltimaDoacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpUltimaDoacao.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtpUltimaDoacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUltimaDoacao.Location = new System.Drawing.Point(137, 414);
            this.dtpUltimaDoacao.Name = "dtpUltimaDoacao";
            this.dtpUltimaDoacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpUltimaDoacao.Size = new System.Drawing.Size(292, 26);
            this.dtpUltimaDoacao.TabIndex = 16;
            // 
            // txtAptidao
            // 
            this.txtAptidao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAptidao.Location = new System.Drawing.Point(137, 504);
            this.txtAptidao.Name = "txtAptidao";
            this.txtAptidao.Size = new System.Drawing.Size(292, 26);
            this.txtAptidao.TabIndex = 28;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstado.Location = new System.Drawing.Point(137, 369);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(292, 26);
            this.txtEstado.TabIndex = 25;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.Location = new System.Drawing.Point(137, 324);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(292, 26);
            this.txtCidade.TabIndex = 24;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone.Location = new System.Drawing.Point(137, 144);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(292, 26);
            this.txtTelefone.TabIndex = 20;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailUsuario.Location = new System.Drawing.Point(137, 99);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(292, 26);
            this.txtEmailUsuario.TabIndex = 19;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaUsuario.Location = new System.Drawing.Point(137, 54);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(292, 26);
            this.txtSenhaUsuario.TabIndex = 18;
            this.txtSenhaUsuario.UseSystemPasswordChar = true;
            // 
            // lblAptidao
            // 
            this.lblAptidao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAptidao.AutoSize = true;
            this.lblAptidao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblAptidao.Location = new System.Drawing.Point(21, 508);
            this.lblAptidao.Name = "lblAptidao";
            this.lblAptidao.Size = new System.Drawing.Size(91, 19);
            this.lblAptidao.TabIndex = 16;
            this.lblAptidao.Text = "Apto/Motivo:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblStatus.Location = new System.Drawing.Point(42, 463);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 19);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeUsuario.Location = new System.Drawing.Point(137, 9);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(292, 26);
            this.txtNomeUsuario.TabIndex = 17;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Doador",
            "Não Doador"});
            this.cbStatus.Location = new System.Drawing.Point(137, 460);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(292, 27);
            this.cbStatus.TabIndex = 29;
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Items.AddRange(new object[] {
            "Usuário Comum",
            "Administrador"});
            this.cbNivelAcesso.Location = new System.Drawing.Point(137, 552);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(292, 27);
            this.cbNivelAcesso.TabIndex = 33;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnCadastro.Location = new System.Drawing.Point(468, 652);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(95, 23);
            this.btnCadastro.TabIndex = 16;
            this.btnCadastro.Text = "Cadastrar!";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(995, 701);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.tlpLabels);
            this.Controls.Add(this.lblMensagem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrar";
            this.Text = "Cadastro";
            this.tlpLabels.ResumeLayout(false);
            this.tlpLabels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTipoSanguineo;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUltimaDoacao;
        private System.Windows.Forms.TableLayoutPanel tlpLabels;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAptidao;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtAptidao;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbTipoSanguineo;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpUltimaDoacao;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label lblNivelAcesso;
        private System.Windows.Forms.ComboBox cbNivelAcesso;
    }
}