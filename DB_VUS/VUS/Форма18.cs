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
    public partial class Форма18 : Form
    {
        public Форма18()
        {
            InitializeComponent();
        }

        private void Форма18_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableОтчет18_3". При необходимости она может быть перемещена или удалена.
            this.tableОтчет18_3TableAdapter.Fill(this.dB_VUSDataSet.TableОтчет18_3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableОтчет18_2". При необходимости она может быть перемещена или удалена.
            this.tableОтчет18_2TableAdapter.Fill(this.dB_VUSDataSet.TableОтчет18_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableОтчет18_1". При необходимости она может быть перемещена или удалена.
            this.tableОтчет18_1TableAdapter.Fill(this.dB_VUSDataSet.TableОтчет18_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_VUSDataSet.TableОтчет18". При необходимости она может быть перемещена или удалена.
            this.tableОтчет18TableAdapter.Fill(this.dB_VUSDataSet.TableОтчет18);

            this.reportViewer1.RefreshReport();
        }
    }
}
