﻿using Microsoft.AspNetCore.Mvc;

namespace HeroMed_API.Repositories.Employee
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Entities.Employee>> GetAllEmployeesAsync();
        Task<Entities.Employee> GetEmployeeByIdAsync(Guid id);
        Task<IEnumerable<Entities.Employee>> GetEmployeesBySectionIdAsync(Guid sectionId);
        Task<Entities.Employee> GetEmployeeByEmailAsync(string email);
        Task<IEnumerable<Entities.Employee>> GetEmployeesWithoutAccount();
        Task<Entities.Employee> AddEmployeeAsync(Entities.Employee employee);
        void DeleteEmployee(Entities.Employee employee);
        void UpdateEmployee(Entities.Employee employee);
        bool EmployeeExists(Guid employeeID);
        
    }
}
