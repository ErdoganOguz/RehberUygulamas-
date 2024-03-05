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
    public partial class JobTitleAddFRM : Form
    {
        public JobTitleAddFRM()
        {
            InitializeComponent();
        }
        EfJobTitleDal efJobTitleDal = new EfJobTitleDal();

        private void JobTitleAddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                efJobTitleDal.jobTitleAdd(JobTitleAddTxt.Text);
                MessageBox.Show("Ünvan Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                JobTitleListDgw.DataSource = efJobTitleDal.JsonList();
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

        private void JobTitleAddFRM_Load(object sender, EventArgs e)
        {
            JobTitleListDgw.DataSource = efJobTitleDal.JsonList();
        }
    }
}
