using Database;
using System.Threading.Tasks;
using WebApplication1.Custom.Models;
using Dapper;


namespace WebApplication1.Custom.Repositories
{
    public class PersonRepository
    {
        public async Task<DatabaseResult<Person>> getPeople() =>
            (await (new Query().Select<Person>("Select * from Person")));

        
        public async Task<DatabaseExecuteResult> InsertPerson(Customer person) =>
            (await new Query().Execute("Insert into Customer(Id,Name) values(@Id,@Name)", new {
                Id=4,
              Name=""
            }));



        public async Task<DatabaseExecuteResult> DeletePerson(int id) =>
         (await new Query().Execute("Delete from person where id=@id", new
         {
            id
         }));
    }
}