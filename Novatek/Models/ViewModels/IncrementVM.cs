namespace Novatek.Models.ViewModels
{
    public class IncrementVM
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int DesignationId { get; set; }
        public decimal IncrementPercentage { get; set; }
        public DateTime IncrementDate { get; set; }
    }
}
