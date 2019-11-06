using System;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models.ViewModels
{
    public class EmployeeAddViewModel
    {
        [Required]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "到職日")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OnBoardDate { get; set; }

        [Required]
        [Display(Name = "生日")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Required]
        [Display(Name = "電話")]
        public string Phone { get; set; }
    }
}