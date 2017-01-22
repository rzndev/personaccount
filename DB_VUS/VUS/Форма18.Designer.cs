namespace VUS
{
    partial class Форма18
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tableОтчет18BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_VUSDataSet = new VUS.DB_VUSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableОтчет18TableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableОтчет18TableAdapter();
            this.tableОтчет181BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableОтчет18_1TableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableОтчет18_1TableAdapter();
            this.tableОтчет182BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableОтчет18_2TableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableОтчет18_2TableAdapter();
            this.tableОтчет183BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableОтчет18_3TableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableОтчет18_3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableОтчет18BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableОтчет181BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableОтчет182BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableОтчет183BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableОтчет18BindingSource
            // 
            this.tableОтчет18BindingSource.DataMember = "TableОтчет18";
            this.tableОтчет18BindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // dB_VUSDataSet
            // 
            this.dB_VUSDataSet.DataSetName = "DB_VUSDataSet";
            this.dB_VUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet18";
            reportDataSource1.Value = this.tableОтчет18BindingSource;
            reportDataSource2.Name = "DataSet18_1";
            reportDataSource2.Value = this.tableОтчет181BindingSource;
            reportDataSource3.Name = "DataSet8_2";
            reportDataSource3.Value = this.tableОтчет182BindingSource;
            reportDataSource4.Name = "DataSet18_3";
            reportDataSource4.Value = this.tableОтчет183BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VUS.ReportФорма18.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(680, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // tableОтчет18TableAdapter
            // 
            this.tableОтчет18TableAdapter.ClearBeforeFill = true;
            // 
            // tableОтчет181BindingSource
            // 
            this.tableОтчет181BindingSource.DataMember = "TableОтчет18_1";
            this.tableОтчет181BindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableОтчет18_1TableAdapter
            // 
            this.tableОтчет18_1TableAdapter.ClearBeforeFill = true;
            // 
            // tableОтчет182BindingSource
            // 
            this.tableОтчет182BindingSource.DataMember = "TableОтчет18_2";
            this.tableОтчет182BindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableОтчет18_2TableAdapter
            // 
            this.tableОтчет18_2TableAdapter.ClearBeforeFill = true;
            // 
            // tableОтчет183BindingSource
            // 
            this.tableОтчет183BindingSource.DataMember = "TableОтчет18_3";
            this.tableОтчет183BindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableОтчет18_3TableAdapter
            // 
            this.tableОтчет18_3TableAdapter.ClearBeforeFill = true;
            // 
            // Форма18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 412);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Форма18";
            this.Text = "Форма 18";
            this.Load += new System.EventHandler(this.Форма18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableОтчет18BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableОтчет181BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableОтчет182BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableОтчет183BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DB_VUSDataSet dB_VUSDataSet;
        private System.Windows.Forms.BindingSource tableОтчет18BindingSource;
        private DB_VUSDataSetTableAdapters.TableОтчет18TableAdapter tableОтчет18TableAdapter;
        private System.Windows.Forms.BindingSource tableОтчет181BindingSource;
        private DB_VUSDataSetTableAdapters.TableОтчет18_1TableAdapter tableОтчет18_1TableAdapter;
        private System.Windows.Forms.BindingSource tableОтчет182BindingSource;
        private DB_VUSDataSetTableAdapters.TableОтчет18_2TableAdapter tableОтчет18_2TableAdapter;
        private System.Windows.Forms.BindingSource tableОтчет183BindingSource;
        private DB_VUSDataSetTableAdapters.TableОтчет18_3TableAdapter tableОтчет18_3TableAdapter;
    }
}