using DataAccess.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataAccess.Concrete
{
    public class EfPersonDal : Person
    {

        
        public List<Person> JsonList()
        {
            List<Person> JsonModelList = null;

            try
            {
                string fileName = "C:\\Users\\oğuz\\source\\repos\\RehberUygulaması\\DataAccess\\Json\\person.json";
                dynamic JsonText = File.ReadAllText(fileName);
                JsonModelList = JsonConvert.DeserializeObject<List<Person>>(JsonText);
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            return JsonModelList;
        }

        public Person Add()
        {
           
            return Add();
        }

    }
}
