using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Data.Entities
{
    public class LeaveHistory
    {
        [Key]
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        
        [ForeignKey("ApprovedBy")]
        public string ApprovedById { get; set; }    

        [ForeignKey("RequestingEmployee")]
        public string RequestingEmployeeId { get; set; }

        [ForeignKey("LeaveType")]
        public int LeaveTypeId { get; set; }

        public Employee RequestingEmployee { get; set; }
        public Employee ApprovedBy { get; set; }    
        public LeaveType LeaveType { get; set; }
    }
}
