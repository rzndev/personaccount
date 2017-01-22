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
    public partial class ФормаT2 : Form
    {
        public ФормаT2()
        {
            InitializeComponent();
        }

        private void ФормаT2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСотрудник". При необходимости она может быть перемещена или удалена.
            this.tableСотрудникTableAdapter.Fill(this.dB_VUSDataSet.TableСотрудник);

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.DataTableОтчетТ2". При необходимости она может быть перемещена или удалена.
            this.dataTableОтчетТ2TableAdapter.Fill(this.dB_VUSDataSet.DataTableОтчетТ2, (int)comboBox1.SelectedValue);
            this.reportViewer1.RefreshReport();
        }
    }
}
