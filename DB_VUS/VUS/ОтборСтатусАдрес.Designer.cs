﻿namespace VUS
{
    partial class ОтборСтатусАдрес
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтборСтатусАдрес));
            this.dB_VUSDataSet = new VUS.DB_VUSDataSet();
            this.dataFiltrStatusAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataFiltrStatusAddressTableAdapter = new VUS.DB_VUSDataSetTableAdapters.DataFiltrStatusAddressTableAdapter();
            this.tableAdapterManager = new VUS.DB_VUSDataSetTableAdapters.TableAdapterManager();
            this.dataFiltrStatusAddressBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataFiltrStatusAddressBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.adresToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.adresToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataFiltrStatusAddressDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableСтатусСотрудникаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableСтатусСотрудникаTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableСтатусСотрудникаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiltrStatusAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiltrStatusAddressBindingNavigator)).BeginInit();
            this.dataFiltrStatusAddressBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiltrStatusAddressDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСтатусСотрудникаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_VUSDataSet
            // 
            this.dB_VUSDataSet.DataSetName = "DB_VUSDataSet";
            this.dB_VUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataFiltrStatusAddressBindingSource
            // 
            this.dataFiltrStatusAddressBindingSource.DataMember = "DataFiltrStatusAddress";
            this.dataFiltrStatusAddressBindingSource.DataSource = this.dB_VUSDataSet;
            // 
            // dataFiltrStatusAddressTableAdapter
            // 
            this.dataFiltrStatusAddressTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TableСведенияОбОрганизацииTableAdapter = null;
            this.tableAdapterManager.TableСведенияОВоеннойПодготовкеTableAdapter = null;
            this.tableAdapterManager.TableСведенияОРодственникахTableAdapter = null;
            this.tableAdapterManager.TableСоставПрофильTableAdapter = null;
            this.tableAdapterManager.TableСотрудникTableAdapter = null;
            this.tableAdapterManager.TableСпециальностьTableAdapter = null;
            this.tableAdapterManager.TableСтатусСотрудникаTableAdapter = this.tableСтатусСотрудникаTableAdapter;
            this.tableAdapterManager.UpdateOrder = VUS.DB_VUSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataFiltrStatusAddressBindingNavigator
            // 
            this.dataFiltrStatusAddressBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataFiltrStatusAddressBindingNavigator.BindingSource = this.dataFiltrStatusAddressBindingSource;
            this.dataFiltrStatusAddressBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataFiltrStatusAddressBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataFiltrStatusAddressBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dataFiltrStatusAddressBindingNavigatorSaveItem});
            this.dataFiltrStatusAddressBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataFiltrStatusAddressBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataFiltrStatusAddressBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataFiltrStatusAddressBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataFiltrStatusAddressBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataFiltrStatusAddressBindingNavigator.Name = "dataFiltrStatusAddressBindingNavigator";
            this.dataFiltrStatusAddressBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataFiltrStatusAddressBindingNavigator.Size = new System.Drawing.Size(713, 25);
            this.dataFiltrStatusAddressBindingNavigator.TabIndex = 0;
            this.dataFiltrStatusAddressBindingNavigator.Text = "bindingNavigator1";
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
            // dataFiltrStatusAddressBindingNavigatorSaveItem
            // 
            this.dataFiltrStatusAddressBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataFiltrStatusAddressBindingNavigatorSaveItem.Enabled = false;
            this.dataFiltrStatusAddressBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataFiltrStatusAddressBindingNavigatorSaveItem.Image")));
            this.dataFiltrStatusAddressBindingNavigatorSaveItem.Name = "dataFiltrStatusAddressBindingNavigatorSaveItem";
            this.dataFiltrStatusAddressBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.dataFiltrStatusAddressBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adresToolStripLabel,
            this.adresToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(713, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // adresToolStripLabel
            // 
            this.adresToolStripLabel.Name = "adresToolStripLabel";
            this.adresToolStripLabel.Size = new System.Drawing.Size(38, 13);
            this.adresToolStripLabel.Text = "adres:";
            // 
            // adresToolStripTextBox
            // 
            this.adresToolStripTextBox.Name = "adresToolStripTextBox";
            this.adresToolStripTextBox.Size = new System.Drawing.Size(400, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.fillToolStripButton.Text = "Отобрать";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // dataFiltrStatusAddressDataGridView
            // 
            this.dataFiltrStatusAddressDataGridView.AutoGenerateColumns = false;
            this.dataFiltrStatusAddressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFiltrStatusAddressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataFiltrStatusAddressDataGridView.DataSource = this.dataFiltrStatusAddressBindingSource;
            this.dataFiltrStatusAddressDataGridView.Location = new System.Drawing.Point(0, 95);
            this.dataFiltrStatusAddressDataGridView.Name = "dataFiltrStatusAddressDataGridView";
            this.dataFiltrStatusAddressDataGridView.Size = new System.Drawing.Size(701, 300);
            this.dataFiltrStatusAddressDataGridView.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn6.Width = 5;
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
            this.dataGridViewTextBoxColumn9.DataPropertyName = "адрес жительства";
            this.dataGridViewTextBoxColumn9.HeaderText = "адрес жительства";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tableСтатусСотрудникаBindingSource;
            this.comboBox1.DisplayMember = "наименование";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "id";
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
            // ОтборСтатусАдрес
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 429);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataFiltrStatusAddressDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.dataFiltrStatusAddressBindingNavigator);
            this.Name = "ОтборСтатусАдрес";
            this.Text = "Отбор статус адрес";
            this.Load += new System.EventHandler(this.ОтборСтатусАдрес_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiltrStatusAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiltrStatusAddressBindingNavigator)).EndInit();
            this.dataFiltrStatusAddressBindingNavigator.ResumeLayout(false);
            this.dataFiltrStatusAddressBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiltrStatusAddressDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСтатусСотрудникаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_VUSDataSet dB_VUSDataSet;
        private System.Windows.Forms.BindingSource dataFiltrStatusAddressBindingSource;
        private DB_VUSDataSetTableAdapters.DataFiltrStatusAddressTableAdapter dataFiltrStatusAddressTableAdapter;
        private DB_VUSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataFiltrStatusAddressBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dataFiltrStatusAddressBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel adresToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox adresToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView dataFiltrStatusAddressDataGridView;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tableСтатусСотрудникаBindingSource;
    }
}