namespace VUS
{
    partial class КлассификаторВоинскихЗваний
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(КлассификаторВоинскихЗваний));
            this.dB_VUSDataSet = new VUS.DB_VUSDataSet();
            this.tableКлассификаторВоинскихЗванийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableКлассификаторВоинскихЗванийTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableКлассификаторВоинскихЗванийTableAdapter();
            this.tableAdapterManager = new VUS.DB_VUSDataSetTableAdapters.TableAdapterManager();
            this.tableКлассификаторВоинскихЗванийBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableКлассификаторВоинскихЗванийDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторВоинскихЗванийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторВоинскихЗванийBindingNavigator)).BeginInit();
            this.tableКлассификаторВоинскихЗванийBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторВоинскихЗванийDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_VUSDataSet
            // 
            this.dB_VUSDataSet.DataSetName = "DB_VUSDataSet";
            this.dB_VUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableКлассификаторВоинскихЗванийBindingSource
            // 
            this.tableКлассификаторВоинскихЗванийBindingSource.DataMember = "TableКлассификаторВоинскихЗваний";
            this.tableКлассификаторВоинскихЗванийBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableКлассификаторВоинскихЗванийTableAdapter
            // 
            this.tableКлассификаторВоинскихЗванийTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableВидВоенныйБилетTableAdapter = null;
            this.tableAdapterManager.TableВоенныеСборыTableAdapter = null;
            this.tableAdapterManager.TableВоенныйБилетTableAdapter = null;
            this.tableAdapterManager.TableВоинскоеЗваниеTableAdapter = null;
            this.tableAdapterManager.TableВУСTableAdapter = null;
            this.tableAdapterManager.TableКатегорияГодностиКВСTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторВоинскихЗванийTableAdapter = this.tableКлассификаторВоинскихЗванийTableAdapter;
            this.tableAdapterManager.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторСпециальностиTableAdapter = null;
            this.tableAdapterManager.TableПричиныНеПрохоженияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableСведенияОбОрганизацииTableAdapter = null;
            this.tableAdapterManager.TableСведенияОВоеннойПодготовкеTableAdapter = null;
            this.tableAdapterManager.TableСведенияОРодственникахTableAdapter = null;
            this.tableAdapterManager.TableСоставПрофильTableAdapter = null;
            this.tableAdapterManager.TableСотрудникTableAdapter = null;
            this.tableAdapterManager.TableСпециальностьTableAdapter = null;
            this.tableAdapterManager.TableСтатусСотрудникаTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VUS.DB_VUSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableКлассификаторВоинскихЗванийBindingNavigator
            // 
            this.tableКлассификаторВоинскихЗванийBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableКлассификаторВоинскихЗванийBindingNavigator.BindingSource = this.tableКлассификаторВоинскихЗванийBindingSource;
            this.tableКлассификаторВоинскихЗванийBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableКлассификаторВоинскихЗванийBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableКлассификаторВоинскихЗванийBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem});
            this.tableКлассификаторВоинскихЗванийBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableКлассификаторВоинскихЗванийBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableКлассификаторВоинскихЗванийBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableКлассификаторВоинскихЗванийBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableКлассификаторВоинскихЗванийBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableКлассификаторВоинскихЗванийBindingNavigator.Name = "tableКлассификаторВоинскихЗванийBindingNavigator";
            this.tableКлассификаторВоинскихЗванийBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableКлассификаторВоинскихЗванийBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.tableКлассификаторВоинскихЗванийBindingNavigator.TabIndex = 0;
            this.tableКлассификаторВоинскихЗванийBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem
            // 
            this.tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem.Image")));
            this.tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem.Name = "tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem";
            this.tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem.Text = "Save Data";
            this.tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem_Click);
            // 
            // tableКлассификаторВоинскихЗванийDataGridView
            // 
            this.tableКлассификаторВоинскихЗванийDataGridView.AutoGenerateColumns = false;
            this.tableКлассификаторВоинскихЗванийDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableКлассификаторВоинскихЗванийDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tableКлассификаторВоинскихЗванийDataGridView.DataSource = this.tableКлассификаторВоинскихЗванийBindingSource;
            this.tableКлассификаторВоинскихЗванийDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableКлассификаторВоинскихЗванийDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tableКлассификаторВоинскихЗванийDataGridView.Name = "tableКлассификаторВоинскихЗванийDataGridView";
            this.tableКлассификаторВоинскихЗванийDataGridView.Size = new System.Drawing.Size(834, 428);
            this.tableКлассификаторВоинскихЗванийDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // КлассификаторВоинскихЗваний
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 453);
            this.Controls.Add(this.tableКлассификаторВоинскихЗванийDataGridView);
            this.Controls.Add(this.tableКлассификаторВоинскихЗванийBindingNavigator);
            this.Name = "КлассификаторВоинскихЗваний";
            this.Text = "Классификатор воинских званий";
            this.Load += new System.EventHandler(this.КлассификаторВоинскихЗваний_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторВоинскихЗванийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторВоинскихЗванийBindingNavigator)).EndInit();
            this.tableКлассификаторВоинскихЗванийBindingNavigator.ResumeLayout(false);
            this.tableКлассификаторВоинскихЗванийBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторВоинскихЗванийDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_VUSDataSet dB_VUSDataSet;
        private System.Windows.Forms.BindingSource tableКлассификаторВоинскихЗванийBindingSource;
        private DB_VUSDataSetTableAdapters.TableКлассификаторВоинскихЗванийTableAdapter tableКлассификаторВоинскихЗванийTableAdapter;
        private DB_VUSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableКлассификаторВоинскихЗванийBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tableКлассификаторВоинскихЗванийDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}