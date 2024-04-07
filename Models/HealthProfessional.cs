namespace habitos_app.Web.Models
{
    public class HealthProfessional : User
    {
        public HealthProfessional(int professionalLicenseNumber)
        {
            ProfessionalLicenseNumber = professionalLicenseNumber;
        }

        public int ProfessionalLicenseNumber { get; set; }
        // Propiedades específicas de HealthProfessional
    }
}