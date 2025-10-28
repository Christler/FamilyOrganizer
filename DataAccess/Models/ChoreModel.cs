using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ChoreModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int FamilyID { get; set; }
        public int? AssignedToUserID { get; set; }
        public string AssignedTo { get; set; }
    }
}
