using DataAccess.Entities;
using DataAccess.Entities.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfDepartmentDal : Department
    {
        string fileName = "C:\\RehberUygulaması\\Department.json";
        string DepartmentId;
        
        public List<Department> JsonList()
        {
            List<Department> JsonModelList = null;

            try
            {
                dynamic JsonText = File.ReadAllText(fileName);
                JsonModelList = JsonConvert.DeserializeObject<List<Department>>(JsonText);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            return JsonModelList;
        }
        public void departmentAdd(string departmentName)
        {
            try
            {
                var department = new Department()
                {

                    Id = JsonList().Count() + 1,
                    DepartmentName = departmentName,
                    CreateDate = DateTime.Now,
                    IsDeleted = false
                };
                List<Department> data = JsonList();
                var oldData = JsonConvert.SerializeObject(data, Formatting.Indented);
                var departmentJson = JsonConvert.SerializeObject(department, Formatting.Indented);
                oldData = RemoveSquareBrackets(oldData);
                File.WriteAllText(fileName, " ");
                File.WriteAllText(fileName, "[" + oldData + "," + departmentJson + "]");
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

        public string departmentFilter(string comboSelect)
        {
            try
            {

                string json;
                using (StreamReader r = new StreamReader(fileName))
                {
                    json = r.ReadToEnd();
                }


                JArray dataArray = JArray.Parse(json);

                // string JobTitleName = dataArray["JobTitleName"].ToString();

                foreach (JObject data in dataArray)
                {


                    string DepartmentName = data["DepartmentName"].ToString();
                    if (DepartmentName == comboSelect)
                    {



                        DepartmentId = data["Id"].ToString();

                        return DepartmentId;




                    }
                    //MessageBox.Show(Convert.ToString(JobTitleName));

                }
                return " Lütfen Bölüm Seçiniz ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }
        public void DepartmentComboList(System.Windows.Forms.ComboBox comboBox)
        {
            
            comboBox.Items.Clear();

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
                    bool deleted = ((bool)data["IsDeleted"]);

                    if (!deleted )
                    {
                        string DepartmentName = data["DepartmentName"].ToString();
                        comboBox.Items.Add(DepartmentName);
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Bir Hata Oluştu", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
        public List<DepartmentDetailDto> DepartmentList(DataGridView dataGrid)
        {

            var departmentList = JsonList();
            var result = from d in departmentList
                         where d.IsDeleted == false

                         select new DepartmentDetailDto
                         {
                             Id = d.Id,
                             DepartmentName = d.DepartmentName,
                         };
            List<DepartmentDetailDto> resultList = result.ToList();
            dataGrid.DataSource = resultList;
            return resultList;
        }
        public void DepartmentDelete(int id, DataGridView dataGrid)
        {
            DialogResult result = MessageBox.Show("Departmanı Silmek İstediğinize Emin Misiniz?", "Uyarı ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        if (jsonId == id)
                        {
                            data["IsDeleted"] = true;
                            break;
                        }
                    }
                    File.WriteAllText(fileName, dataArray.ToString());
                    MessageBox.Show("Department Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DepartmentList(dataGrid);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata Oluştu " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public int FindId(DataGridView dataGridView)
        {
            string id = dataGridView.SelectedCells[1].Value.ToString();
            return Convert.ToInt16(id);
        }
    }


}
