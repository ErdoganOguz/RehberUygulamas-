using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class AppRepository
    {
        public string DirectoryAddress { get; set; }
        public string JsonPerson { get; set; }
        public string JsonTitle { get; set; }
        public string JsonDepartment { get; set; }
        public void CheckRepository()
        {

            DirectoryAddress = "C:\\RehberUygulaması";
            JsonPerson = Path.Combine(DirectoryAddress, "Person.json");
            JsonTitle = Path.Combine(DirectoryAddress, "JobTitle.json");
            JsonDepartment = Path.Combine(DirectoryAddress, "Department.json");

            bool checkDirectory = Directory.Exists(DirectoryAddress);
            if (!checkDirectory)
            {
                Directory.CreateDirectory(DirectoryAddress);
            }

            if (!File.Exists(JsonPerson))
            {
                using (StreamWriter sw = File.CreateText(JsonPerson))
                {
                    sw.Write(@"[{
  ""FirstName"": ""demo"",
  ""LastName"": ""demo"",
  ""DepartmentId"": 0,
  ""JobTitleId"": 0,
  ""Number"": ""demo"",
  ""EmailAdress"": ""demo"",
  ""Id"": 0,
  ""IsDeleted"": true,
  ""CreateDate"": ""2024-03-08T10:42:21.7096765+03:00""
}]");
                }
            }
            bool checkJsonTitle = File.Exists(JsonTitle);
            if (!File.Exists(JsonTitle))
            {
                using (StreamWriter sw = File.CreateText(JsonTitle))
                {
                    sw.Write(@" [{
    ""JobTitleName"": ""demo"",
    ""Id"": 0,
    ""IsDeleted"": true,
    ""CreateDate"": ""2024-03-05T14:01:00.2437019+03:00""
  }]");
                }

            }
            if (!File.Exists(JsonDepartment))
            {
                using (StreamWriter sw = File.CreateText(JsonDepartment))
                {
                    sw.Write(@" [{
    ""DepartmentName"": ""demo"",
    ""Id"": 0,
    ""IsDeleted"": true,
    ""CreateDate"": ""2024-03-05T12:58:39.345636+03:00""
  }]");
                }

            }




        }

    }
}
