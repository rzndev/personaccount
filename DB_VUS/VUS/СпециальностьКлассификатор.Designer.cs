namespace VUS
{
    partial class СпециальностьКлассификатор
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(СпециальностьКлассификатор));
            this.dB_VUSDataSet = new VUS.DB_VUSDataSet();
            this.tableКлассификаторСпециальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableКлассификаторСпециальностиTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableКлассификаторСпециальностиTableAdapter();
            this.tableAdapterManager = new VUS.DB_VUSDataSetTableAdapters.TableAdapterManager();
            this.tableКлассификаторСпециальностиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tableКлассификаторСпециальностиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableКлассификаторСпециальностиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторСпециальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторСпециальностиBindingNavigator)).BeginInit();
            this.tableКлассификаторСпециальностиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторСпециальностиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_VUSDataSet
            // 
            this.dB_VUSDataSet.DataSetName = "DB_VUSDataSet";
            this.dB_VUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableКлассификаторСпециальностиBindingSource
            // 
            this.tableКлассификаторСпециальностиBindingSource.DataMember = "TableКлассификаторСпециальности";
            this.tableКлассификаторСпециальностиBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableКлассификаторСпециальностиTableAdapter
            // 
            this.tableКлассификаторСпециальностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableВидВоенныйБилетTableAdapter = null;
            this.tableAdapterManager.TableВоенныеСборыTableAdapter = null;
            this.tableAdapterManager.TableВоенныйБилетTableAdapter = null;
            this.tableAdapterManager.TableВоинскоеЗваниеTableAdapter = null;
            this.tableAdapterManager.TableВУСTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторСпециальностиTableAdapter = this.tableКлассификаторСпециальностиTableAdapter;
            this.tableAdapterManager.TableПричиныНеПрохоженияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableСведенияОбОрганизацииTableAdapter = null;
            this.tableAdapterManager.TableСведенияОВоеннойПодготовкеTableAdapter = null;
            this.tableAdapterManager.TableСведенияОРодственникахTableAdapter = null;
            this.tableAdapterManager.TableСотрудникTableAdapter = null;
            this.tableAdapterManager.TableСпециальностьTableAdapter = null;
            this.tableAdapterManager.TableСтатусСотрудникаTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VUS.DB_VUSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableКлассификаторСпециальностиBindingNavigator
            // 
            this.tableКлассификаторСпециальностиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableКлассификаторСпециальностиBindingNavigator.BindingSource = this.tableКлассификаторСпециальностиBindingSource;
            this.tableКлассификаторСпециальностиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableКлассификаторСпециальностиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableКлассификаторСпециальностиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableКлассификаторСпециальностиBindingNavigatorSaveItem});
            this.tableКлассификаторСпециальностиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableКлассификаторСпециальностиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableКлассификаторСпециальностиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableКлассификаторСпециальностиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableКлассификаторСпециальностиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableКлассификаторСпециальностиBindingNavigator.Name = "tableКлассификаторСпециальностиBindingNavigator";
            this.tableКлассификаторСпециальностиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableКлассификаторСпециальностиBindingNavigator.Size = new System.Drawing.Size(571, 25);
            this.tableКлассификаторСпециальностиBindingNavigator.TabIndex = 0;
            this.tableКлассификаторСпециальностиBindingNavigator.Text = "bindingNavigator1";
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
            // tableКлассификаторСпециальностиBindingNavigatorSaveItem
            // 
            this.tableКлассификаторСпециальностиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableКлассификаторСпециальностиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableКлассификаторСпециальностиBindingNavigatorSaveItem.Image")));
            this.tableКлассификаторСпециальностиBindingNavigatorSaveItem.Name = "tableКлассификаторСпециальностиBindingNavigatorSaveItem";
            this.tableКлассификаторСпециальностиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tableКлассификаторСпециальностиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tableКлассификаторСпециальностиBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableКлассификаторСпециальностиBindingNavigatorSaveItem_Click);
            // 
            // tableКлассификаторСпециальностиDataGridView
            // 
            this.tableКлассификаторСпециальностиDataGridView.AutoGenerateColumns = false;
            this.tableКлассификаторСпециальностиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableКлассификаторСпециальностиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tableКлассификаторСпециальностиDataGridView.DataSource = this.tableКлассификаторСпециальностиBindingSource;
            this.tableКлассификаторСпециальностиDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableКлассификаторСпециальностиDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tableКлассификаторСпециальностиDataGridView.Name = "tableКлассификаторСпециальностиDataGridView";
            this.tableКлассификаторСпециальностиDataGridView.Size = new System.Drawing.Size(571, 417);
            this.tableКлассификаторСпециальностиDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // Специальность
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 442);
            this.Controls.Add(this.tableКлассификаторСпециальностиDataGridView);
            this.Controls.Add(this.tableКлассификаторСпециальностиBindingNavigator);
            this.Name = "Специальность";
            this.Text = "Класс специальности";
            this.Load += new System.EventHandler(this.Специальность_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторСпециальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторСпециальностиBindingNavigator)).EndInit();
            this.tableКлассификаторСпециальностиBindingNavigator.ResumeLayout(false);
            this.tableКлассификаторСпециальностиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableКлассификаторСпециальностиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_VUSDataSet dB_VUSDataSet;
        private System.Windows.Forms.BindingSource tableКлассификаторСпециальностиBindingSource;
        private DB_VUSDataSetTableAdapters.TableКлассификаторСпециальностиTableAdapter tableКлассификаторСпециальностиTableAdapter;
        private DB_VUSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableКлассификаторСпециальностиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableКлассификаторСпециальностиBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tableКлассификаторСпециальностиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}