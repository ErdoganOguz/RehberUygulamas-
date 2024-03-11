using DataAccess.Entities;
using DataAccess.Entities.DTO;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
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
        string fileName = "C:\\RehberUygulaması\\Person.json";


        EfJobTitleDal jobTitleDal = new EfJobTitleDal();
        EfDepartmentDal departmentDal = new EfDepartmentDal();
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
        public void personAdd(TextBox firstname, TextBox lastname, string departmentid, string jobtitleid, MaskedTextBox number, TextBox email ,ComboBox depatrmentcombo,ComboBox titlecombo)
        {

            var person = new Person()
            {
                Id = JsonList().Count() + 1,
                FirstName = firstname.Text,
                LastName = lastname.Text,
                DepartmentId = Convert.ToInt16(departmentid),
                JobTitleId = Convert.ToInt16(jobtitleid),
                Number = number.Text,
                EmailAdress = email.Text,
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
            MessageBox.Show("Kişi Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            firstname.Clear();
            lastname.Clear();
            email.Clear();
            number.Clear();
            depatrmentcombo.Text = "";
            titlecombo.Text = "";
            
        }
        public static string RemoveSquareBrackets(string input)
        {
            if (input.StartsWith("[") && input.EndsWith("]"))
            {
                input = input.Substring(1, input.Length - 2);
            }
            return input;
        }
        public List<PersonDetailDto> PersonList(System.Windows.Forms.DataGridView gridView)
        {

            try
            {
                
                var JsonModelList = JsonList();

                var jobTitles = jobTitleDal.JsonList();
                var department = departmentDal.JsonList();

                var result = from p in JsonModelList
                             join j in jobTitles

                on p.JobTitleId equals j.Id
                             join d in department
                on p.DepartmentId equals d.Id
                             where p.IsDeleted == false

                             select new PersonDetailDto
                             {
                                 Id = p.Id,
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 Number = p.Number,
                                 DepartmentName = d.DepartmentName,
                                 Title = j.JobTitleName,
                                 EMail = p.EmailAdress,


                             };
                List<PersonDetailDto> resultList = result.ToList();
                gridView.DataSource = resultList;
                return resultList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            return null;



        }

        public void PersonDelete(int personId , DataGridView dataGrid)
        {

            DialogResult result = MessageBox.Show("Kişiyi silmek istediğinize emin misiniz? ", "Uyarı ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string json;
                    using (StreamReader r = new StreamReader(fileName))
                    {
                        json = r.ReadToEnd();
                    }

                    JArray dataArray = JArray.Parse(json);

                    foreach (JObject data in dataArray)
                    {
                        int jsonId = (int)data["Id"];
                        if (jsonId == personId)
                        {
                            data["IsDeleted"] = true;
                            break;
                        }
                    }

                    File.WriteAllText(fileName, dataArray.ToString());
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PersonList(dataGrid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public string GetPerson(TextBox FirstName, TextBox LastName, ComboBox Deparment, ComboBox Title, MaskedTextBox Number, TextBox mail, DataGridView PersonlistDgv)
        {
            FirstName.Text = PersonlistDgv.SelectedCells[1].Value.ToString();
            LastName.Text = PersonlistDgv.SelectedCells[2].Value.ToString();
            Deparment.Text = PersonlistDgv.SelectedCells[3].Value.ToString();
            Title.Text = PersonlistDgv.SelectedCells[4].Value.ToString();
            mail.Text = PersonlistDgv.SelectedCells[5].Value.ToString();
            Number.Text = PersonlistDgv.SelectedCells[6].Value.ToString();

            return null;
        }
        public int FindId(DataGridView dataGridView)
        {
            string id = dataGridView.SelectedCells[0].Value.ToString();
            return Convert.ToInt16(id);
        }
        public void PersonDetailUpdade(int personId, TextBox FirstName, TextBox LastName, string DeparmentId, string TitleId, MaskedTextBox Number, TextBox mail, ComboBox departmantcombo,ComboBox titlecombo, DataGridView dataGrid)
        {
            DialogResult result = MessageBox.Show("Kişi bilgilerini güncellemek istediğine emin misiniz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try   //FistName
                {
                    string json;
                    using (StreamReader r = new StreamReader(fileName))
                    {
                        json = r.ReadToEnd();
                    }

                    JArray dataArray = JArray.Parse(json);

                    foreach (JObject data in dataArray)
                    {
                        int jsonId = (int)data["Id"];
                        if (jsonId == personId)
                        {
                            data["FirstName"] = FirstName.Text;
                            data["LastName"] = LastName.Text;
                            data["DepartmentId"] = DeparmentId;
                            data["JobTitleId"] = TitleId;
                            data["Number"] = Number.Text;
                            data["EmailAdress"] = mail.Text;
                            break;
                        }
                    }

                    File.WriteAllText(fileName, dataArray.ToString());


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FirstName.Clear();
            LastName.Clear();
            Number.Clear();
            mail.Clear();
            departmantcombo.Text = "";
            titlecombo.Text = "";
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonList(dataGrid);

        }
        public List<PersonDetailDto> PersonSearch(DataGridView gridView ,TextBox searchTxt)
        {
            

            var JsonModelList = JsonList();

            var jobTitles = jobTitleDal.JsonList();
            var department = departmentDal.JsonList();

            var result = from p in JsonModelList
                         join j in jobTitles

            on p.JobTitleId equals j.Id
                         join d in department
            on p.DepartmentId equals d.Id
                         where p.FirstName.Contains(searchTxt.Text) || p.LastName.Contains(searchTxt.Text) || p.Number.Contains(searchTxt.Text) || d.DepartmentName.Contains(searchTxt.Text) || j.JobTitleName.Contains(searchTxt.Text) || p.EmailAdress.Contains(searchTxt.Text)
                         where p.IsDeleted == false


                         select new PersonDetailDto
                         {
                             Id = p.Id,
                             FirstName = p.FirstName,
                             LastName = p.LastName,
                             Number = p.Number,
                             DepartmentName = d.DepartmentName,
                             Title = j.JobTitleName,
                             EMail = p.EmailAdress,


                         };
            List<PersonDetailDto> resultList = result.ToList();
            gridView.DataSource = resultList;
            return resultList;



        }
    }
}
