using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtil
{
    public class Student
    {
        private string name;
        private int maSV;
        private int nam;
        private string maKH;

        public Student()
        {

        }

        public Student(string name, int maSV, int nam, string maKH)
        {
            this.name = name;
            this.maSV = maSV;
            this.nam = nam;
            this.maKH = maKH;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public int Nam
        {
            get { return nam; }
            set { nam = value; }
        }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
    }
}

