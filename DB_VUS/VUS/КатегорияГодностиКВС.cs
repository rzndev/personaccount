﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VUS
{
    public partial class КатегорияГодностиКВС : Form
    {
        public КатегорияГодностиКВС()
        {
            InitializeComponent();
        }

        private void tableКатегорияГодностиКВСBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableКатегорияГодностиКВСBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_VUSDataSet);

        }

        private void КатегорияГодностиКВС_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_VUSDataSet.TableКатегорияГодностиКВС' table. You can move, or remove it, as needed.
            this.tableКатегорияГодностиКВСTableAdapter.Fill(this.dB_VUSDataSet.TableКатегорияГодностиКВС);

        }
    }
}
