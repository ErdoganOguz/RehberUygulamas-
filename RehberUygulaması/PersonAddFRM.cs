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
        EfJobTitleDal efJobTitleDal = new EfJobTitleDal();
        EfDepartmentDal efDepartmentDal = new EfDepartmentDal();
        Person person = new Person();
        private void BackBtn_Click(object sender, EventArgs e)
        {
            HomePage FRM = new HomePage();
            this.Close();
            FRM.Show();
        }

        public void AddBtn_Click(object sender, EventArgs e)
        { 
            efPersonDal.personAdd(FirstNameTxt, LastNameTxt, efDepartmentDal.departmentFilter(DepartmentCombo.Text), efJobTitleDal.JobTitleFilter(JobTitleCombo.Text), PhoneNumberTxt, EMailTxt, DepartmentCombo, JobTitleCombo);
           
        }

        public void PersonAddFRM_Load(object sender, EventArgs e)
        {

            efJobTitleDal.JobTitleComboList(JobTitleCombo);
            efDepartmentDal.DepartmentComboList(DepartmentCombo);

        }
    }
}
