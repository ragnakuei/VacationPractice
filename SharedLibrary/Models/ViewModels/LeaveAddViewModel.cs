using System;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models.ViewModels
{
    public class LeaveAddViewModel
    {
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        public short Kind { get; set; }
        
        [Required]
        public DateTime LeaveStart { get; set; }
        
        [Required]
        public DateTime LeaveEnd { get; set; }
        
        [Required]
        public int LeaveTime { get; set; }
        
        [Required]
        public string Reason { get; set; }
    }
}