namespace VUS
{
    partial class ФормаT2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableСотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_VUSDataSet = new VUS.DB_VUSDataSet();
            this.buttonExec = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableСотрудникTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableСотрудникTableAdapter();
            this.dataTableОтчетТ2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableОтчетТ2TableAdapter = new VUS.DB_VUSDataSetTableAdapters.DataTableОтчетТ2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableОтчетТ2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetT2";
            reportDataSource3.Value = this.dataTableОтчетТ2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VUS.ReportT2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(517, 330);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tableСотрудникBindingSource;
            this.comboBox1.DisplayMember = "фамилия";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "id";
            // 
            // tableСотрудникBindingSource
            // 
            this.tableСотрудникBindingSource.DataMember = "TableСотрудник";
            this.tableСотрудникBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // dB_VUSDataSet
            // 
            this.dB_VUSDataSet.DataSetName = "DB_VUSDataSet";
            this.dB_VUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(349, 3);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 3;
            this.buttonExec.Text = "Сформировать";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExec);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 34);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 330);
            this.panel2.TabIndex = 5;
            // 
            // tableСотрудникTableAdapter
            // 
            this.tableСотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableОтчетТ2BindingSource
            // 
            this.dataTableОтчетТ2BindingSource.DataMember = "DataTableОтчетТ2";
            this.dataTableОтчетТ2BindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // dataTableОтчетТ2TableAdapter
            // 
            this.dataTableОтчетТ2TableAdapter.ClearBeforeFill = true;
            // 
            // ФормаT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ФормаT2";
            this.Text = "ФормаT2";
            this.Load += new System.EventHandler(this.ФормаT2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableОтчетТ2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DB_VUSDataSet dB_VUSDataSet;
        private System.Windows.Forms.BindingSource tableСотрудникBindingSource;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DB_VUSDataSetTableAdapters.TableСотрудникTableAdapter tableСотрудникTableAdapter;
        private System.Windows.Forms.BindingSource dataTableОтчетТ2BindingSource;
        private DB_VUSDataSetTableAdapters.DataTableОтчетТ2TableAdapter dataTableОтчетТ2TableAdapter;
    }
}