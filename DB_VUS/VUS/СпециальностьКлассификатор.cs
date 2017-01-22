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
    public partial class СпециальностьКлассификатор : Form
    {
        public СпециальностьКлассификатор()
        {
            InitializeComponent();
        }

        private void tableКлассификаторСпециальностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableКлассификаторСпециальностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void Специальность_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableКлассификаторСпециальности". При необходимости она может быть перемещена или удалена.
            this.tableКлассификаторСпециальностиTableAdapter.Fill(this.dB_VUSDataSet.TableКлассификаторСпециальности);

        }
    }
}
