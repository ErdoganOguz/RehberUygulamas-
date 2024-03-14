using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehberUygulaması
{
    public partial class DepartmentAddFRM : Form
    {
        public DepartmentAddFRM()
        {
            InitializeComponent();
        }
        EfDepartmentDal efDepartmentDal = new EfDepartmentDal();
        private void DepartmentAddFRM_Load(object sender, EventArgs e)
        {
            //  DepaermentListDgw.DataSource = efDepartmentDal.JsonList();
            efDepartmentDal.DepartmentList(DepaermentListDgw);
            DepaermentListDgw.Columns["Id"].Visible = false;

          
        }

        private void DepartmentAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                efDepartmentDal.departmentAdd(DepartmentAddTxt, DepaermentListDgw);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            HomePage FRM = new HomePage();
            FRM.ShowDialog();
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            efDepartmentDal.DepartmentDelete(efDepartmentDal.FindId(DepaermentListDgw), DepaermentListDgw);
        }
    }
}
