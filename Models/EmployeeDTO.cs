﻿namespace HeroMed_API.Models
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Guid SectionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public int SeniorityYears { get; set; }
    }
}
