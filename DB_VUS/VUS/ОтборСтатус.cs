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
    public partial class ОтборСтатус : Form
    {
        public ОтборСтатус()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataFiltrStatusDateTableAdapter.Fill(this.dB_VUSDataSet.DataFiltrStatusDate, (int)comboBox1.SelectedValue, paramData1ToolStripTextBox.Text, paramData2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ОтборСтатус_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСтатусСотрудника". При необходимости она может быть перемещена или удалена.
            this.tableСтатусСотрудникаTableAdapter.Fill(this.dB_VUSDataSet.TableСтатусСотрудника);

        }
    }
}
