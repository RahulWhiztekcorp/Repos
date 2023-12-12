using FSCoreWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public FsdbContext _db;
        public DepartmentController()
        {
            _db = new FsdbContext();
        }
        [HttpGet("Departments")]
        public List<Department> GetDepartments()
        {
            return _db.Departments.ToList();
        }
        [HttpGet("GetDepartmentById/{DepartmentId}")]
        public Department GetDepartmentById(int DepartmentId)
        {
            var data = _db.Departments.Where(d => d.DepartmentId == DepartmentId).FirstOrDefault();
            return data;
        }
        [HttpPost("AddDepartment")]
        public string AddDepartment(Department department)
        {
            if (department != null)
            {
                _db.Departments.Add(department);
                _db.SaveChanges();
                return "Added";
            }
            else
            {
                return "Not Added";
            }
        }
        [HttpPut("UpdateDepartment")]
        public string UpdateDepartment(Department department)
        {
            if (department != null)
            {
                _db.Departments.Update(department);
                _db.SaveChanges();
                return "Updated";
            }
            else
            {
                return "Not Updated";
            }
        }
        [HttpDelete("DeleteDepartment/{DepartmentId}")]
        public string DeleteDepartment(int DepartmentId)
        {
            if (DepartmentId != null)
            {
                Department d = _db.Departments.Where(d=>d.DepartmentId== DepartmentId).FirstOrDefault();
                _db.Departments.Remove(d);
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
