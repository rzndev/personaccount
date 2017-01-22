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
    public partial class ПричиныНеПрохожденияСлужбыСотрудником : Form
    {
        public ПричиныНеПрохожденияСлужбыСотрудником()
        {
            InitializeComponent();
        }

        private void tableСотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableСотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void ПричиныНеПрохожденияСлужюыСотрудником_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableКлассификаторПричиныНеПрохожденияСлужбы". При необходимости она может быть перемещена или удалена.
            this.tableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter.Fill(this.dB_VUSDataSet.TableКлассификаторПричиныНеПрохожденияСлужбы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableПричиныНеПрохоженияСлужбы". При необходимости она может быть перемещена или удалена.
            this.tableПричиныНеПрохоженияСлужбыTableAdapter.Fill(this.dB_VUSDataSet.TableПричиныНеПрохоженияСлужбы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableСотрудник". При необходимости она может быть перемещена или удалена.
            this.tableСотрудникTableAdapter.Fill(this.dB_VUSDataSet.TableСотрудник);

        }
    }
}
