using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public int JobTitleId { get; set; }
        public string Number { get; set; }
        public string EmailAdress { get; set; }
  
    }
}
