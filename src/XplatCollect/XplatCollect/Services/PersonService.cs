using System;
using System.Linq;
using XplatCollect.Models;

namespace XplatCollect.Services
{
    public interface IPersonService
    {
        Person GetPerson();
        void Add(Person person);
        void Update(Person person);
        bool HasPerson();
    }

    public class PersonService : IPersonService
    {
        private readonly IDataBaseService<Person> dataBaseService;

        public PersonService(IDataBaseService<Person> dataBaseService)
        {
            this.dataBaseService = dataBaseService;
        }

        public void Add(Person person)
        {
            dataBaseService.Create(person);
        }

        public Person GetPerson()
        {
            return dataBaseService.GetAll()
                .FirstOrDefault();
        }

        public bool HasPerson()
            => GetPerson() != null;

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
