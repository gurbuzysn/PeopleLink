using ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; } 
        public string LastName { get; set; } = null!;
        public string? MiddleLastName { get; set; } 
        public DateTime BirthDate { get; set; } 
        public string BirthPlace { get; set; } = null!;
        public string? PictureUri { get; set; }
        public string IdentityNumber { get; set; } = null!;
        public DateTime HireDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public bool IsActive { get; set; }
        public Occupation Occupation { get; set; } = null!;
        public Department Department { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal Salary { get; set; }
    }
}
