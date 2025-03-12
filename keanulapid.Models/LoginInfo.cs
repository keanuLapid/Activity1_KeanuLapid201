using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keanulapid.Models
{
    internal class LoginInfo

    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string ? LoggingType { get; set; }
        public DateTime ? CreatedAt {  get; set; }
        public User ? User { get; set; }


    }
}
