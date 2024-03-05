using DataAccess.Concrete;
using DataAccess.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehberUygulaması
{
    public partial class PersonAddFRM : Form
    {
        public PersonAddFRM()
        {
            InitializeComponent();
        }

        EfPersonDal efPersonDal = new EfPersonDal();
        Person person = new Person();
        private void BackBtn_Click(object sender, EventArgs e)
        {
            HomePage FRM = new HomePage();
            this.Close();
            FRM.Show();
        }

        public void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                efPersonDal.personAdd(FirstNameTxt.Text, LastNameTxt.Text, Convert.ToInt32(DepartmentTxt.Text), Convert.ToInt16(JobTitleTxt.Text), PhoneNumberTxt.Text, EMailTxt.Text);
                MessageBox.Show("Kişi Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void PersonAddFRM_Load(object sender, EventArgs e)
        {
            JobTitleFilter();
          
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
                    JobTitleCombo.Items.Add(JobTitleName);
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
