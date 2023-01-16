using HIS.APP.Controllers;
using HIS.APP.Data;
using Quartz;

namespace HIS.APP.Models
{
    public class PatientSyncQuartzJob : IJob
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;
        public PatientSyncQuartzJob(ApplicationDbContext dbContext, IConfiguration iConfig)
        {
            _dbContext = dbContext;
            _configuration = iConfig;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Fetching patient data at {0}", DateTime.Now);
            var patientController = new PatientController(_dbContext, _configuration);

            await patientController.GetPatientDemographics();

        }
    }
}
