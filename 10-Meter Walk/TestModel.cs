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
        }
        public string PatientLast
        {
            get { return this.patientLast; }
        }
        public string PatientDOB
        {
            get { return this.patientDOB; }
        }
        public string TestDate
        {
            get { return this.testDate; }
        }
        public string TestTime
        {
            get { return this.testTime; }
        }
        public string AdminName
        {
            get { return this.adminName; }
        }
        public string Notes
        {
            get { return this.notes; }
        }

        public TestModel(
            string patient_first, string patient_last, string patient_DOB,
            string test_date, string test_time, string admin_name, string test_notes)
        {
            patientFirst = patient_first;
            patientLast = patient_last;
            patientDOB = patient_DOB;
            testDate = test_date;
            testTime = test_time;
            adminName = admin_name;
            notes = test_notes;
        }
    }
}
