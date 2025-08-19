using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using SistDoacaoSangue.DAO;
using SistDoacaoSangue.Models;
using System.Collections.Generic;

namespace SistDoacaoSangue.View
{
    public partial class frmSolicitacoes : Form
    {
        public frmSolicitacoes()
        {
            InitializeComponent();
        }

        // Carrega as solicitações ao abrir o formulário
        private void frmSolicitacoes_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CarregarSolicitacoes();
        }

        // Configura o DataGridView para seleção única e preenchimento correto
        private void ConfigurarDataGridView()
        {
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.MultiSelect = false;
            dgvLista.AllowUserToAddRows = false;
            dgvLista.ReadOnly = true;

            // Limpa colunas atuais
            dgvLista.Columns.Clear();

            // Cria colunas correspondentes aos campos da entidade
            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "IdSolicitacao",
                HeaderText = "ID Solicitação",
                DataPropertyName = "IdSolicitacao"
            });
            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "IdHospital",
                HeaderText = "ID Hospital",
                DataPropertyName = "IdHospital"
            });
            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TipoSanguineo",
                HeaderText = "Tipo Sanguíneo",
                DataPropertyName = "TipoSanguineo"
            });
            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "QtdNecessaria",
                HeaderText = "Quantidade Necessária",
                DataPropertyName = "QtdNecessaria"
            });
            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "DataSolicitacao",
                HeaderText = "Data da Solicitação",
                DataPropertyName = "DataSolicitacao"
            });
            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status"
            });
        }

        // Carrega os dados no GridView
        private void CarregarSolicitacoes()
        {
            SolicitacoesDAO dao = new SolicitacoesDAO();
            var lista = dao.ReadAll();

            dgvLista.DataSource = lista.Select(s => new
            {
                s.IdSolicitacao,
                IdHospital = s.Hospital.IdHospital,
                s.TipoSanguineo,
                s.QtdNecessaria,
                DataSolicitacao = s.DataSolicitacao.ToString("dd/MM/yyyy"),
                s.Status
            }).ToList();
        }

        // Valida os campos antes de cadastrar/editar
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtIdHospital.Text))
            {
                MessageBox.Show("Informe o ID do Hospital.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbTipoSanguineo.Text))
            {
                MessageBox.Show("Selecione o tipo sanguíneo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQtdNecessaria.Text))
            {
                MessageBox.Show("Informe a quantidade necessária.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Informe o status.");
                return false;
            }

            return true;
        }

        // Preenche os campos ao selecionar uma linha
        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ignora cliques no cabeçalho
            {
                DataGridViewRow row = dgvLista.Rows[e.RowIndex];
                txtIdHospital.Text = row.Cells["IdHospital"].Value?.ToString();
                cbTipoSanguineo.Text = row.Cells["TipoSanguineo"].Value?.ToString();
                txtQtdNecessaria.Text = row.Cells["QtdNecessaria"].Value?.ToString();

                if (DateTime.TryParseExact(
                    row.Cells["DataSolicitacao"].Value?.ToString(),
                    "dd/MM/yyyy",
                    null,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime data))
                {
                    dtpDataDoacao.Value = data;
                }

                txtStatus.Text = row.Cells["Status"].Value?.ToString();
            }
        }

        // Cadastra uma nova solicitação
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var solicitacao = new Solicitacoes
            {
                Hospital = new Hospitais { IdHospital = int.Parse(txtIdHospital.Text) },
                TipoSanguineo = cbTipoSanguineo.Text,
                QtdNecessaria = txtQtdNecessaria.Text,
                DataSolicitacao = dtpDataDoacao.Value,
                Status = txtStatus.Text
            };

            bool sucesso = new SolicitacoesDAO().Create(solicitacao);

            if (sucesso)
            {
                MessageBox.Show("Cadastrado com sucesso!");
                CarregarSolicitacoes();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar.");
            }
        }

        // Edita uma solicitação existente
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma solicitação para editar.");
                return;
            }

            if (!ValidarCampos()) return;

            int idSolicitacao = Convert.ToInt32(dgvLista.SelectedRows[0].Cells["IdSolicitacao"].Value);

            var solicitacao = new Solicitacoes
            {
                IdSolicitacao = idSolicitacao,
                Hospital = new Hospitais { IdHospital = int.Parse(txtIdHospital.Text) },
                TipoSanguineo = cbTipoSanguineo.Text,
                QtdNecessaria = txtQtdNecessaria.Text,
                DataSolicitacao = dtpDataDoacao.Value,
                Status = txtStatus.Text
            };

            bool sucesso = new SolicitacoesDAO().Update(solicitacao);

            if (sucesso)
            {
                MessageBox.Show("Atualizado com sucesso!");
                CarregarSolicitacoes();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar.");
            }
        }

        // Exclui uma solicitação
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma solicitação para excluir.");
                return;
            }

            int idSolicitacao = Convert.ToInt32(dgvLista.SelectedRows[0].Cells["IdSolicitacao"].Value);

            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool sucesso = new SolicitacoesDAO().Delete(idSolicitacao);

                if (sucesso)
                {
                    MessageBox.Show("Excluído com sucesso!");
                    CarregarSolicitacoes();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir.");
                }
            }
        }

        // Limpa os campos
        private void LimparCampos()
        {
            txtIdHospital.Clear();
            cbTipoSanguineo.SelectedIndex = -1;
            txtQtdNecessaria.Clear();
            dtpDataDoacao.Value = DateTime.Now;
            txtStatus.Clear();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "PDF (*.pdf)|*.pdf";
            salvar.FileName = "Solicitacoes.pdf";

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