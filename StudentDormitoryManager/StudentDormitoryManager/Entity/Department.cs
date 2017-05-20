using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDormitoryManager.Entity
{
    class Department
    {
        private int _depid;

        public int Depid
        {
            get { return _depid; }
            set { _depid = value; }
        }
        private string _depname;

        public string Depname
        {
            get { return _depname; }
            set { _depname = value; }
        }
    }
}
