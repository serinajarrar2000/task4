namespace WebApplication64.internalinterface
{
    public interface Interface2
    {
            List<company> Get();
            company GetId(int id);
            company Addemployee(company employee);
            company updateEmployee(company request);
            company Delete(int id);

        }
        public class companyRepo : Interface2
        {
            private List<company> companies = new List<company>()
            {
                 new company{id=1,  name="iconnect",location="Ramallah"},

                new company {id=2,  name="progineer",location="nablus"},

            };
            public List<company> Get()
            {
                return companies;
            }
            public company GetId(int Id)
            {
                return companies.FirstOrDefault(f => f.id == Id);
            }
            public company Addemployee(company company)
            {
                companies.Add(company);
                return company;
            }
            public company updateEmployee(company request)
            {
                var company = companies.Find(p => p.id == request.id);

                company.id = request.id;
                company.name = request.name;

                company.location = request.location;

                return company;
            }
            public company Delete(int id)
            {
                var company = companies.Find(x => x.id == id); 

                companies.Remove(company);
                return company;
            }

        }
    }
