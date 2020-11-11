using System;

namespace LeaveManagement.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string TaxId { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }  
    }
}
