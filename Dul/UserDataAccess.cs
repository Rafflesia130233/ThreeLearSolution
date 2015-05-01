using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Dul
{
    public class UserDataAccess
    {
        #region userStudentInfo

        public bool userStudentInfo(Student Sobj)
        {
            try
            {
                StreamWriter write = new StreamWriter("E:\\Test.txt", true);
                write.WriteLine(Sobj.name);
                //write.WriteLine(Sobj.accountnumber);
                write.WriteLine(Sobj.accountBranch);
                write.WriteLine(Sobj.gender);
                write.WriteLine(Sobj.age);
                write.WriteLine(Sobj.address);
                write.WriteLine(Sobj.contact);

                write.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        #endregion

        #region getStudentInfo


        public List<Student> getStudentInfo()
        {
            try
            {
                StreamReader read = new StreamReader("E:\\Test.txt");

                List<Student> st_obj_DA = new List<Student>();
                String nullCheck;
                while ((nullCheck = read.ReadLine()) != null)
                {
                    Student st = new Student();
                    st.name = nullCheck;
                    st.accountnumber = read.ReadLine();
                    st.accountBranch = read.ReadLine();
                    st.year = Convert.ToInt32(read.ReadLine());
                    st.term = Convert.ToInt32(read.ReadLine());
                    st.address = read.ReadLine();
                    st.contact = read.ReadLine();

                    st_obj_DA.Add(st);

                }
                read.Close();

                return st_obj_DA;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion
    }
}
