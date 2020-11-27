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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'blockchainDataSet1.Projecao_Futura'. Você pode movê-la ou removê-la conforme necessário.
            this.projecao_FuturaTableAdapter.Fill(this.blockchainDataSet1.Projecao_Futura);
            // TODO: esta linha de código carrega dados na tabela 'blockchainDataSet1.criptoativo'. Você pode movê-la ou removê-la conforme necessário.
            this.criptoativoTableAdapter.Fill(this.blockchainDataSet1.criptoativo);
            // TODO: esta linha de código carrega dados na tabela 'blockchainDataSet1.Cliente_inativos'. Você pode movê-la ou removê-la conforme necessário.
            this.cliente_inativosTableAdapter.Fill(this.blockchainDataSet1.Cliente_inativos);
            // TODO: esta linha de código carrega dados na tabela 'blockchainDataSet1.Cliente_ativos'. Você pode movê-la ou removê-la conforme necessário.
            this.cliente_ativosTableAdapter.Fill(this.blockchainDataSet1.Cliente_ativos);
            // TODO: esta linha de código carrega dados na tabela 'blockchainDataSet1.Carteira_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.carteira_clienteTableAdapter.Fill(this.blockchainDataSet1.Carteira_cliente);

            this.reportCarteira.RefreshReport();
            this.reportAtivos.RefreshReport();
            this.reportInativos.RefreshReport();
            this.reportCriptoativo.RefreshReport();
            this.reportProjecao.RefreshReport();
        }

        private void btnAlarme_Click(object sender, EventArgs e)
        {
            frmCadAlarme Alarme = new frmCadAlarme();
            Alarme.Show();
        }

        private void btnCarteira_Click(object sender, EventArgs e)
        {
            reportCarteira.Enabled = true;
            reportCarteira.Visible = true;

            reportInativos.Enabled = false;
            reportInativos.Visible = false;
            reportAtivos.Enabled = false;
            reportAtivos.Visible = false;
            reportCriptoativo.Enabled = false;
            reportCriptoativo.Visible = false;
            reportProjecao.Enabled = false;
            reportProjecao.Visible = false;
        }

        private void btnAtivos_Click(object sender, EventArgs e)
        {

            reportAtivos.Enabled = true;
            reportAtivos.Visible = true;

            reportInativos.Enabled = false;
            reportInativos.Visible = false;
            reportCriptoativo.Enabled = false;
            reportCriptoativo.Visible = false;
            reportCarteira.Enabled = false;
            reportCarteira.Visible = false;
            reportProjecao.Enabled = false;
            reportProjecao.Visible = false;

        }

        private void btnInativos_Click(object sender, EventArgs e)
        {
            reportInativos.Enabled = true;
            reportInativos.Visible = true;

            reportCarteira.Enabled = false;
            reportCarteira.Visible = false;
            reportAtivos.Enabled = false;
            reportAtivos.Visible = false;
            reportCriptoativo.Enabled = false;
            reportCriptoativo.Visible = false;
            reportProjecao.Enabled = false;
            reportProjecao.Visible = false;
        }

        private void btnCriptoativo_Click(object sender, EventArgs e)
        {
            reportCriptoativo.Enabled = true;
            reportCriptoativo.Visible = true;

            reportInativos.Enabled = false;
            reportInativos.Visible = false;
            reportCarteira.Enabled = false;
            reportCarteira.Visible = false;
            reportAtivos.Enabled = false;
            reportAtivos.Visible = false;
            reportProjecao.Enabled = false;
            reportProjecao.Visible = false;
        }

        private void btnProjecao_Click(object sender, EventArgs e)
        {
            reportProjecao.Enabled = true;
            reportProjecao.Visible = true;

            reportCriptoativo.Enabled = false;
            reportCriptoativo.Visible = false;
            reportInativos.Enabled = false;
            reportInativos.Visible = false;
            reportCarteira.Enabled = false;
            reportCarteira.Visible = false;
            reportAtivos.Enabled = false;
            reportAtivos.Visible = false;
        }

        
    }
}
