namespace VUS
{
    partial class Сотрудник
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Сотрудник));
            this.dB_VUSDataSet = new VUS.DB_VUSDataSet();
            this.tableСотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableСотрудникTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableСотрудникTableAdapter();
            this.tableAdapterManager = new VUS.DB_VUSDataSetTableAdapters.TableAdapterManager();
            this.tableСведенияОбОрганизацииTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableСведенияОбОрганизацииTableAdapter();
            this.tableСтатусСотрудникаTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableСтатусСотрудникаTableAdapter();
            this.tableСотрудникBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableСотрудникBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableСотрудникDataGridView = new System.Windows.Forms.DataGridView();
            this.tableСведенияОбОрганизацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableСтатусСотрудникаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableКатегорияГодностиКВСBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableКатегорияГодностиКВСTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableКатегорияГодностиКВСTableAdapter();
            this.tableСпециальностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableСпециальностьTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableСпециальностьTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.специальность = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникBindingNavigator)).BeginInit();
            this.tableСотрудникBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСведенияОбОрганизацииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСтатусСотрудникаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableКатегорияГодностиКВСBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСпециальностьBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_VUSDataSet
            // 
            this.dB_VUSDataSet.DataSetName = "DB_VUSDataSet";
            this.dB_VUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableСотрудникBindingSource
            // 
            this.tableСотрудникBindingSource.DataMember = "TableСотрудник";
            this.tableСотрудникBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableСотрудникTableAdapter
            // 
            this.tableСотрудникTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TableКлассификаторВоинскихЗванийTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторСпециальностиTableAdapter = null;
            this.tableAdapterManager.TableПричиныНеПрохоженияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableСведенияОбОрганизацииTableAdapter = this.tableСведенияОбОрганизацииTableAdapter;
            this.tableAdapterManager.TableСведенияОВоеннойПодготовкеTableAdapter = null;
            this.tableAdapterManager.TableСведенияОРодственникахTableAdapter = null;
            this.tableAdapterManager.TableСоставПрофильTableAdapter = null;
            this.tableAdapterManager.TableСотрудникTableAdapter = this.tableСотрудникTableAdapter;
            this.tableAdapterManager.TableСпециальностьTableAdapter = null;
            this.tableAdapterManager.TableСтатусСотрудникаTableAdapter = this.tableСтатусСотрудникаTableAdapter;
            this.tableAdapterManager.UpdateOrder = VUS.DB_VUSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableСведенияОбОрганизацииTableAdapter
            // 
            this.tableСведенияОбОрганизацииTableAdapter.ClearBeforeFill = true;
            // 
            // tableСтатусСотрудникаTableAdapter
            // 
            this.tableСтатусСотрудникаTableAdapter.ClearBeforeFill = true;
            // 
            // tableСотрудникBindingNavigator
            // 
            this.tableСотрудникBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableСотрудникBindingNavigator.BindingSource = this.tableСотрудникBindingSource;
            this.tableСотрудникBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableСотрудникBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableСотрудникBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableСотрудникBindingNavigatorSaveItem});
            this.tableСотрудникBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableСотрудникBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableСотрудникBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableСотрудникBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableСотрудникBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableСотрудникBindingNavigator.Name = "tableСотрудникBindingNavigator";
            this.tableСотрудникBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableСотрудникBindingNavigator.Size = new System.Drawing.Size(1321, 25);
            this.tableСотрудникBindingNavigator.TabIndex = 0;
            this.tableСотрудникBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableСотрудникBindingNavigatorSaveItem
            // 
            this.tableСотрудникBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableСотрудникBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableСотрудникBindingNavigatorSaveItem.Image")));
            this.tableСотрудникBindingNavigatorSaveItem.Name = "tableСотрудникBindingNavigatorSaveItem";
            this.tableСотрудникBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableСотрудникBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tableСотрудникBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableСотрудникBindingNavigatorSaveItem_Click);
            // 
            // tableСотрудникDataGridView
            // 
            this.tableСотрудникDataGridView.AutoGenerateColumns = false;
            this.tableСотрудникDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableСотрудникDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewComboBoxColumn1,
            this.специальность});
            this.tableСотрудникDataGridView.DataSource = this.tableСотрудникBindingSource;
            this.tableСотрудникDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableСотрудникDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tableСотрудникDataGridView.Name = "tableСотрудникDataGridView";
            this.tableСотрудникDataGridView.Size = new System.Drawing.Size(1321, 372);
            this.tableСотрудникDataGridView.TabIndex = 1;
            // 
            // tableСведенияОбОрганизацииBindingSource
            // 
            this.tableСведенияОбОрганизацииBindingSource.DataMember = "TableСведенияОбОрганизации";
            this.tableСведенияОбОрганизацииBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableСтатусСотрудникаBindingSource
            // 
            this.tableСтатусСотрудникаBindingSource.DataMember = "TableСтатусСотрудника";
            this.tableСтатусСотрудникаBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableКатегорияГодностиКВСBindingSource
            // 
            this.tableКатегорияГодностиКВСBindingSource.DataMember = "TableКатегорияГодностиКВС";
            this.tableКатегорияГодностиКВСBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableКатегорияГодностиКВСTableAdapter
            // 
            this.tableКатегорияГодностиКВСTableAdapter.ClearBeforeFill = true;
            // 
            // tableСпециальностьBindingSource
            // 
            this.tableСпециальностьBindingSource.DataMember = "TableСпециальность";
            this.tableСпециальностьBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableСпециальностьTableAdapter
            // 
            this.tableСпециальностьTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "организация";
            this.dataGridViewTextBoxColumn2.DataSource = this.tableСведенияОбОрганизацииBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "организация";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "фамилия";
            this.dataGridViewTextBoxColumn3.HeaderText = "фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "имя";
            this.dataGridViewTextBoxColumn4.HeaderText = "имя";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "отчество";
            this.dataGridViewTextBoxColumn5.HeaderText = "отчество";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "датарождения";
            this.dataGridViewTextBoxColumn6.HeaderText = "датарождения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "пол";
            this.dataGridViewTextBoxColumn7.HeaderText = "пол";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 20;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "паспортные данные";
            this.dataGridViewTextBoxColumn8.HeaderText = "паспортные данные";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "адрес жительства";
            this.dataGridViewTextBoxColumn9.HeaderText = "адрес жительства";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "адрес пребывания";
            this.dataGridViewTextBoxColumn10.HeaderText = "адрес пребывания";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "статус";
            this.dataGridViewTextBoxColumn11.DataSource = this.tableСтатусСотрудникаBindingSource;
            this.dataGridViewTextBoxColumn11.DisplayMember = "наименование";
            this.dataGridViewTextBoxColumn11.HeaderText = "статус";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn11.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "дата приема";
            this.dataGridViewTextBoxColumn12.HeaderText = "дата приема";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "дата увольнения";
            this.dataGridViewTextBoxColumn13.HeaderText = "дата увольнения";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "категория годности";
            this.dataGridViewComboBoxColumn1.DataSource = this.tableКатегорияГодностиКВСBindingSource;
            this.dataGridViewComboBoxColumn1.DisplayMember = "наименование";
            this.dataGridViewComboBoxColumn1.HeaderText = "категория годности";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ValueMember = "id";
            // 
            // специальность
            // 
            this.специальность.DataPropertyName = "специальность";
            this.специальность.DataSource = this.tableСпециальностьBindingSource;
            this.специальность.DisplayMember = "наименование";
            this.специальность.HeaderText = "специальность";
            this.специальность.Name = "специальность";
            this.специальность.ValueMember = "id";
            this.специальность.Width = 200;
            // 
            // Сотрудник
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 397);
            this.Controls.Add(this.tableСотрудникDataGridView);
            this.Controls.Add(this.tableСотрудникBindingNavigator);
            this.Name = "Сотрудник";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.Сотрудник_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникBindingNavigator)).EndInit();
            this.tableСотрудникBindingNavigator.ResumeLayout(false);
            this.tableСотрудникBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСведенияОбОрганизацииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСтатусСотрудникаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableКатегорияГодностиКВСBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСпециальностьBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_VUSDataSet dB_VUSDataSet;
        private System.Windows.Forms.BindingSource tableСотрудникBindingSource;
        private DB_VUSDataSetTableAdapters.TableСотрудникTableAdapter tableСотрудникTableAdapter;
        private DB_VUSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableСотрудникBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableСотрудникBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tableСотрудникDataGridView;
        private DB_VUSDataSetTableAdapters.TableСведенияОбОрганизацииTableAdapter tableСведенияОбОрганизацииTableAdapter;
        private System.Windows.Forms.BindingSource tableСведенияОбОрганизацииBindingSource;
        private DB_VUSDataSetTableAdapters.TableСтатусСотрудникаTableAdapter tableСтатусСотрудникаTableAdapter;
        private System.Windows.Forms.BindingSource tableСтатусСотрудникаBindingSource;
        private System.Windows.Forms.BindingSource tableКатегорияГодностиКВСBindingSource;
        private DB_VUSDataSetTableAdapters.TableКатегорияГодностиКВСTableAdapter tableКатегорияГодностиКВСTableAdapter;
        private System.Windows.Forms.BindingSource tableСпециальностьBindingSource;
        private DB_VUSDataSetTableAdapters.TableСпециальностьTableAdapter tableСпециальностьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn специальность;
    }
}