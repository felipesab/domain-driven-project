using System;
using System.Collections.Generic;

namespace DomainDrivenProject.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public bool SpecialClient(Client client)
        {
            return (client.Active && DateTime.Now.Year - client.RegistrationDate.Year >= 5);
        }
    }
}
