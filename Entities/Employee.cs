﻿using HeroMed_API.Entities.RelationsEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroMed_API.Entities
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First name is a required field!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is a required field!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Birthdate is a required field!")]
        [Column(TypeName =("datetime"))]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Employment date is a required field!")]
        [Column(TypeName = ("datetime"))]
        public DateTime EmploymentDate { get; set; }

        [Required(ErrorMessage = "Place of birth is a required field!")]
        public string PlaceOfBirth { get; set; }

        [Required(ErrorMessage = "Nationality is a required field!")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Address is a required field!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone number is a required field!"), Phone(ErrorMessage = "Phone number format invalid!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is a required field!"), EmailAddress(ErrorMessage = "Wrong email format!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Gender is a required field!")]
        public char Gender { get; set; }
        public Decimal? Salary { get; set; }
        
        public string? SalaryCurrency { get; set; }

        public Job Job { get; set; }

        public Guid JobId { get; set; } 
        
        public Section Section { get; set; }

        public Guid SectionId { get; set; }

        [Required(ErrorMessage = "Years of seniority is a required field!")]
        public int SeniorityYears { get; set; }


        public User User { get; set; }
        public ICollection<PatientEmployee> EmployeePatients { get; set; }

    }
}
