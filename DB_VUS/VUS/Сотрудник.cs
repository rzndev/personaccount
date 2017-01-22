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
    public partial class Сотрудник : Form
    {
        public Сотрудник()
        {
            InitializeComponent();
        }

        private void tableСотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableСотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void Сотрудник_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_VUSDataSet.TableСпециальность' table. You can move, or remove it, as needed.
            this.tableСпециальностьTableAdapter.Fill(this.dB_VUSDataSet.TableСпециальность);
            // TODO: This line of code loads data into the 'dB_VUSDataSet.TableКатегорияГодностиКВС' table. You can move, or remove it, as needed.
            this.tableКатегорияГодностиКВСTableAdapter.Fill(this.dB_VUSDataSet.TableКатегорияГодностиКВС);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСтатусСотрудника". При необходимости она может быть перемещена или удалена.
            this.tableСтатусСотрудникаTableAdapter.Fill(this.dB_VUSDataSet.TableСтатусСотрудника);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСведенияОбОрганизации". При необходимости она может быть перемещена или удалена.
            this.tableСведенияОбОрганизацииTableAdapter.Fill(this.dB_VUSDataSet.TableСведенияОбОрганизации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСотрудник". При необходимости она может быть перемещена или удалена.
            this.tableСотрудникTableAdapter.Fill(this.dB_VUSDataSet.TableСотрудник);

        }
    }
}
