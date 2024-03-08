﻿using DataAccess.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfJobTitleDal : JobTitle
    {
        string fileName = "C:\\RehberUygulaması\\JobTitle.json";



        public List<JobTitle> JsonList()
        {
            List<JobTitle> JsonModelList = null;

            try
            {
                dynamic JsonText = File.ReadAllText(fileName);
                JsonModelList = JsonConvert.DeserializeObject<List<JobTitle>>(JsonText);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            return JsonModelList;
        }
        public void jobTitleAdd(string jobTitleName)
        {
            try
            {
                var jobTitle = new JobTitle()
                {

                    Id = JsonList().Count() + 1,
                    JobTitleName = jobTitleName,
                    CreateDate = DateTime.Now,
                    IsDeleted = false
                };
                List<JobTitle> data = JsonList();
                var oldData = JsonConvert.SerializeObject(data, Formatting.Indented);
                var jobTitleJson = JsonConvert.SerializeObject(jobTitle, Formatting.Indented);
                oldData = RemoveSquareBrackets(oldData);
                File.WriteAllText(fileName, " ");
                File.WriteAllText(fileName, "[" + oldData + "," + jobTitleJson + "]");
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


        public string JobTitleFilter(string comboSelect)
        {
            try
            {
                string JobTitleId;
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
                    if (JobTitleName == comboSelect)
                    {



                        JobTitleId = data["Id"].ToString();

                        return JobTitleId;




                    }
                    //MessageBox.Show(Convert.ToString(JobTitleName));

                }
                return "Eşleşen iş pozisyonu bulunamadı ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }


        public void JobTitleComboList(System.Windows.Forms.ComboBox comboBox)
        {
            // ComboBox'ı temizle
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
                    string jobTitleName = data["JobTitleName"].ToString();
                    comboBox.Items.Add(jobTitleName);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Bir Hata Oluştu", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }

    }
}
