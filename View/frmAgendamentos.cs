using System;
using System.Linq;
using System.Windows.Forms;
using SistDoacaoSangue.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections.Generic;

namespace SistDoacaoSangue.View
{
    public partial class frmAgendamentos : Form
    {
        public frmAgendamentos()
        {
            InitializeComponent();
            CarregarAgendamentos();

            // Associar o evento SelectionChanged do DataGridView
            dgvLista.SelectionChanged += dgvLista_SelectionChanged;
        }

        private void ConfigurarDataGridView()
        {
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.MultiSelect = false;
            dgvLista.AllowUserToAddRows = false;
            dgvLista.ReadOnly = true;

            dgvLista.Columns.Clear();

            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "IdAgendamento",
                HeaderText = "ID Agendamento",
                DataPropertyName = "IdAgendamento",
                Visible = false
            });

            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "IdUsuario",
                HeaderText = "ID Usuário",
                DataPropertyName = "IdUsuario"
            });

            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "IdHospital",
                HeaderText = "ID Hospital",
                DataPropertyName = "IdHospital"
            });

            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "DataAgendada",
                HeaderText = "Data Agendada",
                DataPropertyName = "DataAgendada"
            });

            dgvLista.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            dgvLista.Columns["DataAgendada"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void CarregarAgendamentos()
        {
            AgendamentosDAO dao = new AgendamentosDAO();
            var lista = dao.ReadAll();

            var dadosGrid = lista.Select(a => new
            {
                a.IdAgendamento,
                IdUsuario = a.Usuario.IdUsuario,
                IdHospital = a.Hospital.IdHospital,
                a.DataAgendada,
                a.Status
            }).ToList();

            dgvLista.DataSource = dadosGrid;
        }

        private void frmAgendamentos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CarregarAgendamentos();
        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvLista.SelectedRows[0];

                txtIdUsuario.Text = row.Cells["IdUsuario"].Value.ToString();
                txtIdHospital.Text = row.Cells["IdHospital"].Value.ToString();
                dtpDataAgendada.Value = Convert.ToDateTime(row.Cells["DataAgendada"].Value);
                txtStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Agendamentos ag = new Agendamentos
            {
                Usuario = new Usuario { IdUsuario = int.Parse(txtIdUsuario.Text) },
                Hospital = new Hospitais { IdHospital = int.Parse(txtIdHospital.Text) },
                DataAgendada = dtpDataAgendada.Value,
                Status = txtStatus.Text
            };

            bool sucesso = new AgendamentosDAO().Create(ag);

            if (sucesso)
                MessageBox.Show("Agendamento cadastrado!");
            else
                MessageBox.Show("Erro ao cadastrar.");

            CarregarAgendamentos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                int idAgendamento = Convert.ToInt32(dgvLista.SelectedRows[0].Cells["IdAgendamento"].Value);

                Agendamentos ag = new Agendamentos
                {
                    IdAgendamento = idAgendamento,
                    Usuario = new Usuario { IdUsuario = int.Parse(txtIdUsuario.Text) },
                    Hospital = new Hospitais { IdHospital = int.Parse(txtIdHospital.Text) },
                    DataAgendada = dtpDataAgendada.Value,
                    Status = txtStatus.Text
                };

                bool sucesso = new AgendamentosDAO().Update(ag);

                if (sucesso)
                    MessageBox.Show("Agendamento atualizado!");
                else
                    MessageBox.Show("Erro ao atualizar.");

                CarregarAgendamentos();
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para editar.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                int idAgendamento = Convert.ToInt32(dgvLista.SelectedRows[0].Cells["IdAgendamento"].Value);
                bool sucesso = new AgendamentosDAO().Delete(idAgendamento);

                if (sucesso)
                    MessageBox.Show("Agendamento excluído.");
                else
                    MessageBox.Show("Erro ao excluir.");

                CarregarAgendamentos();
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para excluir.");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            // Cria uma janela para o usuário escolher onde salvar o PDF
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "PDF (*.pdf)|*.pdf"; // Filtra apenas arquivos PDF
            salvar.FileName = "Agendamentos.pdf"; // Nome do arquivo

            // Se o usuário escolher um local e confirmar
            if (salvar.ShowDialog() == DialogResult.OK)
            {
                try
                {   // Cria um documento PDF no formato A4
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(salvar.FileName, FileMode.Create)); // Cria o escritor PDF
                    doc.Open();

                    // Cria uma tabela com o mesmo número de colunas do DGV
                    PdfPTable tabela = new PdfPTable(dgvLista.Columns.Count);
                    tabela.WidthPercentage = 100; // Largura da tabela = 100% da pagina

                    // Adiciona os cabeçalhos das colunas do DGV na tabela
                    List<DataGridViewColumn> colunasVisiveis = new List<DataGridViewColumn>();
                    Font fonteNegrito = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10); // Fonte em negrito
                    BaseColor corCinza = new BaseColor(230, 230, 230); //Cor cinza
                    foreach (DataGridViewColumn coluna in dgvLista.Columns)
                    {
                        if (coluna.Visible)
                        {
                            colunasVisiveis.Add(coluna);
                            PdfPCell cell = new PdfPCell(new Phrase(coluna.HeaderText, fonteNegrito));
                            cell.BackgroundColor = corCinza; // Definiu como a cor de fundo
                            cell.HorizontalAlignment = Element.ALIGN_CENTER; // Centraliza o texto
                            tabela.AddCell(cell); // Adiciona a celula do cabeçalho
                        }

                    }

                    // Percorre todas as linhas do DGV
                    foreach (DataGridViewRow linha in dgvLista.Rows)
                    {
                        if (linha.IsNewRow) continue; // Ignora a linha de inserção nova

                        // Percorre todas as células da linha 
                        for(int i=0; i< linha.Cells.Count; i++)
                        {
                            if (dgvLista.Columns[i].Visible) // Verifica se a coluna está visível
                                tabela.AddCell(linha.Cells[i].Value?.ToString()); //Adiciona o valor da célula à tabela
                        }
                    }

                    // Adiciona a tabela ao documento PDF
                    doc.Add(tabela);
                    doc.Close(); // Fecha o documento PDF

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
