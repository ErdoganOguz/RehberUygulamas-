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



        public void HomePage_Load(object sender, EventArgs e)
        {

            efPersonDal.JsonList();
            PersonListDgw.DataSource = efPersonDal.JsonList();

        }

        private void PersonAddBtn_Click(object sender, EventArgs e)
        {
            PersonAddFRM FRM = new PersonAddFRM();
            FRM.Show();
            this.Hide();

        }

       
    }
}
