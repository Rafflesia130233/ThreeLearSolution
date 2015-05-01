using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BS;
using Dul;


namespace UI_Form
{
    public partial class Form1 : Form
    {
        StudentBIO sbio_obj_1 = new StudentBIO();
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            try
            {

                Student st_obj_1 = new Student();

                st_obj_1.name = textname.Text;
                st_obj_1.roll = textroll.Text;
                st_obj_1.batch = textbatch.Text;
                st_obj_1.year = Convert.ToInt32(comboYear.Text);
                st_obj_1.term = Convert.ToInt32(comboTerm.Text);
                st_obj_1.address = textadd.Text;
                st_obj_1.contact = textcont.Text;

                sbio_obj_1.saveStudentInfo(st_obj_1);

                MessageBox.Show("Informatio saved");

                textname.ResetText();
                textroll.ResetText();
                textbatch.ResetText();
                comboYear.ResetText();
                comboTerm.ResetText();
                textadd.ResetText();
                textcont.ResetText();
            }
            catch (Exception e1)
            {
                MessageBox.Show("R u kidding");
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
