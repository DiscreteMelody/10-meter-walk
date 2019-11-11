using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Meter_Walk
{
    public class SqliteDataAccess
    {
        /// <summary>
        /// returns a list of tests where the database records match the given inputs
        /// </summary>
        /// <returns></returns>
        public static List<TestModel> LoadTests(string patient_first, string patient_last, string patient_DOB)
        {
            
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlQuery = @"select * from Tests where PatientFirst = '" + patient_first + @"' and PatientLast = '" + patient_last + @"' and PatientDOB = '" + patient_DOB + @"'";
                var output = cnn.Query<TestModel>(sqlQuery, new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// deletes the first instance of a matching test
        /// </summary>
        /// <param name="test">the test to be deleted</param>
        public static void deleteRecord(TestModel test)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlQuery = 
                    @"delete from Tests where PatientFirst = '" + test.PatientFirst + @"' and " +
                    @"PatientLast = '" + test.PatientLast + @"' and " +
                    @"PatientDOB = '" + test.PatientDOB + @"' and " +
                    @"TestDate = '" + test.TestDate + @"' and " +
                    @"TestTime = '" + test.TestTime + @"' and " +
                    @"Notes = '" + test.Notes + @"' and " +
                    @"AdminName = '" + test.AdminName + @"'";

                cnn.Query(sqlQuery, new DynamicParameters());
            }
        }

        /// <summary>
        /// executes an insert statement to the sqlite database
        /// </summary>
        /// <param name="test">The test to save</param>
        public static void SaveTest(TestModel test)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string queryString = @"insert into Tests (PatientFirst, PatientLast, PatientDOB, TestDate, TestTime, Notes, AdminName) " +
                    @"values(@PatientFirst, @PatientLast, @PatientDOB, @TestDate, @TestTime, @Notes, @AdminName)";
                cnn.Execute(queryString, test);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
