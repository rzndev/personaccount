﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VUS
{
    public partial class ВоеннаяПодготовка : Form
    {
        public ВоеннаяПодготовка()
        {
            InitializeComponent();
        }

        private void tableСотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableСотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void ВоеннаяПодготовка_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСведенияОВоеннойПодготовке". При необходимости она может быть перемещена или удалена.
            this.tableСведенияОВоеннойПодготовкеTableAdapter.Fill(this.dB_VUSDataSet.TableСведенияОВоеннойПодготовке);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСотрудник". При необходимости она может быть перемещена или удалена.
            this.tableСотрудникTableAdapter.Fill(this.dB_VUSDataSet.TableСотрудник);

        }
    }
}
