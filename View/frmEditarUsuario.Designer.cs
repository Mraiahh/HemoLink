namespace SistDoacaoSangue.View
{
    partial class frmEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarUsuario));
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNivelAcesso = new System.Windows.Forms.TextBox();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.tlpLabels = new System.Windows.Forms.TableLayoutPanel();
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.tlpLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEditar.Location = new System.Drawing.Point(371, 652);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 23);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNivelAcesso
            // 
            this.txtNivelAcesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNivelAcesso.Location = new System.Drawing.Point(137, 554);
            this.txtNivelAcesso.Name = "txtNivelAcesso";
            this.txtNivelAcesso.Size = new System.Drawing.Size(292, 20);
            this.txtNivelAcesso.TabIndex = 33;
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblNivelAcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblNivelAcesso.Location = new System.Drawing.Point(23, 557);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(88, 13);
            this.lblNivelAcesso.TabIndex = 32;
            this.lblNivelAcesso.Text = "Nivel de acesso:";
            // 
            // tlpLabels
            // 
            this.tlpLabels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpLabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.tlpLabels.ColumnCount = 2;
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.01852F));
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.98148F));
            this.tlpLabels.Controls.Add(this.txtNivelAcesso, 1, 12);
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
            this.tlpLabels.Location = new System.Drawing.Point(177, 58);
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
            this.tlpLabels.TabIndex = 18;
            // 
            // cbSexo
            // 
            this.cbSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbSexo.Location = new System.Drawing.Point(137, 237);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(292, 21);
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
            this.cbTipoSanguineo.Location = new System.Drawing.Point(137, 282);
            this.cbTipoSanguineo.Name = "cbTipoSanguineo";
            this.cbTipoSanguineo.Size = new System.Drawing.Size(292, 21);
            this.cbTipoSanguineo.TabIndex = 30;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDataNascimento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(137, 191);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(292, 22);
            this.dtpDataNascimento.TabIndex = 17;
            // 
            // dtpUltimaDoacao
            // 
            this.dtpUltimaDoacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpUltimaDoacao.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtpUltimaDoacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUltimaDoacao.Location = new System.Drawing.Point(137, 416);
            this.dtpUltimaDoacao.Name = "dtpUltimaDoacao";
            this.dtpUltimaDoacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpUltimaDoacao.Size = new System.Drawing.Size(292, 22);
            this.dtpUltimaDoacao.TabIndex = 16;
            // 
            // txtAptidao
            // 
            this.txtAptidao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAptidao.Location = new System.Drawing.Point(137, 507);
            this.txtAptidao.Name = "txtAptidao";
            this.txtAptidao.Size = new System.Drawing.Size(292, 20);
            this.txtAptidao.TabIndex = 28;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstado.Location = new System.Drawing.Point(137, 372);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(292, 20);
            this.txtEstado.TabIndex = 25;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.Location = new System.Drawing.Point(137, 327);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(292, 20);
            this.txtCidade.TabIndex = 24;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone.Location = new System.Drawing.Point(137, 147);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(292, 20);
            this.txtTelefone.TabIndex = 20;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailUsuario.Location = new System.Drawing.Point(137, 102);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(292, 20);
            this.txtEmailUsuario.TabIndex = 19;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaUsuario.Location = new System.Drawing.Point(137, 57);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(292, 20);
            this.txtSenhaUsuario.TabIndex = 18;
            this.txtSenhaUsuario.UseSystemPasswordChar = true;
            // 
            // lblAptidao
            // 
            this.lblAptidao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAptidao.AutoSize = true;
            this.lblAptidao.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblAptidao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblAptidao.Location = new System.Drawing.Point(29, 511);
            this.lblAptidao.Name = "lblAptidao";
            this.lblAptidao.Size = new System.Drawing.Size(75, 13);
            this.lblAptidao.TabIndex = 16;
            this.lblAptidao.Text = "Apto/Motivo:";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblNomeUsuario.Location = new System.Drawing.Point(47, 16);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(40, 13);
            this.lblNomeUsuario.TabIndex = 5;
            this.lblNomeUsuario.Text = "Nome:";
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSenhaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblSenhaUsuario.Location = new System.Drawing.Point(46, 61);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(42, 13);
            this.lblSenhaUsuario.TabIndex = 6;
            this.lblSenhaUsuario.Text = "Senha:";
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblEmailUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblEmailUsuario.Location = new System.Drawing.Point(48, 106);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(37, 13);
            this.lblEmailUsuario.TabIndex = 7;
            this.lblEmailUsuario.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblTelefone.Location = new System.Drawing.Point(40, 151);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(54, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDataNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblDataNascimento.Location = new System.Drawing.Point(28, 196);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(77, 13);
            this.lblDataNascimento.TabIndex = 9;
            this.lblDataNascimento.Text = "Data de Nasc:";
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblSexo.Location = new System.Drawing.Point(50, 241);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblTipoSanguineo
            // 
            this.lblTipoSanguineo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoSanguineo.AutoSize = true;
            this.lblTipoSanguineo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTipoSanguineo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblTipoSanguineo.Location = new System.Drawing.Point(21, 286);
            this.lblTipoSanguineo.Name = "lblTipoSanguineo";
            this.lblTipoSanguineo.Size = new System.Drawing.Size(92, 13);
            this.lblTipoSanguineo.TabIndex = 11;
            this.lblTipoSanguineo.Text = "Tipo Sanguíneo:";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblCidade.Location = new System.Drawing.Point(44, 331);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(46, 13);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblEstado.Location = new System.Drawing.Point(44, 376);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 13);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado:";
            // 
            // lblUltimaDoacao
            // 
            this.lblUltimaDoacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUltimaDoacao.AutoSize = true;
            this.lblUltimaDoacao.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblUltimaDoacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblUltimaDoacao.Location = new System.Drawing.Point(25, 421);
            this.lblUltimaDoacao.Name = "lblUltimaDoacao";
            this.lblUltimaDoacao.Size = new System.Drawing.Size(84, 13);
            this.lblUltimaDoacao.TabIndex = 14;
            this.lblUltimaDoacao.Text = "Última doação:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblStatus.Location = new System.Drawing.Point(46, 466);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeUsuario.Location = new System.Drawing.Point(137, 12);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(292, 20);
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
            this.cbStatus.Location = new System.Drawing.Point(137, 462);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(292, 21);
            this.cbStatus.TabIndex = 29;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblMensagem.Enabled = false;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblMensagem.Location = new System.Drawing.Point(12, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(776, 42);
            this.lblMensagem.TabIndex = 17;
            this.lblMensagem.Text = "EDITAR CADASTRO:";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tlpLabels);
            this.Controls.Add(this.lblMensagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarUsuario";
            this.Text = "Editar";
            this.tlpLabels.ResumeLayout(false);
            this.tlpLabels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNivelAcesso;
        private System.Windows.Forms.Label lblNivelAcesso;
        private System.Windows.Forms.TableLayoutPanel tlpLabels;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbTipoSanguineo;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpUltimaDoacao;
        private System.Windows.Forms.TextBox txtAptidao;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label lblAptidao;
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblMensagem;
    }
}