using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagement.Data.Entities
{
    public class LeaveAllocation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }

        [ForeignKey("LeaveType")]
        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }    
        public Employee Employee { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; } 
    }
}
