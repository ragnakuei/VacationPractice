using System;

namespace SharedLibrary.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime OnBoardDate { get; set; }
        public int AnnualLeave { get; set; }
        public int RemainAnnual { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
    }
}