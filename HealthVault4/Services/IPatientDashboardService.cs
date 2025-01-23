using HealthVault4.Models.PatientDashboard;

namespace HealthVault4.PatientDashboard
{
    public interface IPatientDashboardService
    {
        Task<List<WeightType>> GetWeightList();
        Task<List<HeartRateType>> GetHeartRateList();
        Task<List<BPSystolicDiastolicType>> GetBPSystolicDiastolicList();
        Task<List<GlucoseType>> GetGlucoseList();
        Task<List<TotalCholesterolType>> GetTotalCholesterolList();
        Task<List<CholesterolHDLLDLType>> GetCholesterolHDLLDLList();
    }
}
