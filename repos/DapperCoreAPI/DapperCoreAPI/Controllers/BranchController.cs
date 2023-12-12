using DapperCoreAPI.Models;
using DapperCoreAPI.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchRepository _branchRepository;
        public BranchController(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }
        // GET: BranchController/GetAll
        [HttpGet]
        public IEnumerable<List<Branch>> GetAllBranches()
        {
            return (IEnumerable<List<Branch>>)_branchRepository.GetAllAsync();
        }

        // GET: BranchController/Details/5

        // GET: BranchController/Create

        // POST: BranchController/Create

        // GET: BranchController/Edit/5

        // POST: BranchController/Delete/5

    }
}
