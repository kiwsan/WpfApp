using System.Collections.Generic;
using WpfApp1.Domain.Models;
using WpfApp1.Services.Interfaces;

namespace WpfApp1.Services.Implements
{
    public class PersonDumpService : IPersonService
    {
        public IEnumerable<Person> GetAll()
        {
            var persons = new List<Person>();

            persons.Add(new Person
            {
                Name = "Name 1",
                Description = "Description 1"
            });

            persons.Add(new Person
            {
                Name = "Name 2",
                Description = "Description 2"
            });

            persons.Add(new Person
            {
                Name = "Name 3",
                Description = "Description 3"
            });

            persons.Add(new Person
            {
                Name = "Name 4",
                Description = "Description 4"
            });

            persons.Add(new Person
            {
                Name = "Name 5",
                Description = "Description 5"
            });

            persons.Add(new Person
            {
                Name = "Name 6",
                Description = "Description 6"
            });

            return persons;
        }
    }
}
