using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Persons
    {
        public int Id { get; set; }
        public int FirstNameId { get; set; }
        public int LastNameId { get; set; }
        public int DepartmentId { get; set; }
        public int JobTitleId { get; set; }
        public int OperatorId { get; set; }
        public int Number { get; set; }
        public int EmailId { get; set; }
        public string Email { get; set; }
        public int view {  get; set; }
    }
}
