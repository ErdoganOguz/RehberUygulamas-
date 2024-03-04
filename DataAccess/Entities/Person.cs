using System.Text.Json;

namespace DataAccess.Entities
{
    public class Person: BaseEntity

    {
        //public enum DepartmentType: int
        //{
        //    Programmer = 1,
        //    HelpDesk = 2
        //};
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public int JobTitleId { get; set; }
        public string Number { get; set; }
        public string EmailAdress { get; set; }
  
    }
}