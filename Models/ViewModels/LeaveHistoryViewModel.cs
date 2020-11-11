using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagement.Models.ViewModels
{
    public class LeaveHistoryViewModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedById { get; set; }
        public string RequestingEmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public EmployeeViewModel RequestingEmployee { get; set; }
        public EmployeeViewModel ApprovedBy { get; set; }
        public LeaveTypeViewModel LeaveType { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; } 
    }
}
