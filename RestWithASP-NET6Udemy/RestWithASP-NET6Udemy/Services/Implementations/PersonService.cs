using RestWithASP_NET6Udemy.Model;

namespace RestWithASP_NET6Udemy.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(int id)
        {
            
        }

        public List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Address" + i,
                Gender = "Feminino"
            };
        }

        private int IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person GetById(int id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Brenda",
                LastName = "Costa",
                Address = "SJC",
                Gender = "Feminino"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
