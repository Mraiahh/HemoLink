using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistDoacaoSangue.Models;

namespace SistDoacaoSangue.View
{
    public partial class frmHome : Form
    {

        public Usuario usuarioLogado;
        public frmHome()
        {
            InitializeComponent();


            // Define este formulário como MDI Pai
            this.IsMdiContainer = true;

            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.FromArgb(255, 233, 224);
                    break;
                }
            }
        }


        // Método para ocultar os controles
        private void OcultarControles()
        {
            lblMensagem.Visible = false;
            pbFoto.Visible = false;
        }

        // Método para mostrar os controles
        private void MostrarControles()
        {
            lblMensagem.Visible = true;
            pbFoto.Visible = true;
        }

        private void hospitaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarControles();

            frmHospitais hospitais = new frmHospitais();
            hospitais.MdiParent = this;

            // Assina o evento para saber quando o frmHospitais fechar
            hospitais.FormClosed += frmHospitais_FormClosed;

            hospitais.Show();
        }

        private void frmHospitais_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarControles();

            frmAgendamentos agendamentos = new frmAgendamentos();
            agendamentos.MdiParent = this;

            // Assina o evento para saber quando o frmHospitais fechar
            agendamentos.FormClosed += frmAgendamentos_FormClosed;

            agendamentos.Show();
        }

        private void frmAgendamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }

        private void doaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarControles();

            frmDoacoes doacoes = new frmDoacoes();
            doacoes.MdiParent = this;

            // Assina o evento para saber quando o frmHospitais fechar
            doacoes.FormClosed += frmDoacoes_FormClosed;

            doacoes.Show();
        }

        private void frmDoacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarControles();

            frmUsuarios usuarios = new frmUsuarios();
            usuarios.MdiParent = this;

            usuarios.FormClosed += frmUsuarios_FormClosed;

            usuarios.Show();
        }

        private void frmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }

        private void avançadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarControles();

            frmAvancado usuarios = new frmAvancado();
            usuarios.MdiParent = this;

            usuarios.FormClosed += frmAvancado_FormClosed;

            usuarios.Show();
        }

        private void frmAvancado_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }

        private void solicitaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarControles();

            frmSolicitacoes solicitacoes = new frmSolicitacoes();
            solicitacoes.MdiParent = this;

            // Assina o evento para saber quando o frmHospitais fechar
            solicitacoes.FormClosed += frmSolicitacoes_FormClosed;

            solicitacoes.Show();

        }
        private void frmSolicitacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }

        public frmHome(Usuario usuario) : this()
        {
            usuarioLogado = usuario;

            if (usuarioLogado.NivelAcesso != "Administrador")
            {
                gerenciamentoToolStripMenuItem.Visible = false;
            }
        }
    }
}
