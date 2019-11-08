using System;

namespace SharedLibrary.Models.Entities
{
    public class Leave
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public short Kind { get; set; }
        public DateTime LeaveStart { get; set; }
        public DateTime LeaveEnd { get; set; }
        public int LeaveTime { get; set; }
        public string Reason { get; set; }
    }
}