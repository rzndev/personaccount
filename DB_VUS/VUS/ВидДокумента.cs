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
    public partial class ВидДокумента : Form
    {
        public ВидДокумента()
        {
            InitializeComponent();
        }

        private void tableВидВоенныйБилетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableВидВоенныйБилетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void ВидДокумента_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableВидВоенныйБилет". При необходимости она может быть перемещена или удалена.
            this.tableВидВоенныйБилетTableAdapter.Fill(this.dB_VUSDataSet.TableВидВоенныйБилет);

        }
    }
}
