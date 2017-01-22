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
    public partial class СоставПрофиль : Form
    {
        public СоставПрофиль()
        {
            InitializeComponent();
        }

        private void tableСоставПрофильBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableСоставПрофильBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void СоставПрофиль_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_VUSDataSet.TableСоставПрофиль' table. You can move, or remove it, as needed.
            this.tableСоставПрофильTableAdapter.Fill(this.dB_VUSDataSet.TableСоставПрофиль);

        }
    }
}
