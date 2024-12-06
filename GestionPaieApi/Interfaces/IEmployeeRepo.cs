﻿using GestionPaieApi.DTOs;
using GestionPaieApi.Models;

namespace GestionPaieApi.Interfaces
{
    public interface IEmployeeRepo 
    {
        Task<ResponsabiliteAdministrative> GetEmployeeResponsabilitiesByID(string id);

        Task<List<Employe>> SearchUsersAsync(string searchTerm);
    }
}