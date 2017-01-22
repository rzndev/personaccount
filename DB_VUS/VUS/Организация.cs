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
    public partial class Организация : Form
    {
        public Организация()
        {
            InitializeComponent();
        }

        private void tableСведенияОбОрганизацииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableСведенияОбОрганизацииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void Организация_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСведенияОбОрганизации". При необходимости она может быть перемещена или удалена.
            this.tableСведенияОбОрганизацииTableAdapter.Fill(this.dB_VUSDataSet.TableСведенияОбОрганизации);

        }
    }
}
