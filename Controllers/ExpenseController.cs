using Logics.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BudgetTrackerAPI.Controllers
{
    [ApiController]
    [Route("BudgetTrackerAPI/[controller]/[action]")]
    public class ExpenseController : Controller
    {
        private IExpenseRepository _repo;
        public ExpenseController(IExpenseRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAllExpense()
        {
            var obj = _repo.GetAllExpenses();
            return Ok(obj);
        }

        [HttpPost]
        public IActionResult DeleteExpense([FromBody] int id)
        {
            var obj = _repo.DeleteExpense(id);
            return Ok(obj);
        }
    }
}
