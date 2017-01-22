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
    public partial class ОтборСтатусАдрес : Form
    {
        public ОтборСтатусАдрес()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string address = "%" + adresToolStripTextBox.Text.Trim() + "%";
                this.dataFiltrStatusAddressTableAdapter.Fill(this.dB_VUSDataSet.DataFiltrStatusAddress, (int)comboBox1.SelectedValue, address);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ОтборСтатусАдрес_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСтатусСотрудника". При необходимости она может быть перемещена или удалена.
            this.tableСтатусСотрудникаTableAdapter.Fill(this.dB_VUSDataSet.TableСтатусСотрудника);

        }
    }
}
