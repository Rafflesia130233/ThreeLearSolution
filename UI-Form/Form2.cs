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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            StudentBIO sbio_obj = new StudentBIO();


            List<Student> st_obj = new List<Student>();

            st_obj = sbio_obj.getStudentInfo();

            for (int i = 0; i < st_obj.Count; i++)
            {
                ListViewItem list = new ListViewItem(st_obj[i].name);

                list.SubItems.Add(st_obj[i].roll);
                list.SubItems.Add(st_obj[i].batch);
                list.SubItems.Add(Convert.ToString(st_obj[i].year));
                list.SubItems.Add(Convert.ToString(st_obj[i].term));
                list.SubItems.Add(st_obj[i].address);
                list.SubItems.Add(st_obj[i].contact);

                listView.Items.Add(list);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
