﻿namespace RhodesShoppe.Api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<GuitarRepair> Repairs { get; set; }
    }
}
