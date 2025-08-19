using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using SistDoacaoSangue.DAO;
using SistDoacaoSangue.Models;

namespace SistDoacaoSangue.View
{
    public partial class frmHospitais : Form
    {
        public frmHospitais()
        {
            InitializeComponent();
        }

        private void frmHospitais_Load(object sender, EventArgs e)
        {

        }

        private void CarregarHospitais()
        {
            HospitaisDAO dao = new HospitaisDAO();
            var lista = dao.ReadAll(); // Método que retorna List<Hospitais>

            var dadosGrid = lista.Select(h => new
            {
                h.IdHospital,
                h.Nome,
                h.Cidade,
                h.Estado,
                h.Telefone,
                h.Email
            }).ToList();

            dgvLista.DataSource = dadosGrid;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string email = txtEmailUsuario.Text.Trim();
            string telefone = txtTelefone.Text.Trim();

            // Verificação de e-mail
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Informe um e-mail válido com '@' e '.'");
                return;
            }

            // Verificação de telefone: só dígitos e pelo menos 8 números
            string telefoneNumeros = new string(telefone.Where(char.IsDigit).ToArray());
            if (telefoneNumeros.Length < 8)
            {
                MessageBox.Show("Telefone deve conter pelo menos 8 números.");
                return;
            }

            // Se tudo estiver certo, continua o cadastro
            Hospitais h = new Hospitais
            {
                Nome = txtNomeHospital.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Telefone = telefone,
                Email = email
            };

            bool sucesso = new HospitaisDAO().Create(h);

            if (sucesso)
                MessageBox.Show("Hospital cadastrado!");
            else
                MessageBox.Show("Erro ao cadastrar.");

            CarregarHospitais();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                int idHospital = Convert.ToInt32(dgvLista.SelectedRows[0].Cells["IdHospital"].Value);

                Hospitais h = new Hospitais
                {
                    IdHospital = idHospital,
                    Nome = txtNomeHospital.Text,
                    Cidade = txtCidade.Text,
                    Estado = txtEstado.Text,
                    Telefone = txtTelefone.Text,
                    Email = txtEmailUsuario.Text
                };

                bool sucesso = new HospitaisDAO().Update(h);

                if (sucesso)
                    MessageBox.Show("Hospital atualizado!");
                else
                    MessageBox.Show("Erro ao atualizar.");

                CarregarHospitais();
            }
            else
            {
                MessageBox.Show("Selecione um hospital para editar.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                int idHospital = Convert.ToInt32(dgvLista.SelectedRows[0].Cells["IdHospital"].Value);

                bool sucesso = new HospitaisDAO().Delete(idHospital);

                if (sucesso)
                    MessageBox.Show("Hospital excluído.");
                else
                    MessageBox.Show("Erro ao excluir.");

                CarregarHospitais();
            }
            else
            {
                MessageBox.Show("Selecione um hospital para excluir.");
            }
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.CurrentRow != null)
            {
                DataGridViewRow row = dgvLista.CurrentRow;
                txtNomeHospital.Text = row.Cells["Nome"].Value?.ToString();
                txtCidade.Text = row.Cells["Cidade"].Value?.ToString();
                txtEstado.Text = row.Cells["Estado"].Value?.ToString();
                txtTelefone.Text = row.Cells["Telefone"].Value?.ToString();
                txtEmailUsuario.Text = row.Cells["Email"].Value?.ToString();
            }
        }

        private void frmHospitais_Load_1(object sender, EventArgs e)
        {
            CarregarHospitais();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "PDF (*.pdf)|*.pdf";
            salvar.FileName = "Hospitais.pdf";

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
                    iTextSharp.text.Font fonteNegrito = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                    iTextSharp.text.Font fonteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
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
                            {
                                string texto = linha.Cells[i].Value?.ToString() ?? "";
                                tabela.AddCell(new Phrase(texto, fonteNormal));
                            }
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

