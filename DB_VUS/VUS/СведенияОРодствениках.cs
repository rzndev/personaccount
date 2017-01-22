using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VUS
{
    public partial class СведенияОРодствениках : Form
    {
        public СведенияОРодствениках()
        {
            InitializeComponent();
        }

        private void tableСотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableСотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void tableСотрудникBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableСотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void СведенияОРодствениках_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСведенияОРодственниках". При необходимости она может быть перемещена или удалена.
            this.tableСведенияОРодственникахTableAdapter.Fill(this.dB_VUSDataSet.TableСведенияОРодственниках);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСотрудник". При необходимости она может быть перемещена или удалена.
            this.tableСотрудникTableAdapter.Fill(this.dB_VUSDataSet.TableСотрудник);

        }
    }
}
