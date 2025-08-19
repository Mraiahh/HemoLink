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
using SistDoacaoSangue.View;

namespace SistDoacaoSangue
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuarioLogado = dao.Autenticar(email, senha);

            if (usuarioLogado != null)
            {
                MessageBox.Show("Login realizado com sucesso!");
                this.Hide();
                frmHome home = new frmHome(usuarioLogado);
                home.ShowDialog();
                this.Close();
                // Suponha que o login está correto

            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmCadastrar cadastro = new frmCadastrar();
            cadastro.ShowDialog(); // Ou Show() se quiser não-modal
        }
    }
}
