using DataAccess.Entities;
using Newtonsoft.Json;
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


        public List<Person> JsonList()
        {
            List<Person> JsonModelList = null;

            try
            {

                string fileName = "C:\\Users\\oğuz\\source\\repos\\RehberUygulaması\\DataAccess\\Json\\person.json";
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

                string fileName = "C:\\Users\\oğuz\\source\\repos\\RehberUygulaması\\DataAccess\\Json\\person.json";

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
        
    }
}
