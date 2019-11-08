using System;
using BusinessLogicLayer.Leave;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models.ViewModels;

namespace WebMvc.Controllers
{
    public class LeaveController : Controller
    {
        private readonly ILeaveService _leaveService;

        public LeaveController(ILeaveService leaveService)
        {
            _leaveService = leaveService;
        }
        
        public IActionResult Add()
        {
            var viewModel = new LeaveAddViewModel
                            {
                               LeaveStart = DateTime.Today,
                               LeaveEnd = DateTime.Today
                            };
            
            return View(viewModel);
        }
      
        [HttpPost, Route("api/[controller]/[action]")]
        [Produces("application/json")]
        public IActionResult SearchEmployee([FromBody]string keyword)
        {
            var result = _leaveService.SearchEmployee(keyword);
            return Ok(result);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostAdd(LeaveAddViewModel employeeAddViewModel)
        {
            _leaveService.Add(employeeAddViewModel);
            return Ok();
        }
    }
}