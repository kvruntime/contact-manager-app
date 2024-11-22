using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppDomain.Entities
{
    public class ContactEntity : BaseEntity
    {
        public string Firstname { get; set; } = string.Empty;
        public string? Lastname { get; set; }

        public string? Email { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string? Address { get; set; }
    }
}
