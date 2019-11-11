using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Meter_Walk
{
    public class TestModel
    {
        private string patientFirst;
        private string patientLast;
        private string patientDOB;
        private string testDate;
        private string testTime;
        private string adminName;
        private string notes;

        //to make fields visible to the database writer
        public string PatientFirst
        {
            get { return this.patientFirst; }
            set { patientFirst = value; }
        }
        public string PatientLast
        {
            get { return this.patientLast; }
            set { patientLast = value; }
        }
        public string PatientDOB
        {
            get { return this.patientDOB; }
            set { patientDOB = value; }
        }
        public string TestDate
        {
            get { return this.testDate; }
            set { testDate = value; }
        }
        public string TestTime
        {
            get { return this.testTime; }
            set { testTime = value; }
        }
        public string AdminName
        {
            get { return this.adminName; }
            set { adminName = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { notes = value; }
        }
    }
}
