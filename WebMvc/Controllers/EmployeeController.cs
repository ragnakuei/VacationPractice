using System;
using BusinessLogicLayer.Employee;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models.ViewModels;

namespace WebMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBL _employeeBl;

        public EmployeeController(IEmployeeBL employeeBl)
        {
            _employeeBl = employeeBl;
        }
        
        public IActionResult Add()
        {
            var viewModel = new EmployeeAddViewModel
                            {
                                OnBoardDate = DateTime.Now,
                                BirthDay = DateTime.Now,
                            };
            return View(viewModel);
        }
      
        [HttpPost]
        public IActionResult PostAdd(EmployeeAddViewModel employeeAddViewModel)
        {
            _employeeBl.Add(employeeAddViewModel);
            return Ok();
        }
    }
}