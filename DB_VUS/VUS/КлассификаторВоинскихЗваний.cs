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
    public partial class КлассификаторВоинскихЗваний : Form
    {
        public КлассификаторВоинскихЗваний()
        {
            InitializeComponent();
        }

        private void tableКлассификаторВоинскихЗванийBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableКлассификаторВоинскихЗванийBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void КлассификаторВоинскихЗваний_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_VUSDataSet.TableКлассификаторВоинскихЗваний' table. You can move, or remove it, as needed.
            this.tableКлассификаторВоинскихЗванийTableAdapter.Fill(this.dB_VUSDataSet.TableКлассификаторВоинскихЗваний);

        }
    }
}
