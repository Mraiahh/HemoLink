namespace SistDoacaoSangue.View
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ínicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avançadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ínicioToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.gerenciamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ínicioToolStripMenuItem
            // 
            this.ínicioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ínicioToolStripMenuItem.Name = "ínicioToolStripMenuItem";
            this.ínicioToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ínicioToolStripMenuItem.Text = "Ínicio";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendamentosToolStripMenuItem,
            this.solicitaçõesToolStripMenuItem});
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            this.agendamentosToolStripMenuItem.Click += new System.EventHandler(this.agendamentosToolStripMenuItem_Click);
            // 
            // solicitaçõesToolStripMenuItem
            // 
            this.solicitaçõesToolStripMenuItem.Name = "solicitaçõesToolStripMenuItem";
            this.solicitaçõesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solicitaçõesToolStripMenuItem.Text = "Solicitações";
            this.solicitaçõesToolStripMenuItem.Click += new System.EventHandler(this.solicitaçõesToolStripMenuItem_Click);
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospitaisToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.doaçõesToolStripMenuItem,
            this.avançadoToolStripMenuItem});
            this.gerenciamentoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
            // 
            // hospitaisToolStripMenuItem
            // 
            this.hospitaisToolStripMenuItem.Name = "hospitaisToolStripMenuItem";
            this.hospitaisToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hospitaisToolStripMenuItem.Text = "Hospitais";
            this.hospitaisToolStripMenuItem.Click += new System.EventHandler(this.hospitaisToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // doaçõesToolStripMenuItem
            // 
            this.doaçõesToolStripMenuItem.Name = "doaçõesToolStripMenuItem";
            this.doaçõesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.doaçõesToolStripMenuItem.Text = "Doações";
            this.doaçõesToolStripMenuItem.Click += new System.EventHandler(this.doaçõesToolStripMenuItem_Click);
            // 
            // avançadoToolStripMenuItem
            // 
            this.avançadoToolStripMenuItem.Name = "avançadoToolStripMenuItem";
            this.avançadoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.avançadoToolStripMenuItem.Text = "Avançado";
            this.avançadoToolStripMenuItem.Click += new System.EventHandler(this.avançadoToolStripMenuItem_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblMensagem.Location = new System.Drawing.Point(12, 33);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(438, 514);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "OLÁ,   \r\n      SEJA BEM-VINDO(A)!";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.Location = new System.Drawing.Point(506, 56);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(494, 502);
            this.pbFoto.TabIndex = 4;
            this.pbFoto.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 556);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ínicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doaçõesToolStripMenuItem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ToolStripMenuItem avançadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitaçõesToolStripMenuItem;
    }
}