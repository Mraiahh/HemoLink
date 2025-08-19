using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SistDoacaoSangue.DAO;
using SistDoacaoSangue.Models;

namespace SistDoacaoSangue.View
{
    public partial class frmEditarUsuario : Form
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();
        private int idUsuario;

        public frmEditarUsuario()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        public frmEditarUsuario(Usuario usuario) : this()
        {
            if (usuario == null)
            {
                MessageBox.Show("Nenhum usuário foi selecionado para edição.", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            CarregarDadosUsuario(usuario);
        }

        private void ConfigurarControles()
        {
            // Configuração dos DateTimePicker
            dtpDataNascimento.MinDate = new DateTime(1900, 1, 1);
            dtpDataNascimento.MaxDate = DateTime.Today.AddYears(-16); // Mínimo 16 anos
            dtpDataNascimento.Value = DateTime.Today.AddYears(-18); // Valor padrão 18 anos

            dtpUltimaDoacao.MinDate = new DateTime(2000, 1, 1);
            dtpUltimaDoacao.MaxDate = DateTime.Today;
            dtpUltimaDoacao.Value = DateTime.Today;

            // Preenchimento dos ComboBoxes
            cbSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro" });
            cbTipoSanguineo.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cbStatus.Items.AddRange(new object[] { "Ativo", "Inativo", "Suspenso", "Pendente" });

            // Seleciona o primeiro item por padrão
            cbSexo.SelectedIndex = 0;
            cbTipoSanguineo.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }

        private void CarregarDadosUsuario(Usuario usuario)
        {
            try
            {
                // Verificação básica
                if (usuario == null) return;

                // Armazena o ID
                idUsuario = usuario.IdUsuario;

                // Preenche todos os campos de texto
                txtNomeUsuario.Text = usuario.NomeUsuario ?? string.Empty;
                txtSenhaUsuario.Text = usuario.SenhaUsuario ?? string.Empty;
                txtEmailUsuario.Text = usuario.Email ?? string.Empty;
                txtCidade.Text = usuario.Cidade ?? string.Empty;
                txtEstado.Text = usuario.Estado ?? string.Empty;
                txtAptidao.Text = usuario.Aptidao ?? string.Empty;
                txtTelefone.Text = usuario.Telefone ?? string.Empty;
                txtNivelAcesso.Text = usuario.NivelAcesso ?? string.Empty;

                // Preenche datas com validação
                if (usuario.DataNascimento > DateTime.MinValue &&
                    usuario.DataNascimento >= dtpDataNascimento.MinDate)
                {
                    dtpDataNascimento.Value = usuario.DataNascimento;
                }

                if (usuario.DataUltimaDoacao > DateTime.MinValue &&
                    usuario.DataUltimaDoacao >= dtpUltimaDoacao.MinDate)
                {
                    dtpUltimaDoacao.Value = usuario.DataUltimaDoacao;
                }

                // Preenche ComboBoxes com verificação
                if (!string.IsNullOrEmpty(usuario.Sexo))
                {
                    int index = cbSexo.FindStringExact(usuario.Sexo);
                    cbSexo.SelectedIndex = index >= 0 ? index : 0;
                }

                if (!string.IsNullOrEmpty(usuario.TipoSanguineo))
                {
                    int index = cbTipoSanguineo.FindStringExact(usuario.TipoSanguineo);
                    cbTipoSanguineo.SelectedIndex = index >= 0 ? index : 0;
                }

                if (!string.IsNullOrEmpty(usuario.StatusDoador))
                {
                    int index = cbStatus.FindStringExact(usuario.StatusDoador);
                    cbStatus.SelectedIndex = index >= 0 ? index : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            // Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text))
            {
                MessageBox.Show("O nome do usuário é obrigatório!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeUsuario.Focus();
                return false;
            }

            // Validação de e-mail
            if (!ValidarEmail(txtEmailUsuario.Text))
            {
                MessageBox.Show("Por favor, insira um e-mail válido (deve conter @ e .)!",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailUsuario.Focus();
                return false;
            }

            // Validação de senha
            if (txtSenhaUsuario.Text.Length < 8)
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaUsuario.Focus();
                return false;
            }

            // Validação de tipo sanguíneo
            if (cbTipoSanguineo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um tipo sanguíneo válido!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTipoSanguineo.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Regex para validar e-mail básico
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                Usuario usuarioAtualizado = new Usuario
                {
                    IdUsuario = idUsuario,
                    NomeUsuario = txtNomeUsuario.Text.Trim(),
                    SenhaUsuario = txtSenhaUsuario.Text,
                    Email = txtEmailUsuario.Text.Trim(),
                    DataNascimento = dtpDataNascimento.Value,
                    Sexo = cbSexo.SelectedItem?.ToString(),
                    TipoSanguineo = cbTipoSanguineo.SelectedItem?.ToString(),
                    Cidade = txtCidade.Text.Trim(),
                    Estado = txtEstado.Text.Trim(),
                    DataUltimaDoacao = dtpUltimaDoacao.Value,
                    StatusDoador = cbStatus.SelectedItem?.ToString(),
                    Aptidao = txtAptidao.Text.Trim(),
                    Telefone = txtTelefone.Text.Trim(),
                    NivelAcesso = txtNivelAcesso.Text.Trim()
                };

                if (usuarioDAO.Update(usuarioAtualizado))
                {
                    MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o usuário no banco de dados.", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar alterações: {ex.Message}", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, backspace e alguns caracteres especiais de telefone
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}