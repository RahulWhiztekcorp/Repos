using FSCoreWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public FsdbContext _db;
        public EmployeeController()
        {
            _db = new FsdbContext();
        }
        [HttpGet("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            return _db.Employees.ToList();
        }
        [HttpGet("GetEmployeeById/{EmployeeId}")]
        public Employee GetEmployeeById(int EmployeeId)
        {
            var data = _db.Employees.Where(d => d.EmployeeId == EmployeeId).FirstOrDefault();
            return data;
        }
        [HttpPost("AddEmployee")]
        public string AddEmployee(Employee Employee)
        {
            if (Employee != null)
            {
                _db.Employees.Add(Employee);
                _db.SaveChanges();
                return "Added";
            }
            else
            {
                return "Not Added";
            }
        }
        [HttpPut("UpdateEmployee")]
        public string UpdateEmployee(Employee Employee)
        {
            if (Employee != null)
            {
                _db.Employees.Update(Employee);
                _db.SaveChanges();
                return "Updated";
            }
            else
            {
                return "Not Updated";
            }
        }
        [HttpDelete("DeleteEmployee/{EmployeeId}")]
        public string DeleteEmployee(int EmployeeId)
        {
            if (EmployeeId != null)
            {
                Employee d = _db.Employees.Where(d => d.EmployeeId == EmployeeId).FirstOrDefault();
                _db.Employees.Remove(d);
                _db.SaveChanges();
                return "Deleted";
            }
            else
            {
                return "Not Deleted";
            }
        }
    }
}
