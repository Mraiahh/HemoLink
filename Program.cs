using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistDoacaoSangue.View;

namespace SistDoacaoSangue
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Exibe o formulário de login como diálogo
            frmInicio login = new frmInicio();
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Se o login for bem-sucedido, abre o frmHome
                Application.Run(new frmHome());
            }
        }
    }
}
