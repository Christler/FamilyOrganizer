using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public bool IsParent { get; set; }
        public int FamilyID { get; set; }
    }
}
