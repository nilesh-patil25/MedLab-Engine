using HIS.APP.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HIS.APP.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<PatientDemographics> Patientdemographics { get; set; }
        public DbSet<ServiceRequests> ServiceRequests { get; set; }
        public DbSet<Observations> ObservationLabResults { get; set; }
        public DbSet<AuditTable> Audittables { get; set; }
        public DbSet<AuditBlob> Auditblobs { get; set; }
    }
}
