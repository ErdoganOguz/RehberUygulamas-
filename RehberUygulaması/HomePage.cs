using DataAccess.Entities;
using DataAccess.Concrete;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using System.Net;
using System.Data;
using System.Windows.Forms;

namespace RehberUygulaması
{
    public partial class HomePage : Form

    {
        public HomePage()
        {
            InitializeComponent();
        }
        EfPersonDal efPersonDal = new EfPersonDal();
        EfJobTitleDal efJobTitle = new EfJobTitleDal();
        EfDepartmentDal efDepartmentDal = new EfDepartmentDal();
        PersonAddFRM personAddFRM = new PersonAddFRM();



        public void HomePage_Load(object sender, EventArgs e)
        {


            efPersonDal.PersonList(PersonListDgw);
            this.PersonListDgw.Columns["Id"].Visible = false;
            efJobTitle.JobTitleComboList(TitleUpdateCombo);
            efDepartmentDal.DepartmentComboList(DepartmentUpdateCombo);



        }

        private void PersonAddBtn_Click(object sender, EventArgs e)
        {
            PersonAddFRM FRM = new PersonAddFRM();
            FRM.Show();
            this.Hide();

        }

        private void DepartmentAddBtn_Click(object sender, EventArgs e)
        {
            DepartmentAddFRM FRM = new DepartmentAddFRM();
            FRM.ShowDialog();
            this.Hide();
        }

        private void JobTiitleAddBtn_Click(object sender, EventArgs e)
        {
            JobTitleAddFRM FRM = new JobTitleAddFRM();
            FRM.ShowDialog();
            this.Hide();
        }
        public void DgwSettings()
        {
            // PersonListDgw.ColumnCount = 6;

        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //  int Id = FindId();
            efPersonDal.PersonDelete(efPersonDal.FindId(PersonListDgw), PersonListDgw);
        
        }



        private void PersonListDgw_DoubleClick(object sender, EventArgs e)
        {
            efPersonDal.GetPerson(FirstNameUpdateTxt, LastNameUpdateTxt, DepartmentUpdateCombo, TitleUpdateCombo, NumberUpdatetxt, MailUpdadetxt, PersonListDgw);
            int id = efPersonDal.FindId(PersonListDgw);
        }

        private void PersonUpdateBtn_Click(object sender, EventArgs e)
        {
            efPersonDal.PersonDetailUpdade(efPersonDal.FindId(PersonListDgw), FirstNameUpdateTxt, LastNameUpdateTxt, efDepartmentDal.departmentFilter(DepartmentUpdateCombo.Text), efJobTitle.JobTitleFilter(TitleUpdateCombo.Text),NumberUpdatetxt,MailUpdadetxt, DepartmentUpdateCombo, TitleUpdateCombo, PersonListDgw);
              
        }
    }
}
