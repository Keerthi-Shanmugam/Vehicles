﻿// Services/IPerformanceService.cs
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TFMS.Models;

namespace TFMS.Services
{
    public interface IPerformanceService
    {
        Task<IEnumerable<PerformanceReport>> GetAllPerformanceReportsAsync();
        Task<PerformanceReport?> GetPerformanceReportByIdAsync(int id);
        Task AddPerformanceReportAsync(PerformanceReport report);
        Task DeletePerformanceReportAsync(int id);
        Task<bool> PerformanceReportExistsAsync(int id);

        // MODIFIED: Added optional vehicleId parameter
        Task<PerformanceReport> GenerateFuelEfficiencyReportAsync(DateTime startDate, DateTime endDate, int? vehicleId = null);
        Task<PerformanceReport> GenerateVehicleUtilizationReportAsync(DateTime startDate, DateTime endDate, int? vehicleId = null);
        Task<PerformanceReport> GenerateMaintenanceCostReportAsync(DateTime startDate, DateTime endDate, int? vehicleId = null);
    }
}