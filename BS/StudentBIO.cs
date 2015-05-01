using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dul;

namespace BS
{
    public class StudentBIO
    {
        StudentDataAccess objStu = new StudentDataAccess();

        public bool saveStudentInfo(Student obj)
        {
            return objStu.saveStudentInfo(obj);
        }

        public List<Student> getStudentInfo()
        {
            return objStu.getStudentInfo();
        }


    }
}
