using DataAccess.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataAccess.Concrete
{
    public class EfPersonDal : Person
    {
        string fileName = "C:\\Users\\oğuz\\source\\repos\\RehberUygulaması\\DataAccess\\Json\\person.json";


        public List<Person> JsonList()
        {
            List<Person> JsonModelList = null;

            try
            {
                dynamic JsonText = File.ReadAllText(fileName);
                JsonModelList = JsonConvert.DeserializeObject<List<Person>>(JsonText);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            return JsonModelList;
        }
        public void personAdd(string firstname, string lastname, int departmentid, int jobtitleid, string number, string email)
        {
            try
            {
                var person = new Person()
                {
                    Id = JsonList().Count() + 1,
                    FirstName = firstname,
                    LastName = lastname,
                    DepartmentId = departmentid,
                    JobTitleId = jobtitleid,
                    Number = number,
                    EmailAdress = email,
                    CreateDate = DateTime.Now,
                    IsDeleted = false
                };
                List<Person> data = JsonList();
                var oldData = JsonConvert.SerializeObject(data, Formatting.Indented);
                var personJson = JsonConvert.SerializeObject(person, Formatting.Indented);
                oldData = RemoveSquareBrackets(oldData);
                File.WriteAllText(fileName, " ");
                File.WriteAllText(fileName, "[" + oldData + "," + personJson + "]");
                RemoveSquareBrackets(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static string RemoveSquareBrackets(string input)
        {
            if (input.StartsWith("[") && input.EndsWith("]"))
            {
                input = input.Substring(1, input.Length - 2);
            }
            return input;
        }
        public void JobTitleFilter()
        {
            try
            {
                string fileName = "C:\\Users\\oğuz\\source\\repos\\RehberUygulaması\\DataAccess\\Json\\JobTitle.json";
                string json;
                using (StreamReader r = new StreamReader(fileName))
                {
                    json = r.ReadToEnd();
                }


                JArray dataArray = JArray.Parse(json);

                // string JobTitleName = dataArray["JobTitleName"].ToString();

                foreach (JObject data in dataArray)
                {
                    string JobTitleName = data["JobTitleName"].ToString();
                    MessageBox.Show(Convert.ToString(JobTitleName));
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             ;
        }
    }
}
