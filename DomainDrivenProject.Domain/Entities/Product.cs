﻿namespace DomainDrivenProject.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price{ get; set; }
        public bool Available { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

    }
}
