﻿namespace VUS
{
    partial class ВоеннаяПодготовка
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ВоеннаяПодготовка));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label организацияLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label датарожденияLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label дата_приемаLabel;
            System.Windows.Forms.Label дата_увольненияLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dB_VUSDataSet = new VUS.DB_VUSDataSet();
            this.tableСотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableСотрудникTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableСотрудникTableAdapter();
            this.tableAdapterManager = new VUS.DB_VUSDataSetTableAdapters.TableAdapterManager();
            this.tableСотрудникBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tableСотрудникBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.организацияComboBox = new System.Windows.Forms.ComboBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.датарожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.дата_приемаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_увольненияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableСведенияОВоеннойПодготовкеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableСведенияОВоеннойПодготовкеTableAdapter = new VUS.DB_VUSDataSetTableAdapters.TableСведенияОВоеннойПодготовкеTableAdapter();
            this.tableСведенияОВоеннойПодготовкеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            организацияLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            датарожденияLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            дата_приемаLabel = new System.Windows.Forms.Label();
            дата_увольненияLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникBindingNavigator)).BeginInit();
            this.tableСотрудникBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableСведенияОВоеннойПодготовкеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСведенияОВоеннойПодготовкеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(организацияLabel);
            this.panel1.Controls.Add(this.организацияComboBox);
            this.panel1.Controls.Add(фамилияLabel);
            this.panel1.Controls.Add(this.фамилияTextBox);
            this.panel1.Controls.Add(имяLabel);
            this.panel1.Controls.Add(this.имяTextBox);
            this.panel1.Controls.Add(отчествоLabel);
            this.panel1.Controls.Add(this.отчествоTextBox);
            this.panel1.Controls.Add(датарожденияLabel);
            this.panel1.Controls.Add(this.датарожденияDateTimePicker);
            this.panel1.Controls.Add(полLabel);
            this.panel1.Controls.Add(this.полTextBox);
            this.panel1.Controls.Add(дата_приемаLabel);
            this.panel1.Controls.Add(this.дата_приемаDateTimePicker);
            this.panel1.Controls.Add(дата_увольненияLabel);
            this.panel1.Controls.Add(this.дата_увольненияDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 237);
            this.panel1.TabIndex = 0;
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
            this.tableAdapterManager.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableКлассификаторСпециальностиTableAdapter = null;
            this.tableAdapterManager.TableПричиныНеПрохоженияСлужбыTableAdapter = null;
            this.tableAdapterManager.TableСведенияОбОрганизацииTableAdapter = null;
            this.tableAdapterManager.TableСведенияОВоеннойПодготовкеTableAdapter = this.tableСведенияОВоеннойПодготовкеTableAdapter;
            this.tableAdapterManager.TableСведенияОРодственникахTableAdapter = null;
            this.tableAdapterManager.TableСотрудникTableAdapter = this.tableСотрудникTableAdapter;
            this.tableAdapterManager.TableСпециальностьTableAdapter = null;
            this.tableAdapterManager.TableСтатусСотрудникаTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VUS.DB_VUSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.tableСотрудникBindingNavigator.Size = new System.Drawing.Size(660, 25);
            this.tableСотрудникBindingNavigator.TabIndex = 1;
            this.tableСотрудникBindingNavigator.Text = "bindingNavigator1";
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
            // tableСотрудникBindingNavigatorSaveItem
            // 
            this.tableСотрудникBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableСотрудникBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableСотрудникBindingNavigatorSaveItem.Image")));
            this.tableСотрудникBindingNavigatorSaveItem.Name = "tableСотрудникBindingNavigatorSaveItem";
            this.tableСотрудникBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tableСотрудникBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tableСотрудникBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableСотрудникBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(3, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableСотрудникBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(104, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // организацияLabel
            // 
            организацияLabel.AutoSize = true;
            организацияLabel.Location = new System.Drawing.Point(3, 35);
            организацияLabel.Name = "организацияLabel";
            организацияLabel.Size = new System.Drawing.Size(75, 13);
            организацияLabel.TabIndex = 2;
            организацияLabel.Text = "организация:";
            // 
            // организацияComboBox
            // 
            this.организацияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableСотрудникBindingSource, "организация", true));
            this.организацияComboBox.FormattingEnabled = true;
            this.организацияComboBox.Location = new System.Drawing.Point(104, 32);
            this.организацияComboBox.Name = "организацияComboBox";
            this.организацияComboBox.Size = new System.Drawing.Size(200, 21);
            this.организацияComboBox.TabIndex = 3;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(3, 62);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(56, 13);
            фамилияLabel.TabIndex = 4;
            фамилияLabel.Text = "фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableСотрудникBindingSource, "фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(104, 59);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 20);
            this.фамилияTextBox.TabIndex = 5;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(3, 88);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(30, 13);
            имяLabel.TabIndex = 6;
            имяLabel.Text = "имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableСотрудникBindingSource, "имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(104, 85);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 20);
            this.имяTextBox.TabIndex = 7;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(3, 114);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(55, 13);
            отчествоLabel.TabIndex = 8;
            отчествоLabel.Text = "отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableСотрудникBindingSource, "отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(104, 111);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 20);
            this.отчествоTextBox.TabIndex = 9;
            // 
            // датарожденияLabel
            // 
            датарожденияLabel.AutoSize = true;
            датарожденияLabel.Location = new System.Drawing.Point(3, 141);
            датарожденияLabel.Name = "датарожденияLabel";
            датарожденияLabel.Size = new System.Drawing.Size(83, 13);
            датарожденияLabel.TabIndex = 10;
            датарожденияLabel.Text = "датарождения:";
            // 
            // датарожденияDateTimePicker
            // 
            this.датарожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableСотрудникBindingSource, "датарождения", true));
            this.датарожденияDateTimePicker.Location = new System.Drawing.Point(104, 137);
            this.датарожденияDateTimePicker.Name = "датарожденияDateTimePicker";
            this.датарожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датарожденияDateTimePicker.TabIndex = 11;
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(3, 166);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(28, 13);
            полLabel.TabIndex = 12;
            полLabel.Text = "пол:";
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableСотрудникBindingSource, "пол", true));
            this.полTextBox.Location = new System.Drawing.Point(104, 163);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(200, 20);
            this.полTextBox.TabIndex = 13;
            // 
            // дата_приемаLabel
            // 
            дата_приемаLabel.AutoSize = true;
            дата_приемаLabel.Location = new System.Drawing.Point(3, 193);
            дата_приемаLabel.Name = "дата_приемаLabel";
            дата_приемаLabel.Size = new System.Drawing.Size(74, 13);
            дата_приемаLabel.TabIndex = 14;
            дата_приемаLabel.Text = "дата приема:";
            // 
            // дата_приемаDateTimePicker
            // 
            this.дата_приемаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableСотрудникBindingSource, "дата приема", true));
            this.дата_приемаDateTimePicker.Location = new System.Drawing.Point(104, 189);
            this.дата_приемаDateTimePicker.Name = "дата_приемаDateTimePicker";
            this.дата_приемаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_приемаDateTimePicker.TabIndex = 15;
            // 
            // дата_увольненияLabel
            // 
            дата_увольненияLabel.AutoSize = true;
            дата_увольненияLabel.Location = new System.Drawing.Point(3, 219);
            дата_увольненияLabel.Name = "дата_увольненияLabel";
            дата_увольненияLabel.Size = new System.Drawing.Size(95, 13);
            дата_увольненияLabel.TabIndex = 16;
            дата_увольненияLabel.Text = "дата увольнения:";
            // 
            // дата_увольненияDateTimePicker
            // 
            this.дата_увольненияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableСотрудникBindingSource, "дата увольнения", true));
            this.дата_увольненияDateTimePicker.Location = new System.Drawing.Point(104, 215);
            this.дата_увольненияDateTimePicker.Name = "дата_увольненияDateTimePicker";
            this.дата_увольненияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_увольненияDateTimePicker.TabIndex = 17;
            // 
            // tableСведенияОВоеннойПодготовкеBindingSource
            // 
            this.tableСведенияОВоеннойПодготовкеBindingSource.DataMember = "ForeignKeyConstraintСведенияОВоеннойПодготовкеСотрудник";
            this.tableСведенияОВоеннойПодготовкеBindingSource.DataSource = this.tableСотрудникBindingSource;
            // 
            // tableСведенияОВоеннойПодготовкеTableAdapter
            // 
            this.tableСведенияОВоеннойПодготовкеTableAdapter.ClearBeforeFill = true;
            // 
            // tableСведенияОВоеннойПодготовкеDataGridView
            // 
            this.tableСведенияОВоеннойПодготовкеDataGridView.AutoGenerateColumns = false;
            this.tableСведенияОВоеннойПодготовкеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableСведенияОВоеннойПодготовкеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tableСведенияОВоеннойПодготовкеDataGridView.DataSource = this.tableСведенияОВоеннойПодготовкеBindingSource;
            this.tableСведенияОВоеннойПодготовкеDataGridView.Location = new System.Drawing.Point(12, 281);
            this.tableСведенияОВоеннойПодготовкеDataGridView.Name = "tableСведенияОВоеннойПодготовкеDataGridView";
            this.tableСведенияОВоеннойПодготовкеDataGridView.Size = new System.Drawing.Size(636, 220);
            this.tableСведенияОВоеннойПодготовкеDataGridView.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "сотрудник";
            this.dataGridViewTextBoxColumn2.HeaderText = "сотрудник";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 20;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Военная кафедра";
            this.dataGridViewTextBoxColumn3.HeaderText = "Военная кафедра";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ВоеннаяПодготовка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 561);
            this.Controls.Add(this.tableСведенияОВоеннойПодготовкеDataGridView);
            this.Controls.Add(this.tableСотрудникBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "ВоеннаяПодготовка";
            this.Text = "Сведения о военной подготовке";
            this.Load += new System.EventHandler(this.ВоеннаяПодготовка_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСотрудникBindingNavigator)).EndInit();
            this.tableСотрудникBindingNavigator.ResumeLayout(false);
            this.tableСотрудникBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableСведенияОВоеннойПодготовкеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableСведенияОВоеннойПодготовкеDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox организацияComboBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker датарожденияDateTimePicker;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.DateTimePicker дата_приемаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_увольненияDateTimePicker;
        private DB_VUSDataSetTableAdapters.TableСведенияОВоеннойПодготовкеTableAdapter tableСведенияОВоеннойПодготовкеTableAdapter;
        private System.Windows.Forms.BindingSource tableСведенияОВоеннойПодготовкеBindingSource;
        private System.Windows.Forms.DataGridView tableСведенияОВоеннойПодготовкеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}