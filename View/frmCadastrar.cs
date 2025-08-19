using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistDoacaoSangue.DAO;
using SistDoacaoSangue.Models;

namespace SistDoacaoSangue.View
{
    public partial class frmCadastrar : Form
    {

        public frmCadastrar()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            // Verifica campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtAptidao.Text) ||
                string.IsNullOrWhiteSpace(txtEstado.Text) ||
                string.IsNullOrWhiteSpace(txtCidade.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEmailUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtSenhaUsuario.Text) ||
                cbStatus.SelectedIndex == -1 ||
                cbTipoSanguineo.SelectedIndex == -1 ||
                cbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação de email
            if (!txtEmailUsuario.Text.Contains("@") || !txtEmailUsuario.Text.Contains("."))
            {
                MessageBox.Show("Digite um email válido!", "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação de telefone: apenas números e 10 ou mais dígitos
            string telefone = txtTelefone.Text.Trim();
            if (!telefone.All(char.IsDigit) || telefone.Length < 8)
            {
                MessageBox.Show("Digite um telefone válido com pelo menos 10 números!", "Telefone inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação de senha: mínimo 6 caracteres
            if (txtSenhaUsuario.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres!", "Senha fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validação de data de nascimento
            if (dtpDataNascimento.Value > DateTime.Now || dtpDataNascimento.Value < new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Data de nascimento inválida!", "Data inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario
            {
                NomeUsuario = txtNomeUsuario.Text,
                SenhaUsuario = txtSenhaUsuario.Text,
                Email = txtEmailUsuario.Text,
                DataNascimento = dtpDataNascimento.Value,
                Sexo = cbSexo.SelectedItem.ToString(),
                TipoSanguineo = cbTipoSanguineo.SelectedItem.ToString(),
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                DataUltimaDoacao = dtpUltimaDoacao.Value,
                StatusDoador = cbStatus.SelectedItem.ToString(),
                Aptidao = txtAptidao.Text,
                Telefone = txtTelefone.Text,
                NivelAcesso = cbNivelAcesso.SelectedItem.ToString()

            };

            try
            {
                UsuarioDAO dao = new UsuarioDAO();
                dao.Create(usuario);
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // ou limpar campos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
