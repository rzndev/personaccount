namespace VUS
{
    partial class Форма6
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DB_VUSDataSet = new VUS.DB_VUSDataSet();
            this.TableКлассификаторПричиныНеПрохожденияСлужбыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DB_VUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableКлассификаторПричиныНеПрохожденияСлужбыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TableКлассификаторПричиныНеПрохожденияСлужбыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VUS.ReportForm6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(545, 359);
            this.reportViewer1.TabIndex = 0;
            // 
            // DB_VUSDataSet
            // 
            this.DB_VUSDataSet.DataSetName = "DB_VUSDataSet";
            this.DB_VUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TableКлассификаторПричиныНеПрохожденияСлужбыBindingSource
            // 
            this.TableКлассификаторПричиныНеПрохожденияСлужбыBindingSource.DataMember = "TableКлассификаторПричиныНеПрохожденияСлужбы";
            this.TableКлассификаторПричиныНеПрохожденияСлужбыBindingSource.DataSource = this.DB_VUSDataSet;
            // 
            // TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter
            // 
            this.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter.ClearBeforeFill = true;
            // 
            // Форма6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 359);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Форма6";
            this.Text = "Форма6";
            this.Load += new System.EventHandler(this.Форма6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DB_VUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableКлассификаторПричиныНеПрохожденияСлужбыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TableКлассификаторПричиныНеПрохожденияСлужбыBindingSource;
        private DB_VUSDataSet DB_VUSDataSet;
        private DB_VUSDataSetTableAdapters.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter;
    }
}