using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSiscola
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fechar();

        }

        private void frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            fechar();
        }
        public void fechar()
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Deseja Realmente Sair", "Atenção", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastrofuncionario cadastro = new frm_cadastrofuncionario();
            cadastro.Show();
        }
    }
}
