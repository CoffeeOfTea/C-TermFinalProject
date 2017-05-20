using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDormitoryManager.Entity
{
    class HealthScore
    {
        private int _hsid;

        public int Hsid
        {
            get { return _hsid; }
            set { _hsid = value; }
        }
        private int _dorid;

        public int Dorid
        {
            get { return _dorid; }
            set { _dorid = value; }
        }

        private int _score;

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
        private string _checkdate;

        public string Checkdate
        {
            get { return _checkdate; }
            set { _checkdate = value; }
        }
    }
}
