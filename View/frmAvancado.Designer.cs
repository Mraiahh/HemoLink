namespace SistDoacaoSangue.View
{
    partial class frmAvancado
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvancado));
            this.btnBackup = new System.Windows.Forms.Button();
            this.tlpLabels = new System.Windows.Forms.TableLayoutPanel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.chartBarra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPizza = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBackup.Location = new System.Drawing.Point(150, 13);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(95, 23);
            this.btnBackup.TabIndex = 19;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // tlpLabels
            // 
            this.tlpLabels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpLabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.tlpLabels.ColumnCount = 2;
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLabels.Controls.Add(this.btnRestore, 1, 0);
            this.tlpLabels.Controls.Add(this.btnBackup, 0, 0);
            this.tlpLabels.Location = new System.Drawing.Point(12, 134);
            this.tlpLabels.Name = "tlpLabels";
            this.tlpLabels.RowCount = 1;
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpLabels.Size = new System.Drawing.Size(790, 49);
            this.tlpLabels.TabIndex = 18;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnRestore.Location = new System.Drawing.Point(545, 13);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(95, 23);
            this.btnRestore.TabIndex = 20;
            this.btnRestore.Text = "Restaurar";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblMensagem.Enabled = false;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblMensagem.Location = new System.Drawing.Point(12, 89);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(790, 42);
            this.lblMensagem.TabIndex = 17;
            this.lblMensagem.Text = "BACKUP / RESTAURAR:";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGrafico
            // 
            this.lblGrafico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblGrafico.Enabled = false;
            this.lblGrafico.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblGrafico.Location = new System.Drawing.Point(12, 233);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(790, 42);
            this.lblGrafico.TabIndex = 19;
            this.lblGrafico.Text = "VISUALIZAR INFORMAÇÕES:";
            this.lblGrafico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chartBarra
            // 
            this.chartBarra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.chartBarra.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.chartBarra.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.chartBarra.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBarra.Legends.Add(legend1);
            this.chartBarra.Location = new System.Drawing.Point(37, 357);
            this.chartBarra.Name = "chartBarra";
            this.chartBarra.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBarra.Series.Add(series1);
            this.chartBarra.Size = new System.Drawing.Size(332, 300);
            this.chartBarra.TabIndex = 20;
            this.chartBarra.Text = "chart1";
            // 
            // chartPizza
            // 
            this.chartPizza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.chartPizza.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.chartPizza.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            chartArea2.Name = "ChartArea1";
            this.chartPizza.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPizza.Legends.Add(legend2);
            this.chartPizza.Location = new System.Drawing.Point(441, 357);
            this.chartPizza.Name = "chartPizza";
            this.chartPizza.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPizza.Series.Add(series2);
            this.chartPizza.Size = new System.Drawing.Size(341, 300);
            this.chartPizza.TabIndex = 21;
            this.chartPizza.Text = "chart2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(37, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "Doações por mês:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(441, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 42);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipos sanguíneos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmAvancado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(814, 763);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartPizza);
            this.Controls.Add(this.chartBarra);
            this.Controls.Add(this.lblGrafico);
            this.Controls.Add(this.tlpLabels);
            this.Controls.Add(this.lblMensagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAvancado";
            this.Text = "Avançado";
            this.tlpLabels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPizza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TableLayoutPanel tlpLabels;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarra;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}