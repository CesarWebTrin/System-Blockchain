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
    public partial class frmCadastro : Form
    {
        Administrador obj = new Administrador();
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void Cadastrar()
        {
            try
            {
                obj.Nome = txtNome.Text;
                obj.Data_nasc = Convert.ToDateTime(dtNasc.Text);
                obj.Cpf = txtCpf.Text;
                obj.Estado = txtEstado.Text;
                obj.Cidade = txtCidade.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cep = txtCep.Text;
                obj.Rua = txtRua.Text;
                obj.Numero = txtNumero.Text;
                obj.Email = txtEmail.Text;
                obj.Senha = txtSenha.Text;
                int x = AdministradorModel.Inserir(obj);
                if(x > 0)
                {
                    MessageBox.Show("Usuário Cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Usuário não cadastrado" + ex);
            }
        }

        private void frmCadastro_Load_1(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            txtConfSenha.PasswordChar = '*';
        }
    }
}
