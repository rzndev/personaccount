namespace VUS
{
    partial class ОтборСтатусВУС
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтборСтатусВУС));
            this.dB_VUSDataSet = new VUS.DB_VUSDataSet();
            this.dataTableStatusVusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableStatusVusTableAdapter = new VUS.DB_VUSDataSetTableAdapters.DataTableStatusVusTableAdapter();
            this.tableAdapterManager = new VUS.DB_VUSDataSetTableAdapters.TableAdapterManager();
            this.dataTableStatusVusBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataTableStatusVusBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataTableStatusVusDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.tableСтатусСотрудникаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableСтатусСотрудникаTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableСтатусСотрудникаTableAdapter();
            this.comboBoxVUS = new System.Windows.Forms.ComboBox();
            this.tableВУСBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableВУСTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableВУСTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableStatusVusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableStatusVusBindingNavigator)).BeginInit();
            this.dataTableStatusVusBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableStatusVusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСтатусСотрудникаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableВУСBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_VUSDataSet
            // 
            this.dB_VUSDataSet.DataSetName = "DB_VUSDataSet";
            this.dB_VUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableStatusVusBindingSource
            // 
            this.dataTableStatusVusBindingSource.DataMember = "DataTableStatusVus";
            this.dataTableStatusVusBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // dataTableStatusVusTableAdapter
            // 
            this.dataTableStatusVusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableВидВоенныйБилетTableAdapter = null;
            this.tableAdapterManager.TableВоенныеСборыTableAdapter = null;
            this.tableAdapterManager.TableВоенныйБилетTableAdapter = null;
            this.tableAdapterManager.TableВоинскоеЗваниеTableAdapter = null;
            this.tableAdapterManager.TableВУСTableAdapter = this.tableВУСTableAdapter;
            this.tableAdapterManager.TableКатегорияГодностиКВСTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторВоинскихЗванийTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторСпециальностиTableAdapter = null;
            this.tableAdapterManager.TableПричиныНеПрохоженияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableСведенияОбОрганизацииTableAdapter = null;
            this.tableAdapterManager.TableСведенияОВоеннойПодготовкеTableAdapter = null;
            this.tableAdapterManager.TableСведенияОРодственникахTableAdapter = null;
            this.tableAdapterManager.TableСоставПрофильTableAdapter = null;
            this.tableAdapterManager.TableСотрудникTableAdapter = null;
            this.tableAdapterManager.TableСпециальностьTableAdapter = null;
            this.tableAdapterManager.TableСтатусСотрудникаTableAdapter = this.tableСтатусСотрудникаTableAdapter;
            this.tableAdapterManager.UpdateOrder = VUS.DB_VUSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTableStatusVusBindingNavigator
            // 
            this.dataTableStatusVusBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataTableStatusVusBindingNavigator.BindingSource = this.dataTableStatusVusBindingSource;
            this.dataTableStatusVusBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTableStatusVusBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataTableStatusVusBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dataTableStatusVusBindingNavigatorSaveItem});
            this.dataTableStatusVusBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTableStatusVusBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTableStatusVusBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTableStatusVusBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTableStatusVusBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTableStatusVusBindingNavigator.Name = "dataTableStatusVusBindingNavigator";
            this.dataTableStatusVusBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTableStatusVusBindingNavigator.Size = new System.Drawing.Size(657, 25);
            this.dataTableStatusVusBindingNavigator.TabIndex = 0;
            this.dataTableStatusVusBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // dataTableStatusVusBindingNavigatorSaveItem
            // 
            this.dataTableStatusVusBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataTableStatusVusBindingNavigatorSaveItem.Enabled = false;
            this.dataTableStatusVusBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataTableStatusVusBindingNavigatorSaveItem.Image")));
            this.dataTableStatusVusBindingNavigatorSaveItem.Name = "dataTableStatusVusBindingNavigatorSaveItem";
            this.dataTableStatusVusBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dataTableStatusVusBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(657, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.fillToolStripButton.Text = "Отобрать";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // dataTableStatusVusDataGridView
            // 
            this.dataTableStatusVusDataGridView.AutoGenerateColumns = false;
            this.dataTableStatusVusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableStatusVusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataTableStatusVusDataGridView.DataSource = this.dataTableStatusVusBindingSource;
            this.dataTableStatusVusDataGridView.Location = new System.Drawing.Point(0, 106);
            this.dataTableStatusVusDataGridView.Name = "dataTableStatusVusDataGridView";
            this.dataTableStatusVusDataGridView.Size = new System.Drawing.Size(636, 329);
            this.dataTableStatusVusDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "фамилия";
            this.dataGridViewTextBoxColumn1.HeaderText = "фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "отчество";
            this.dataGridViewTextBoxColumn3.HeaderText = "отчество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "датарождения";
            this.dataGridViewTextBoxColumn4.HeaderText = "датарождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "пол";
            this.dataGridViewTextBoxColumn5.HeaderText = "пол";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn6.HeaderText = "id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "наименование";
            this.dataGridViewTextBoxColumn7.HeaderText = "наименование";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "статус";
            this.dataGridViewTextBoxColumn8.HeaderText = "статус";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ВУС";
            this.dataGridViewTextBoxColumn9.HeaderText = "ВУС";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DataSource = this.tableСтатусСотрудникаBindingSource;
            this.comboBoxStatus.DisplayMember = "наименование";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(0, 54);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(224, 21);
            this.comboBoxStatus.TabIndex = 3;
            this.comboBoxStatus.ValueMember = "id";
            // 
            // tableСтатусСотрудникаBindingSource
            // 
            this.tableСтатусСотрудникаBindingSource.DataMember = "TableСтатусСотрудника";
            this.tableСтатусСотрудникаBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // tableСтатусСотрудникаTableAdapter
            // 
            this.tableСтатусСотрудникаTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxVUS
            // 
            this.comboBoxVUS.DataSource = this.tableВУСBindingSource;
            this.comboBoxVUS.DisplayMember = "наименование";
            this.comboBoxVUS.FormattingEnabled = true;
            this.comboBoxVUS.Location = new System.Drawing.Point(261, 53);
            this.comboBoxVUS.Name = "comboBoxVUS";
            this.comboBoxVUS.Size = new System.Drawing.Size(384, 21);
            this.comboBoxVUS.TabIndex = 4;
            this.comboBoxVUS.ValueMember = "id";
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
            // ОтборСтатусВУС
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 453);
            this.Controls.Add(this.comboBoxVUS);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dataTableStatusVusDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.dataTableStatusVusBindingNavigator);
            this.Name = "ОтборСтатусВУС";
            this.Text = "Отбор по статусу и ВУС";
            this.Load += new System.EventHandler(this.ОтборСтатусВУС_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableStatusVusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableStatusVusBindingNavigator)).EndInit();
            this.dataTableStatusVusBindingNavigator.ResumeLayout(false);
            this.dataTableStatusVusBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableStatusVusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСтатусСотрудникаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableВУСBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_VUSDataSet dB_VUSDataSet;
        private System.Windows.Forms.BindingSource dataTableStatusVusBindingSource;
        private DB_VUSDataSetTableAdapters.DataTableStatusVusTableAdapter dataTableStatusVusTableAdapter;
        private DB_VUSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTableStatusVusBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dataTableStatusVusBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView dataTableStatusVusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DB_VUSDataSetTableAdapters.TableСтатусСотрудникаTableAdapter tableСтатусСотрудникаTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.BindingSource tableСтатусСотрудникаBindingSource;
        private DB_VUSDataSetTableAdapters.TableВУСTableAdapter tableВУСTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxVUS;
        private System.Windows.Forms.BindingSource tableВУСBindingSource;
    }
}