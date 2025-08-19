using System;
using System.Linq;
using System.Windows.Forms;
using SistDoacaoSangue.Models;
using SistDoacaoSangue.DAO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Collections.Generic;

namespace SistDoacaoSangue.View
{
    public partial class frmDoacoes : Form
    {
        public frmDoacoes()
        {
            InitializeComponent();

            // Associa eventos
            this.Load += frmDoacoes_Load;
            dgvLista.SelectionChanged += dgvLista_SelectionChanged;
            btnCadastrar.Click += btnCadastrar_Click;
            btnEditar.Click += btnEditar_Click;
            btnExcluir.Click += btnExcluir_Click;
        }

        private void frmDoacoes_Load(object sender, EventArgs e)
        {
            CarregarDoacoes();
        }

        private void CarregarDoacoes()
        {
            DoacoesDAO dao = new DoacoesDAO();
            var lista = dao.ReadAll();

            var dadosGrid = lista.Select(d => new
            {
                d.IdDoacao,
                IdUsuario = d.Usuario != null ? d.Usuario.IdUsuario : 0,
                d.DataDoacao,
                d.Local,
                d.Observacao
            }).ToList();

            dgvLista.DataSource = null;
            dgvLista.DataSource = dadosGrid;
            dgvLista.Refresh();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Doacoes doacao = new Doacoes
            {
                Usuario = new Usuario { IdUsuario = int.Parse(txtIdUsuario.Text) },
                DataDoacao = dtpDoacao.Value,
                Local = txtLocal.Text,
                Observacao = txtObservacao.Text
            };

            bool sucesso = new DoacoesDAO().Create(doacao);

            if (sucesso)
                MessageBox.Show("Doação cadastrada com sucesso!");
            else
                MessageBox.Show("Erro ao cadastrar a doação.");

            CarregarDoacoes();
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                int idDoacao = Convert.ToInt32(dgvLista.SelectedRows[0].Cells["IdDoacao"].Value);

                Doacoes doacao = new Doacoes
                {
                    IdDoacao = idDoacao,
                    Usuario = new Usuario { IdUsuario = int.Parse(txtIdUsuario.Text) },
                    DataDoacao = dtpDoacao.Value,
                    Local = txtLocal.Text,
                    Observacao = txtObservacao.Text
                };

                bool sucesso = new DoacoesDAO().Update(doacao);

                if (sucesso)
                    MessageBox.Show("Doação atualizada com sucesso!");
                else
                    MessageBox.Show("Erro ao atualizar a doação.");

                CarregarDoacoes();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione uma doação para editar.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                int idDoacao = Convert.ToInt32(dgvLista.SelectedRows[0].Cells["IdDoacao"].Value);
                bool sucesso = new DoacoesDAO().Delete(idDoacao);

                if (sucesso)
                    MessageBox.Show("Doação excluída com sucesso.");
                else
                    MessageBox.Show("Erro ao excluir a doação.");

                CarregarDoacoes();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione uma doação para excluir.");
            }
        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                var row = dgvLista.SelectedRows[0];
                txtIdUsuario.Text = row.Cells["IdUsuario"].Value.ToString();
                dtpDoacao.Value = Convert.ToDateTime(row.Cells["DataDoacao"].Value);
                txtLocal.Text = row.Cells["Local"].Value.ToString();
                txtObservacao.Text = row.Cells["Observacao"].Value.ToString();
            }
        }

        private void LimparCampos()
        {
            txtIdUsuario.Clear();
            dtpDoacao.Value = DateTime.Now;
            txtLocal.Clear();
            txtObservacao.Clear();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "PDF (*.pdf)|*.pdf"; 
            salvar.FileName = "Doacoes.pdf"; 

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                try
                {   
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(salvar.FileName, FileMode.Create)); 
                    doc.Open();

                    PdfPTable tabela = new PdfPTable(dgvLista.Columns.Count);
                    tabela.WidthPercentage = 100;

                    List<DataGridViewColumn> colunasVisiveis = new List<DataGridViewColumn>();
                    Font fonteNegrito = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10); 
                    BaseColor corCinza = new BaseColor(230, 230, 230); 
                    foreach (DataGridViewColumn coluna in dgvLista.Columns)
                    {
                        if (coluna.Visible)
                        {
                            colunasVisiveis.Add(coluna);
                            PdfPCell cell = new PdfPCell(new Phrase(coluna.HeaderText, fonteNegrito));
                            cell.BackgroundColor = corCinza; 
                            cell.HorizontalAlignment = Element.ALIGN_CENTER; 
                            tabela.AddCell(cell); 
                        }

                    }

                    foreach (DataGridViewRow linha in dgvLista.Rows)
                    {
                        if (linha.IsNewRow) continue; 

                        for (int i = 0; i < linha.Cells.Count; i++)
                        {
                            if (dgvLista.Columns[i].Visible) 
                                tabela.AddCell(linha.Cells[i].Value?.ToString()); 
                        }
                    }

                    doc.Add(tabela);
                    doc.Close(); 

                    MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao gerar PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
