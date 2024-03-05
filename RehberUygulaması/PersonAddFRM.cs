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
            Add();
        }

        public void Add()
        {
            try
            {
                var person = new Person()
                {
                    FirstName = FirstNameTxt.Text,
                    LastName = LastNameTxt.Text,
                    DepartmentId = Convert.ToInt16(DepartmentTxt.Text),
                    JobTitleId = Convert.ToInt16(JobTitleTxt.Text),
                    Number = PhoneNumberTxt.Text,
                    EmailAdress = EMailTxt.Text,
                    CreateDate = DateTime.Now,
                    IsDeleted = false
                };
                
                var personJson = JsonConvert.SerializeObject(person, Formatting.Indented);
                
                string fileName = "C:\\Users\\oğuz\\source\\repos\\RehberUygulaması\\DataAccess\\Json\\person.json";
                File.WriteAllText(fileName, personJson);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir Hata Oluştu" , MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}
