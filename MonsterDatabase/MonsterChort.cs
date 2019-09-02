using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDatabase
{
    class MonsterChort
    {
        private string subject;
        private DateTime startdate;
        private string listofstudent;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public DateTime StartDate
        {
            get { return startdate; }
            set { startdate = value; }
        }
        public string ListOfStudent
        {
            get { return listofstudent; }
            set { listofstudent = value; }
        }

    }
}
