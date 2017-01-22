namespace VUS
{
    partial class ВУС
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ВУС));
            this.dB_VUSDataSet = new VUS.DB_VUSDataSet();
            this.tableВУСBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableВУСTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableВУСTableAdapter();
            this.tableAdapterManager = new VUS.DB_VUSDataSetTableAdapters.TableAdapterManager();
            this.tableВУСBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tableВУСBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableВУСDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableВУСBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableВУСBindingNavigator)).BeginInit();
            this.tableВУСBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableВУСDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_VUSDataSet
            // 
            this.dB_VUSDataSet.DataSetName = "DB_VUSDataSet";
            this.dB_VUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableВУСBindingSource
            // 
            this.tableВУСBindingSource.DataMember = "TableВУС";
            this.tableВУСBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableВУСTableAdapter
            // 
            this.tableВУСTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableВидВоенныйБилетTableAdapter = null;
            this.tableAdapterManager.TableВоенныеСборыTableAdapter = null;
            this.tableAdapterManager.TableВоенныйБилетTableAdapter = null;
            this.tableAdapterManager.TableВоинскоеЗваниеTableAdapter = null;
            this.tableAdapterManager.TableВУСTableAdapter = this.tableВУСTableAdapter;
            this.tableAdapterManager.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторСпециальностиTableAdapter = null;
            this.tableAdapterManager.TableПричиныНеПрохоженияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableСведенияОбОрганизацииTableAdapter = null;
            this.tableAdapterManager.TableСведенияОВоеннойПодготовкеTableAdapter = null;
            this.tableAdapterManager.TableСведенияОРодственникахTableAdapter = null;
            this.tableAdapterManager.TableСотрудникTableAdapter = null;
            this.tableAdapterManager.TableСпециальностьTableAdapter = null;
            this.tableAdapterManager.TableСтатусСотрудникаTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VUS.DB_VUSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableВУСBindingNavigator
            // 
            this.tableВУСBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableВУСBindingNavigator.BindingSource = this.tableВУСBindingSource;
            this.tableВУСBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableВУСBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableВУСBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableВУСBindingNavigatorSaveItem});
            this.tableВУСBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableВУСBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableВУСBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableВУСBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableВУСBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableВУСBindingNavigator.Name = "tableВУСBindingNavigator";
            this.tableВУСBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableВУСBindingNavigator.Size = new System.Drawing.Size(649, 25);
            this.tableВУСBindingNavigator.TabIndex = 0;
            this.tableВУСBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 13);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // tableВУСBindingNavigatorSaveItem
            // 
            this.tableВУСBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableВУСBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableВУСBindingNavigatorSaveItem.Image")));
            this.tableВУСBindingNavigatorSaveItem.Name = "tableВУСBindingNavigatorSaveItem";
            this.tableВУСBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tableВУСBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tableВУСBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableВУСBindingNavigatorSaveItem_Click_1);
            // 
            // tableВУСDataGridView
            // 
            this.tableВУСDataGridView.AutoGenerateColumns = false;
            this.tableВУСDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableВУСDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableВУСDataGridView.DataSource = this.tableВУСBindingSource;
            this.tableВУСDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableВУСDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tableВУСDataGridView.Name = "tableВУСDataGridView";
            this.tableВУСDataGridView.Size = new System.Drawing.Size(649, 334);
            this.tableВУСDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "код спечиальности";
            this.dataGridViewTextBoxColumn2.HeaderText = "код специальности";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "наименование";
            this.dataGridViewTextBoxColumn3.HeaderText = "наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // ВУС
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 359);
            this.Controls.Add(this.tableВУСDataGridView);
            this.Controls.Add(this.tableВУСBindingNavigator);
            this.Name = "ВУС";
            this.Text = "Военно-учетная специальность";
            this.Load += new System.EventHandler(this.ВУС_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableВУСBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableВУСBindingNavigator)).EndInit();
            this.tableВУСBindingNavigator.ResumeLayout(false);
            this.tableВУСBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableВУСDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_VUSDataSet dB_VUSDataSet;
        private System.Windows.Forms.BindingSource tableВУСBindingSource;
        private DB_VUSDataSetTableAdapters.TableВУСTableAdapter tableВУСTableAdapter;
        private DB_VUSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableВУСBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableВУСBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tableВУСDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}