using System;
using BusinessLogicLayer.Employee;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models.ViewModels;

namespace WebMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
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
        [ValidateAntiForgeryToken]
        public IActionResult PostAdd(EmployeeAddViewModel employeeAddViewModel)
        {
            _employeeService.Add(employeeAddViewModel);
            return Ok();
        }
    }
}