using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WifiMap.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }


    public enum Role
    {
        Guest, Stranger, Insider, Admin
    }
}
