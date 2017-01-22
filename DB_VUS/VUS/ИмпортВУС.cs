using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VUS
{
    public partial class ИмпортВУС : Form
    {
        public ИмпортВУС()
        {
            InitializeComponent();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            string st; // строка для добавления
            bool bSpecNum = true;
            int ival = -1;
            string[] lines = System.IO.File.ReadAllLines(textBox1.Text);
            // подключаемся к БД
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.DB_VUSConnectionString);
            conn.Open();
            foreach (string val in lines)
            {
                if (string.IsNullOrEmpty(val.Trim())) continue;
                if (bSpecNum)
                {
                    ival = -1;
                    if (int.TryParse(val, out ival) == true)
                    {

                    }
                    else
                        continue;
                }
                else
                {
                    // ival - код специальности
                    // val - наименование, которое добавляется в БД
                    if (ival == -1) continue;
                    st = val.Trim();
                    st = (st.Length > 199) ? st.Substring(0,198) : st;
                    SqlCommand cmd = new SqlCommand("insert into TableВУС ([код спечиальности],[наименование],состав) values(@kod,@name,1)", conn);
                    cmd.Parameters.Add(new SqlParameter("@kod", ival.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@name", st));
                    cmd.ExecuteNonQuery();
                }

                bSpecNum = !bSpecNum;
            }
            conn.Close();
            Close();
        }
    }
}
