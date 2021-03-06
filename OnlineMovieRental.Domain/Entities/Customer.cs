﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMovieRental.Domain.Entities
{
    public class Customer
    {
        public Customer()
        {
            Rentals = new HashSet<Rental>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IdentityCard { get; set; }
        public Guid UniqueKey { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public DateTime RegistrationDate { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
