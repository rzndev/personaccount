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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void видДокументаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ВидДокумента frm = new ВидДокумента();
            frm.Show();
        }

        private void воинскиеЗванияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ВоинскоеЗвание frm = new ВоинскоеЗвание();
            frm.Show();
        }

        private void вУСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ВУС frm = new ВУС();
            frm.Show();
        }

        private void специальностьКлассификаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СпециальностьКлассификатор frm = new СпециальностьКлассификатор();
            frm.Show();
        }

        private void причиныНеПрохожденияСлужбыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ПричиныНеПрохожденияСлужбы frm = new ПричиныНеПрохожденияСлужбы();
            frm.Show();
        }

        private void сведенияОбОрганизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Организация frm = new Организация();
            frm.Show();
        }

        private void специальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Специальность frm = new Специальность();
            frm.Show();
        }

        private void видыСтатусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Статус frm = new Статус();
            frm.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сотрудник frm = new Сотрудник();
            frm.Show();
        }

        private void военныйБилетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ВоенныйБилетСотрудника frm = new ВоенныйБилетСотрудника();
            frm.Show();
        }

        private void сведенияОРодственникахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СведенияОРодствениках frm = new СведенияОРодствениках();
            frm.Show();
        }

        private void военнаяПодготовкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ВоеннаяПодготовка frm = new ВоеннаяПодготовка();
            frm.Show();
        }

        private void сведенияОПричинахНеПрохожденияСлужюыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ПричиныНеПрохожденияСлужбыСотрудником frm = new ПричиныНеПрохожденияСлужбыСотрудником();
            frm.Show();
        }

        private void форма6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Форма6 frm = new Форма6();
            frm.Show();
        }

        private void категорияГодностиКВСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            КатегорияГодностиКВС frm = new КатегорияГодностиКВС();
            frm.Show();
        }

        private void составпрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СоставПрофиль frm = new СоставПрофиль();
            frm.Show();
        }

        private void формаТ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ФормаT2 frm = new ФормаT2();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void статусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ОтборСтатус frm = new ОтборСтатус();
            frm.Show();
        }

        private void форма18ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Форма18 frm = new Форма18();
            frm.Show();
        }

        private void классификаторВоинскихЗванийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            КлассификаторВоинскихЗваний frm = new КлассификаторВоинскихЗваний();
            frm.Show();
        }

        private void импортВУСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ИмпортВУС frm = new ИмпортВУС();
            frm.Show();
        }

        private void импортСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ИмпортСотрудников frm = new ИмпортСотрудников();
            frm.Show();
        }

        private void адресToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ОтборСтатусАдрес frm = new ОтборСтатусАдрес();
            frm.Show();
        }

        private void вУСToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ОтборСтатусВУС frm = new ОтборСтатусВУС();
            frm.Show();
        }
    }
}
