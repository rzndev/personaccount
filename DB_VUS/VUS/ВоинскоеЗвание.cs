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
    public partial class ВоинскоеЗвание : Form
    {
        public ВоинскоеЗвание()
        {
            InitializeComponent();
        }

        private void tableВоинскоеЗваниеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableВоинскоеЗваниеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void tableВоинскоеЗваниеBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableВоинскоеЗваниеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void ВоинскоеЗвание_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_VUSDataSet.TableКлассификаторВоинскихЗваний' table. You can move, or remove it, as needed.
            this.tableКлассификаторВоинскихЗванийTableAdapter.Fill(this.dB_VUSDataSet.TableКлассификаторВоинскихЗваний);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableВоинскоеЗвание". При необходимости она может быть перемещена или удалена.
            this.tableВоинскоеЗваниеTableAdapter.Fill(this.dB_VUSDataSet.TableВоинскоеЗвание);

        }
    }
}
