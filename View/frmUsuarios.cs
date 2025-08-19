using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using SistDoacaoSangue.DAO;
using SistDoacaoSangue.Models;

namespace SistDoacaoSangue.View
{
    public partial class frmUsuarios : Form
    {
        private UsuarioDAO usuarioDAO;
        private Usuario usuarioSelecionado = null; // Guarda o usuário da linha selecionada

        public frmUsuarios()
        {
            InitializeComponent();
            usuarioDAO = new UsuarioDAO();
            CarregarUsuarios();
            btnEditar.Click += btnEditar_Click;
            lblImportar.Click += lblImportar_Click;

        }

        private void CarregarUsuarios()
        {
            List<Usuario> usuarios = usuarioDAO.ReadAll();
            dgvLista.DataSource = null;
            dgvLista.DataSource = usuarios;

            // Esconder colunas indesejadas, exemplo:
            if (dgvLista.Columns["Senha"] != null)
                dgvLista.Columns["Senha"].Visible = false;

            dgvLista.AutoResizeColumns();
        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow != null)
            {
                usuarioSelecionado = (Usuario)dgvLista.CurrentRow.DataBoundItem;
            }
            else
            {
                usuarioSelecionado = null;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarUsuarios();
            MessageBox.Show("Lista de usuários atualizada!");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado == null)
            {
                MessageBox.Show("Selecione um usuário para editar.");
                return;
            }

            // Passa o usuário selecionado para o formulário de edição
            frmEditarUsuario frm = new frmEditarUsuario(usuarioSelecionado);

            // Mostra o formulário como diálogo modal
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Depois de editar e salvar, recarrega os usuários na tabela
                CarregarUsuarios();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }

            var resposta = MessageBox.Show(
                "Tem certeza que deseja excluir este usuário?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta == DialogResult.Yes)
            {
                if (usuarioDAO.Delete(usuarioSelecionado.IdUsuario))
                {
                    MessageBox.Show("Usuário excluído com sucesso!");
                    CarregarUsuarios();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o usuário.");
                }
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLista.Rows[e.RowIndex];

                usuarioSelecionado = new Usuario();
                usuarioSelecionado.IdUsuario = Convert.ToInt32(row.Cells["idUsuario"].Value);
                // pode preencher outros campos se quiser, mas para deletar basta o id

                // Opcional: limpa visualmente a linha clicada
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
        }

        private void lblImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos CSV (*.csv)|*.csv";
            ofd.Title = "Selecione o arquivo CSV com os usuários";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportarUsuariosCSV(ofd.FileName);
                    CarregarUsuarios(); // Atualiza a grid após importar
                    MessageBox.Show("Usuários importados com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao importar usuários: " + ex.Message);
                }
            }
        }

        private void ImportarUsuariosCSV(string caminhoArquivo)
        {
            using (var reader = new System.IO.StreamReader(caminhoArquivo))
            {
                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();
                    var colunas = linha.Split(',');

                    if (colunas.Length < 12)
                        throw new Exception("Formato do CSV inválido. Esperado: Nome,Senha,Email,DataNascimento,Sexo,TipoSanguineo,Cidade,Estado,DataUltimaDoacao,StatusDoador,Aptidao,Telefone");

                    Usuario novoUsuario = new Usuario
                    {
                        NomeUsuario = colunas[0].Trim(),
                        SenhaUsuario = colunas[1].Trim(),
                        Email = colunas[2].Trim(),
                        DataNascimento = DateTime.Parse(colunas[3].Trim()),
                        Sexo = colunas[4].Trim(),
                        TipoSanguineo = colunas[5].Trim(),
                        Cidade = colunas[6].Trim(),
                        Estado = colunas[7].Trim(),
                        DataUltimaDoacao = DateTime.Parse(colunas[8].Trim()),
                        StatusDoador = colunas[9].Trim(),
                        Aptidao = colunas[10].Trim(),
                        Telefone = colunas[11].Trim()
                    };

                    usuarioDAO.Create(novoUsuario);
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "PDF (*.pdf)|*.pdf";
            salvar.FileName = "Usuarios.pdf";

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

