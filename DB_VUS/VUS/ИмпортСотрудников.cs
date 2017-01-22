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
    public partial class ИмпортСотрудников : Form
    {
        Random rnd;

        public ИмпортСотрудников()
        {
            InitializeComponent();
            rnd = new Random();
        }

        // генератор случайной даты рождения
        // 1953 декабрь - 1995 декабрь 
        public DateTime GetDateTimeBirthday()
        {
            DateTime dtRandom;
            DateTime beg = new DateTime(1953,12,1);
            DateTime end = new DateTime(1995,12,1);
            // диапазон генерируемых значений
            TimeSpan range = end - beg;
            dtRandom = beg.AddDays(rnd.Next(0, range.Days));
            return dtRandom;
        }

        // генератор даты приема на работу
        // 2000 январь - 2013 декабрь 
        public DateTime GetDateTimeWork()
        {
            DateTime dtRandom;
            DateTime beg = new DateTime(2000, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);
            // диапазон генерируемых значений
            TimeSpan range = end - beg;
            dtRandom = beg.AddDays(rnd.Next(0, range.Days));
            return dtRandom;
        }

        private void buttonИмпорт_Click(object sender, EventArgs e)
        {
            char Sex='F';
            string[] lines = System.IO.File.ReadAllLines(textBox1.Text);
            // подключаемся к БД
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.DB_VUSConnectionString);
            conn.Open();
            foreach (string val in lines)
            {
                string[] fio = val.ToUpper().Split(' ');
                int КатегорияГодности = rnd.Next(1, 6);
                Sex='M';

                DateTime birthday = GetDateTimeBirthday(); // дата рождения
                DateTime work = GetDateTimeWork();         // дата приема на работу
                int status = rnd.Next(1, 4);               // статус
                
                if (Sex == 'F') КатегорияГодности = 6;
                if ((String.Compare(fio[0].Substring(fio[0].Length-1,1),"А")==0) || (String.Compare(fio[0].Substring(fio[0].Length-1,1),"Я")==0))
                {
                    Sex='F';
                    КатегорияГодности = 6;
                }
                int спец = rnd.Next(1, 8);
                SqlCommand cmd = new SqlCommand("insert into TableСотрудник (" +
                    "[организация],[фамилия],имя, отчество, датарождения, пол, [паспортные данные], [адрес жительства],[адрес пребывания], статус, [дата приема], [категория годности], [специальность]) values" +
                    "(1,@family,@name,@otch,@birth, @sex,@passport, @adres1, @adres2, @status, @workdt, @kat, @spec)", conn);
                cmd.Parameters.Add(new SqlParameter("@family", fio[2]));
                cmd.Parameters.Add(new SqlParameter("@name", fio[0]));
                cmd.Parameters.Add(new SqlParameter("@otch", fio[1]));
                cmd.Parameters.Add(new SqlParameter("@birth", birthday));
                cmd.Parameters.Add(new SqlParameter("@sex", Sex));
                cmd.Parameters.Add(new SqlParameter("@passport", " "));
                cmd.Parameters.Add(new SqlParameter("@adres1", " "));
                cmd.Parameters.Add(new SqlParameter("@adres2", " "));
                cmd.Parameters.Add(new SqlParameter("@status", status));
                cmd.Parameters.Add(new SqlParameter("@workdt", work));
                cmd.Parameters.Add(new SqlParameter("@kat", КатегорияГодности));
                cmd.Parameters.Add(new SqlParameter("@spec", спец));
                cmd.ExecuteNonQuery();
            }

           conn.Close();
           Close();
        }
    }
}
