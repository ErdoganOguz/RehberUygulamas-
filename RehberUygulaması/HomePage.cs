using DataAccess.Entities;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using System.Net;

namespace RehberUygulaması
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            JsonListe();

        }
        //public List<Person> People()
        //{

        //    string fileName = "person.json";
        //    string jsonString = File.ReadAllText(fileName);
        //    Person person = JsonSerializer.Deserialize<Person>(jsonString);
        //    PersonListDgw.DataSource = jsonString;

        //    List<Person> people = null;
        //    return people;
        //}

        public List<Person> JsonListe()
        {
            List<Person> JsonModelList = null;

            try
            {
                string fileName = "C:\\Users\\oğuz\\source\\repos\\RehberUygulaması\\DataAccess\\Json\\person.json";
                String JsonText = File.ReadAllText(fileName);
                JsonModelList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(JsonText);
                PersonListDgw.DataSource = JsonModelList;

            }
            catch (Exception ex)
            {
                JsonModelList = null;
            }

            return JsonModelList;
        }


    }
}
