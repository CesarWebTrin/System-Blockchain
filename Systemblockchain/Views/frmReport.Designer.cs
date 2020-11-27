namespace Systemblockchain.Views
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.carteiraclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blockchainDataSet1 = new Systemblockchain.blockchainDataSet1();
            this.clienteinativosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criptoativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCarteira = new System.Windows.Forms.Button();
            this.btnAtivos = new System.Windows.Forms.Button();
            this.btnInativos = new System.Windows.Forms.Button();
            this.btnCriptoativo = new System.Windows.Forms.Button();
            this.btnProjecao = new System.Windows.Forms.Button();
            this.btnAlarme = new System.Windows.Forms.Button();
            this.reportCarteira = new Microsoft.Reporting.WinForms.ReportViewer();
            this.carteira_clienteTableAdapter = new Systemblockchain.blockchainDataSet1TableAdapters.Carteira_clienteTableAdapter();
            this.clienteativosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cliente_ativosTableAdapter = new Systemblockchain.blockchainDataSet1TableAdapters.Cliente_ativosTableAdapter();
            this.cliente_inativosTableAdapter = new Systemblockchain.blockchainDataSet1TableAdapters.Cliente_inativosTableAdapter();
            this.criptoativoTableAdapter = new Systemblockchain.blockchainDataSet1TableAdapters.criptoativoTableAdapter();
            this.projecaoFuturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projecao_FuturaTableAdapter = new Systemblockchain.blockchainDataSet1TableAdapters.Projecao_FuturaTableAdapter();
            this.Projecao_FuturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cliente_inativosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cliente_ativosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteativosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteativosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteativosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Carteira_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportAtivos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportInativos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportCriptoativo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportProjecao = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.carteiraclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockchainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteinativosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criptoativoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteativosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecaoFuturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projecao_FuturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente_inativosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente_ativosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteativosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteativosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteativosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carteira_clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carteiraclienteBindingSource
            // 
            this.carteiraclienteBindingSource.DataMember = "Carteira_cliente";
            this.carteiraclienteBindingSource.DataSource = this.blockchainDataSet1;
            // 
            // blockchainDataSet1
            // 
            this.blockchainDataSet1.DataSetName = "blockchainDataSet1";
            this.blockchainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteinativosBindingSource
            // 
            this.clienteinativosBindingSource.DataMember = "Cliente_inativos";
            this.clienteinativosBindingSource.DataSource = this.blockchainDataSet1;
            // 
            // criptoativoBindingSource
            // 
            this.criptoativoBindingSource.DataMember = "criptoativo";
            this.criptoativoBindingSource.DataSource = this.blockchainDataSet1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(871, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCarteira
            // 
            this.btnCarteira.BackColor = System.Drawing.Color.DimGray;
            this.btnCarteira.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCarteira.FlatAppearance.BorderSize = 2;
            this.btnCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarteira.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarteira.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCarteira.Location = new System.Drawing.Point(12, 141);
            this.btnCarteira.Name = "btnCarteira";
            this.btnCarteira.Size = new System.Drawing.Size(136, 61);
            this.btnCarteira.TabIndex = 1;
            this.btnCarteira.Text = "Carteira Investimento";
            this.btnCarteira.UseVisualStyleBackColor = false;
            this.btnCarteira.Click += new System.EventHandler(this.btnCarteira_Click);
            // 
            // btnAtivos
            // 
            this.btnAtivos.BackColor = System.Drawing.Color.DimGray;
            this.btnAtivos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtivos.FlatAppearance.BorderSize = 2;
            this.btnAtivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivos.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtivos.Location = new System.Drawing.Point(12, 223);
            this.btnAtivos.Name = "btnAtivos";
            this.btnAtivos.Size = new System.Drawing.Size(136, 61);
            this.btnAtivos.TabIndex = 2;
            this.btnAtivos.Text = "Clientes Ativos";
            this.btnAtivos.UseVisualStyleBackColor = false;
            this.btnAtivos.Click += new System.EventHandler(this.btnAtivos_Click);
            // 
            // btnInativos
            // 
            this.btnInativos.BackColor = System.Drawing.Color.DimGray;
            this.btnInativos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInativos.FlatAppearance.BorderSize = 2;
            this.btnInativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativos.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInativos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInativos.Location = new System.Drawing.Point(12, 302);
            this.btnInativos.Name = "btnInativos";
            this.btnInativos.Size = new System.Drawing.Size(136, 61);
            this.btnInativos.TabIndex = 3;
            this.btnInativos.Text = "Clientes Inativos";
            this.btnInativos.UseVisualStyleBackColor = false;
            this.btnInativos.Click += new System.EventHandler(this.btnInativos_Click);
            // 
            // btnCriptoativo
            // 
            this.btnCriptoativo.BackColor = System.Drawing.Color.DimGray;
            this.btnCriptoativo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCriptoativo.FlatAppearance.BorderSize = 2;
            this.btnCriptoativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriptoativo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptoativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCriptoativo.Location = new System.Drawing.Point(12, 379);
            this.btnCriptoativo.Name = "btnCriptoativo";
            this.btnCriptoativo.Size = new System.Drawing.Size(136, 61);
            this.btnCriptoativo.TabIndex = 4;
            this.btnCriptoativo.Text = "Criptoativo";
            this.btnCriptoativo.UseVisualStyleBackColor = false;
            this.btnCriptoativo.Click += new System.EventHandler(this.btnCriptoativo_Click);
            // 
            // btnProjecao
            // 
            this.btnProjecao.BackColor = System.Drawing.Color.DimGray;
            this.btnProjecao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProjecao.FlatAppearance.BorderSize = 2;
            this.btnProjecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjecao.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjecao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProjecao.Location = new System.Drawing.Point(12, 457);
            this.btnProjecao.Name = "btnProjecao";
            this.btnProjecao.Size = new System.Drawing.Size(136, 61);
            this.btnProjecao.TabIndex = 5;
            this.btnProjecao.Text = "Projeção Futura";
            this.btnProjecao.UseVisualStyleBackColor = false;
            this.btnProjecao.Click += new System.EventHandler(this.btnProjecao_Click);
            // 
            // btnAlarme
            // 
            this.btnAlarme.BackColor = System.Drawing.Color.DimGray;
            this.btnAlarme.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlarme.FlatAppearance.BorderSize = 2;
            this.btnAlarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarme.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlarme.Location = new System.Drawing.Point(852, 141);
            this.btnAlarme.Name = "btnAlarme";
            this.btnAlarme.Size = new System.Drawing.Size(136, 61);
            this.btnAlarme.TabIndex = 7;
            this.btnAlarme.Text = "Notificações";
            this.btnAlarme.UseVisualStyleBackColor = false;
            this.btnAlarme.Click += new System.EventHandler(this.btnAlarme_Click);
            // 
            // reportCarteira
            // 
            this.reportCarteira.Enabled = false;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Carteira_clienteBindingSource;
            this.reportCarteira.LocalReport.DataSources.Add(reportDataSource1);
            this.reportCarteira.LocalReport.ReportEmbeddedResource = "Systemblockchain.Report.ReportCarteira.rdlc";
            this.reportCarteira.Location = new System.Drawing.Point(176, 129);
            this.reportCarteira.Name = "reportCarteira";
            this.reportCarteira.ServerReport.BearerToken = null;
            this.reportCarteira.Size = new System.Drawing.Size(646, 391);
            this.reportCarteira.TabIndex = 8;
            this.reportCarteira.Visible = false;
            // 
            // carteira_clienteTableAdapter
            // 
            this.carteira_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteativosBindingSource
            // 
            this.clienteativosBindingSource.DataMember = "Cliente_ativos";
            this.clienteativosBindingSource.DataSource = this.blockchainDataSet1;
            // 
            // cliente_ativosTableAdapter
            // 
            this.cliente_ativosTableAdapter.ClearBeforeFill = true;
            // 
            // cliente_inativosTableAdapter
            // 
            this.cliente_inativosTableAdapter.ClearBeforeFill = true;
            // 
            // criptoativoTableAdapter
            // 
            this.criptoativoTableAdapter.ClearBeforeFill = true;
            // 
            // projecaoFuturaBindingSource
            // 
            this.projecaoFuturaBindingSource.DataMember = "Projecao_Futura";
            this.projecaoFuturaBindingSource.DataSource = this.blockchainDataSet1;
            // 
            // projecao_FuturaTableAdapter
            // 
            this.projecao_FuturaTableAdapter.ClearBeforeFill = true;
            // 
            // Projecao_FuturaBindingSource
            // 
            this.Projecao_FuturaBindingSource.DataMember = "Projecao_Futura";
            this.Projecao_FuturaBindingSource.DataSource = this.blockchainDataSet1;
            // 
            // Cliente_inativosBindingSource
            // 
            this.Cliente_inativosBindingSource.DataMember = "Cliente_inativos";
            this.Cliente_inativosBindingSource.DataSource = this.blockchainDataSet1;
            // 
            // Cliente_ativosBindingSource
            // 
            this.Cliente_ativosBindingSource.DataMember = "Cliente_ativos";
            this.Cliente_ativosBindingSource.DataSource = this.blockchainDataSet1;
            // 
            // clienteativosBindingSource1
            // 
            this.clienteativosBindingSource1.DataMember = "Cliente_ativos";
            this.clienteativosBindingSource1.DataSource = this.blockchainDataSet1;
            // 
            // clienteativosBindingSource2
            // 
            this.clienteativosBindingSource2.DataMember = "Cliente_ativos";
            this.clienteativosBindingSource2.DataSource = this.blockchainDataSet1;
            // 
            // clienteativosBindingSource3
            // 
            this.clienteativosBindingSource3.DataMember = "Cliente_ativos";
            this.clienteativosBindingSource3.DataSource = this.blockchainDataSet1;
            // 
            // Carteira_clienteBindingSource
            // 
            this.Carteira_clienteBindingSource.DataMember = "Carteira_cliente";
            this.Carteira_clienteBindingSource.DataSource = this.blockchainDataSet1;
            // 
            // reportAtivos
            // 
            this.reportAtivos.Enabled = false;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Cliente_ativosBindingSource;
            this.reportAtivos.LocalReport.DataSources.Add(reportDataSource2);
            this.reportAtivos.LocalReport.ReportEmbeddedResource = "Systemblockchain.Report.ReportAtivos.rdlc";
            this.reportAtivos.Location = new System.Drawing.Point(176, 129);
            this.reportAtivos.Name = "reportAtivos";
            this.reportAtivos.ServerReport.BearerToken = null;
            this.reportAtivos.Size = new System.Drawing.Size(657, 391);
            this.reportAtivos.TabIndex = 9;
            this.reportAtivos.Visible = false;
            // 
            // reportInativos
            // 
            this.reportInativos.Enabled = false;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Cliente_inativosBindingSource;
            this.reportInativos.LocalReport.DataSources.Add(reportDataSource3);
            this.reportInativos.LocalReport.ReportEmbeddedResource = "Systemblockchain.Report.reportInativos.rdlc";
            this.reportInativos.Location = new System.Drawing.Point(176, 129);
            this.reportInativos.Name = "reportInativos";
            this.reportInativos.ServerReport.BearerToken = null;
            this.reportInativos.Size = new System.Drawing.Size(657, 391);
            this.reportInativos.TabIndex = 10;
            this.reportInativos.Visible = false;
            // 
            // reportCriptoativo
            // 
            this.reportCriptoativo.Enabled = false;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.criptoativoBindingSource;
            this.reportCriptoativo.LocalReport.DataSources.Add(reportDataSource4);
            this.reportCriptoativo.LocalReport.ReportEmbeddedResource = "Systemblockchain.Report.reportCriptoativos.rdlc";
            this.reportCriptoativo.Location = new System.Drawing.Point(176, 129);
            this.reportCriptoativo.Name = "reportCriptoativo";
            this.reportCriptoativo.ServerReport.BearerToken = null;
            this.reportCriptoativo.Size = new System.Drawing.Size(657, 391);
            this.reportCriptoativo.TabIndex = 11;
            this.reportCriptoativo.Visible = false;
            // 
            // reportProjecao
            // 
            this.reportProjecao.Enabled = false;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.Projecao_FuturaBindingSource;
            this.reportProjecao.LocalReport.DataSources.Add(reportDataSource5);
            this.reportProjecao.LocalReport.ReportEmbeddedResource = "Systemblockchain.Report.reportProjecao.rdlc";
            this.reportProjecao.Location = new System.Drawing.Point(176, 129);
            this.reportProjecao.Name = "reportProjecao";
            this.reportProjecao.ServerReport.BearerToken = null;
            this.reportProjecao.Size = new System.Drawing.Size(657, 391);
            this.reportProjecao.TabIndex = 12;
            this.reportProjecao.Visible = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1049, 532);
            this.Controls.Add(this.reportProjecao);
            this.Controls.Add(this.reportCriptoativo);
            this.Controls.Add(this.reportInativos);
            this.Controls.Add(this.reportAtivos);
            this.Controls.Add(this.reportCarteira);
            this.Controls.Add(this.btnAlarme);
            this.Controls.Add(this.btnProjecao);
            this.Controls.Add(this.btnCriptoativo);
            this.Controls.Add(this.btnInativos);
            this.Controls.Add(this.btnAtivos);
            this.Controls.Add(this.btnCarteira);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmReport";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carteiraclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockchainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteinativosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criptoativoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteativosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecaoFuturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projecao_FuturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente_inativosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente_ativosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteativosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteativosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteativosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carteira_clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCarteira;
        private System.Windows.Forms.Button btnAtivos;
        private System.Windows.Forms.Button btnInativos;
        private System.Windows.Forms.Button btnCriptoativo;
        private System.Windows.Forms.Button btnProjecao;
        private System.Windows.Forms.Button btnAlarme;
        private Microsoft.Reporting.WinForms.ReportViewer reportCarteira;
        private blockchainDataSet1 blockchainDataSet1;
        private System.Windows.Forms.BindingSource carteiraclienteBindingSource;
        private blockchainDataSet1TableAdapters.Carteira_clienteTableAdapter carteira_clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteativosBindingSource;
        private blockchainDataSet1TableAdapters.Cliente_ativosTableAdapter cliente_ativosTableAdapter;
        private System.Windows.Forms.BindingSource clienteinativosBindingSource;
        private blockchainDataSet1TableAdapters.Cliente_inativosTableAdapter cliente_inativosTableAdapter;
        private System.Windows.Forms.BindingSource criptoativoBindingSource;
        private blockchainDataSet1TableAdapters.criptoativoTableAdapter criptoativoTableAdapter;
        private System.Windows.Forms.BindingSource projecaoFuturaBindingSource;
        private blockchainDataSet1TableAdapters.Projecao_FuturaTableAdapter projecao_FuturaTableAdapter;
        private System.Windows.Forms.BindingSource Projecao_FuturaBindingSource;
        private System.Windows.Forms.BindingSource Cliente_inativosBindingSource;
        private System.Windows.Forms.BindingSource Cliente_ativosBindingSource;
        private System.Windows.Forms.BindingSource clienteativosBindingSource1;
        private System.Windows.Forms.BindingSource clienteativosBindingSource2;
        private System.Windows.Forms.BindingSource clienteativosBindingSource3;
        private System.Windows.Forms.BindingSource Carteira_clienteBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportAtivos;
        private Microsoft.Reporting.WinForms.ReportViewer reportInativos;
        private Microsoft.Reporting.WinForms.ReportViewer reportCriptoativo;
        private Microsoft.Reporting.WinForms.ReportViewer reportProjecao;
    }
}