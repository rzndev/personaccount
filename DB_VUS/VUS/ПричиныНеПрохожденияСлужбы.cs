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
    public partial class ПричиныНеПрохожденияСлужбы : Form
    {
        public ПричиныНеПрохожденияСлужбы()
        {
            InitializeComponent();
        }

        private void tableКлассификаторПричиныНеПрохожденияСлужбыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableКлассификаторПричиныНеПрохожденияСлужбыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void ПричиныНеПрохожденияСлужбы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableКлассификаторПричиныНеПрохожденияСлужбы". При необходимости она может быть перемещена или удалена.
            this.tableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter.Fill(this.dB_VUSDataSet.TableКлассификаторПричиныНеПрохожденияСлужбы);

        }
    }
}
