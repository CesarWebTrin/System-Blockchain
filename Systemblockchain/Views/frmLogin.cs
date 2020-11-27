using Systemblockchain.Models;
using Systemblockchain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systemblockchain.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void btnCadastroShow_Click(object sender, EventArgs e)
        {
            frmCadastro Cad = new frmCadastro();
            Cad.Show();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Logar()
        {
            try
            {
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                bool x = AdministradorModel.Logar(email, senha);
                if(x == true)
                {
                    MessageBox.Show("Logado com sucesso");
                    frmReport newReport = new frmReport();
                    newReport.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dados não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível logar" + ex);
            }
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }
    }
}
