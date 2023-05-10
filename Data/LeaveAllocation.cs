using System.ComponentModel.DataAnnotations.Schema;

namespace CursoPemex.Data
{
    public class LeaveAllocation : BaseEntity
    {
        

        public int NumberOfDays { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType leaveType { get; set; }
        public  int LeaveTypeId { get; set; }
        public string employeeId { get; set; }

        

    }
}
