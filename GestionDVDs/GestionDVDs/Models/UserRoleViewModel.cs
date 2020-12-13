using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDVDs.Models
{
    public class UserRoleViewModel
    {

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string RoleId = "U";
        public string IsSelected { get; set; }
    }
}
