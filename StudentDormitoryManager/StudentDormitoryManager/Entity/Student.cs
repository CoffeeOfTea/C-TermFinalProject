using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDormitoryManager.Entity
{
    class Student
    {
        private string _stuid;

        public string Stuid
        {
            get { return _stuid; }
            set { _stuid = value; }
        }
        private string _stuname;

        public string Stuname
        {
            get { return _stuname; }
            set { _stuname = value; }
        }
        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        private int _depid;

        public int Depid
        {
            get { return _depid; }
            set { _depid = value; }
        }

        
        private int _dorid;

        public int Dorid
        {
            get { return _dorid; }
            set { _dorid = value; }
        }
    }
}
