namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }
        
        List<Employee> _employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
            Id = "24",
            Name = "Jesper førehyrden",
            Email = "fsf@bibib.dk",
            Department = new Department() {
                Id = 3,
                Name = "IT"
            }
            },
            new Employee() {
                Id = "25",
                Name = "Hjalte bording",
                Email = "bord@mimi.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "IT"
                }
            },
            new Employee() {
                Id = "26",
                Name = "Lakke dimning",
                Email = "Isiss@lalaba.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "IT"
                }
            },
            new Employee() {
                Id = "27",
                Name = "Lukas Effington",
                Email = "Isiss@lalaba.dk",
                Department = new Department() {
                    Id = 4,
                    Name = "Kantine"
                }
            },
            new Employee() {
                Id = "28",
                Name = "Umut Naz",
                Email = "Ibib@papa.dk",
                Department = new Department() {
                    Id = 4,
                    Name = "Kantine"
                }
            }
        };


        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            return _employees;
        }

        [HttpGet("GetEmployees/{department}")]
        public IEnumerable<Employee> GetByDepartment(string department)
        {
            var toLower = department.ToLower();
            return _employees.Where(e => e.Department.Name.ToLower() == toLower);
        }
        
    }


}