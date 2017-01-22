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
    public partial class ВоенныйБилетСотрудника : Form
    {
        public ВоенныйБилетСотрудника()
        {
            InitializeComponent();
        }

        private void tableСотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableСотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void ВоенныйБилетСотрудника_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableВУС". При необходимости она может быть перемещена или удалена.
            this.tableВУСTableAdapter.Fill(this.dB_VUSDataSet.TableВУС);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableВоинскоеЗвание". При необходимости она может быть перемещена или удалена.
            this.tableВоинскоеЗваниеTableAdapter.Fill(this.dB_VUSDataSet.TableВоинскоеЗвание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableВидВоенныйБилет". При необходимости она может быть перемещена или удалена.
            this.tableВидВоенныйБилетTableAdapter.Fill(this.dB_VUSDataSet.TableВидВоенныйБилет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableВоенныйБилет". При необходимости она может быть перемещена или удалена.
            this.tableВоенныйБилетTableAdapter.Fill(this.dB_VUSDataSet.TableВоенныйБилет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСотрудник". При необходимости она может быть перемещена или удалена.
            this.tableСотрудникTableAdapter.Fill(this.dB_VUSDataSet.TableСотрудник);

        }
    }
}
