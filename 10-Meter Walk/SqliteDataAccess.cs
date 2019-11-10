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
        public static List<TestModel> LoadTests()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TestModel>("select * from Tests", new DynamicParameters());
                return output.ToList();
            }
        }

        //executes an insert statement to the sqlite database
        public static void SaveTest(TestModel test)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string queryString = "insert into Tests (First, Last, \'Date of Birth\', \'Test Date\', \'Test Time\', Notes, \'Admin Name\') " +
                    "values(\"" + test.PatientFirst + "\", \"" + test.PatientLast + "\", \"" +
                    test.PatientDOB + "\", \"" + test.TestDate + "\", \"" + test.TestTime + "\", \"" +
                    test.Notes + "\", \"" + test.AdminName + "\")";
                Console.WriteLine(queryString);
                cnn.Execute(queryString);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
