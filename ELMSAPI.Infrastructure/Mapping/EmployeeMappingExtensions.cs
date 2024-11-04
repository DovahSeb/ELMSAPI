﻿using ELMSAPI.Application.Employees.DTOs;
using ELMSAPI.Domain.Models;

namespace ELMSAPI.Infrastructure.Mapping;

public static class EmployeeMappingExtensions
{
    public static EmployeeResponseDto MapToEmployeeResponseDto(this Employee employee)
    {
        return new EmployeeResponseDto
        {
            Id = employee.Id,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Email = employee.User.Email!,
            Department = employee.Department.Name
        };
    }
}