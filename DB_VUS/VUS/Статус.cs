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
    public partial class Статус : Form
    {
        public Статус()
        {
            InitializeComponent();
        }

        private void tableСтатусСотрудникаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableСтатусСотрудникаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void Статус_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСтатусСотрудника". При необходимости она может быть перемещена или удалена.
            this.tableСтатусСотрудникаTableAdapter.Fill(this.dB_VUSDataSet.TableСтатусСотрудника);

        }
    }
}
