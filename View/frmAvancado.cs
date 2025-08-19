using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using SistDoacaoSangue.Util;
using System.Drawing;
using SistDoacaoSangue.DAO;
using SistDoacaoSangue.Models;
using System.Collections.Generic;
using System.Linq;


namespace SistDoacaoSangue.View
{
    public partial class frmAvancado : Form
    {
        string connString = Conexao.GetConnectionString();

        public frmAvancado()
        {
            InitializeComponent();
            this.Load += frmAvancado_Load; // registra o evento Load
        }

        private void frmAvancado_Load(object sender, EventArgs e)
        {
            CarregarGraficoPizzaTipoSanguineo();
            CarregarGraficoBarraDoacoesPorMes();
        }

        private void CarregarGraficoPizzaTipoSanguineo()
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> listaUsuarios = usuarioDAO.ReadAll();

            // Agrupa e conta por tipo sanguíneo
            var dadosGrafico = listaUsuarios
                .GroupBy(u => u.TipoSanguineo)
                .Select(g => new { Tipo = g.Key, Quantidade = g.Count() })
                .OrderBy(g => g.Tipo)
                .ToList();

            // Limpa dados do gráfico pizza antes de usar
            chartPizza.Series.Clear();
            chartPizza.ChartAreas.Clear();

            // Cria área para o gráfico
            ChartArea area = new ChartArea();
            chartPizza.ChartAreas.Add(area);

            // Cria a série em formato pizza
            Series serie = new Series();
            serie.Name = "TiposSanguineos";
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true; // mostra valor na fatia
            serie.LabelFormat = "{0} ({1})"; // mostra quantidade e legenda (opcional)

            chartPizza.Series.Add(serie);

            // Define os dados para a série
            foreach (var item in dadosGrafico)
            {
                int pointIndex = serie.Points.AddY(item.Quantidade);
                serie.Points[pointIndex].LegendText = item.Tipo;
                serie.Points[pointIndex].Label = $"{item.Tipo}: {item.Quantidade}";
            }
        }

        private void CarregarGraficoBarraDoacoesPorMes()
        {

            try
            {
                // Instancia o DAO
                DoacoesDAO dao = new DoacoesDAO();

                // Busca todas as doações do banco
                List<Doacoes> doacoes = dao.ReadAll();

                // Agrupa as doações por ano e mês e conta quantas em cada mês
                var doacoesPorMes = doacoes
                    .GroupBy(d => new { d.DataDoacao.Year, d.DataDoacao.Month })
                    .Select(g => new
                    {
                        AnoMes = new DateTime(g.Key.Year, g.Key.Month, 1),
                        Quantidade = g.Count()
                    })
                    .OrderBy(x => x.AnoMes)
                    .ToList();

                // Limpa séries anteriores do gráfico
                chartBarra.Series.Clear();

                // Cria a série de barras
                Series serie = new Series("Doações por mês");
                serie.ChartType = SeriesChartType.Column;

                // Adiciona os pontos da série (labels: "MMM/yyyy", valores: quantidade de doações)
                foreach (var item in doacoesPorMes)
                {
                    string label = item.AnoMes.ToString("MMM/yyyy");
                    serie.Points.AddXY(label, item.Quantidade);
                }

                // Adiciona a série no gráfico
                chartBarra.Series.Add(serie);

                // Configurações visuais opcionais
                chartBarra.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chartBarra.ChartAreas[0].AxisX.Interval = 1;
                chartBarra.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
                chartBarra.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar gráfico: " + ex.Message);
            }
        }
        
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Filter = "Arquivo SQL (*.sql)|*.sql";
                salvar.Title = "Salvar Backup";
                salvar.FileName = "backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".sql";

                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    string caminho = salvar.FileName;
                    string connString = Conexao.GetConnectionString(); // novo método

                    MySqlBackupHelper backup = new MySqlBackupHelper(connString);
                    backup.FazerBackup(caminho);

                    MessageBox.Show("Backup salvo com sucesso!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer backup:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog abrir = new OpenFileDialog();
                abrir.Filter = "Arquivo SQL (*.sql)|*.sql";
                abrir.Title = "Selecionar Arquivo de Backup";

                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    string caminho = abrir.FileName;
                    string connString = Conexao.GetConnectionString();

                    MySqlBackupHelper backup = new MySqlBackupHelper(connString);
                    backup.RestaurarBackup(caminho);

                    MessageBox.Show("Backup restaurado com sucesso!", "Restauração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar backup:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
