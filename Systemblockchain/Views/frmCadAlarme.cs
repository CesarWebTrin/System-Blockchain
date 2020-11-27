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
    public partial class frmCadAlarme : Form
    {
        Alarme obj = new Alarme();
        public frmCadAlarme()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            try
            {
                obj.Titulo = txtTitulo.Text;
                obj.Data_alerta = Convert.ToDateTime(dtAlarme.Text);
                obj.Texto = txtDesc.Text;
                int x = AlarmeModel.Inserir(obj);
                if(x > 0)
                {
                    MessageBox.Show("Inserido com sucesso ");
                }
                else
                {
                    MessageBox.Show("Alarme não cadastrado ");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Alarme não cadastrado" + ex);
            }
        }
    }
}
