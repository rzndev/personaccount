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
    public partial class Специальность : Form
    {
        public Специальность()
        {
            InitializeComponent();
        }

        private void tableСпециальностьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableСпециальностьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void Специальность_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableКлассификаторСпециальности". При необходимости она может быть перемещена или удалена.
            this.tableКлассификаторСпециальностиTableAdapter.Fill(this.dB_VUSDataSet.TableКлассификаторСпециальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСпециальность". При необходимости она может быть перемещена или удалена.
            this.tableСпециальностьTableAdapter.Fill(this.dB_VUSDataSet.TableСпециальность);

        }
    }
}
