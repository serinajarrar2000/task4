namespace WebApplication64.internalinterface
{

        public interface interfacess
        {
            List<employee> Get();

            employee GetId(int id);
            employee Addemployee(employee employee);
            employee updateEmployee(employee request);
            employee Delete(int id);

        }
        public class employeeRepo :interfacess
        {

            private List<employee> employees = new List<employee>()
            {
                 new employee{id=1,  name="serina",age=22,countryid=101},

                new employee{id=2,  name="leena",age=23,countryid = 102},

            };

            public List<employee> Get()
            {
                return employees;
            }
            public employee GetId(int Id)
            {
                return employees.FirstOrDefault(f => f.id == Id);
            }

            public employee Addemployee(employee employee)
            {
                employees.Add(employee);
                return employee;

            }

            public employee Delete(int id)
            {
                var employee = employees.Find(x => x.id == id);
                employees.Remove(employee);
                return employee;
            }


            public employee updateEmployee(employee request)
            {
                var employee = employees.Find(p => p.id == request.id);

                employee.id = request.id;
                employee.name = request.name;
                employee.age = request.age;
                employee.countryid = request.countryid;
                return employee;

            }

        }
    }
    