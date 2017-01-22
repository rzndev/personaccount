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
    public partial class Форма6 : Form
    {
        public Форма6()
        {
            InitializeComponent();
        }

        private void Форма6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_VUSDataSet.TableКлассификаторПричиныНеПрохожденияСлужбы' table. You can move, or remove it, as needed.
            this.TableКлассификаторПричиныНеПрохожденияСлужбыTableAdapter.Fill(this.DB_VUSDataSet.TableКлассификаторПричиныНеПрохожденияСлужбы);

            this.reportViewer1.RefreshReport();
        }
    }
}
