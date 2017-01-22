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
    public partial class ОтборСтатусВУС : Form
    {
        public ОтборСтатусВУС()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTableStatusVusTableAdapter.Fill(this.dB_VUSDataSet.DataTableStatusVus, (int)comboBoxStatus.SelectedValue, (int)comboBoxVUS.SelectedValue);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ОтборСтатусВУС_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableВУС". При необходимости она может быть перемещена или удалена.
            this.tableВУСTableAdapter.Fill(this.dB_VUSDataSet.TableВУС);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСтатусСотрудника". При необходимости она может быть перемещена или удалена.
            this.tableСтатусСотрудникаTableAdapter.Fill(this.dB_VUSDataSet.TableСтатусСотрудника);

        }
    }
}
