using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDormitoryManager.Entity
{
    class Dormitory
    {
        private int _dorid;

        public int Dorid
        {
            get { return _dorid; }
            set { _dorid = value; }
        }

        private string _dorhonor;

        public string Dorhonor
        {
            get { return _dorhonor; }
            set { _dorhonor = value; }
        }
        private int _blockno;

        public int Blockno
        {
            get { return _blockno; }
            set { _blockno = value; }
        }
    }
}
