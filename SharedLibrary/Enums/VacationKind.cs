using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Enums
{
    public enum VacationKind : short
    {
        [Display(Name = "事假")]
        事假 = 1,
        [Display(Name = "病假")]
        病假 = 2,
        [Display(Name = "喪假")]
        喪假 = 3,
        [Display(Name = "婚假")]
        婚假 = 4,
        [Display(Name = "特休")]
        特休 = 5,
        [Display(Name = "產檢假")]
        產檢假 = 6,
        [Display(Name = "陪產假")]
        陪產假 = 7,
        [Display(Name = "產假")]
        產假 = 8,
        [Display(Name = "家庭照顧假")]
        家庭照顧假 = 9,
        [Display(Name = "生理假")]
        生理假 = 10,
        [Display(Name = "公假")]
        公假 = 11,
    }
}