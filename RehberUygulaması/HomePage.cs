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
        PersonAddFRM personAddFRM = new PersonAddFRM();



        public void HomePage_Load(object sender, EventArgs e)
        {


            efPersonDal.PersonList(PersonListDgw);
            this.PersonListDgw.Columns["Id"].Visible = false;



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

        private void PersonListDgw_SelectionChanged(object sender, EventArgs e)
        {
           
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string id = PersonListDgw.SelectedCells[0].Value.ToString();
            int Id = Convert.ToInt16(id);
            efPersonDal.PersonDelete(Id);
        }
    }
}
