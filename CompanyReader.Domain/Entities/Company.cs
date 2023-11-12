using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyReader.Domain.Entities
{
    public class Company
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public int RegistrationId { get; set; }
        public int ExternalReference { get; set; }
        public int Amount { get; set; }
    }
}
