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
    public partial class ВУС : Form
    {
        public ВУС()
        {
            InitializeComponent();
        }

        private void tableВУСBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableВУСBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void tableВУСBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableВУСBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void ВУС_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableВУС". При необходимости она может быть перемещена или удалена.
            this.tableВУСTableAdapter.Fill(this.dB_VUSDataSet.TableВУС);

        }
    }
}
