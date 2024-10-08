using RestWithASP_NET6Udemy.Model;

namespace RestWithASP_NET6Udemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person GetById(int id);
        Person Update(Person person);
        void Delete(int id);

        List<Person> GetAll();
    }
}
