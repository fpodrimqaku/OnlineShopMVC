using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Database;
using WebApplication1.Custom.Models.Shop;

namespace WebApplication1.Custom.Repositories
{
    public class CustomerRepository
    {
        public async Task<DatabaseExecuteResult> InsertCustomer(Customer customer)
        {
            return (await new Query().Execute("EXEC CustomerCrud @operation = 0,@name", new { customer.Name }));
        }


        public async Task<DatabaseResult<Customer>> getAllCustomers()
        {
            return (await new Query().Select<Customer>("EXEC CustomerCrud @operation = 1"));
        }


        public async Task<DatabaseExecuteResult> UpdateCustomer(Customer customer)
        {
            return (await new Query().Execute("EXEC CustomerCrud @operation = 2,@id,@Name", new
            {
                customer.Id,
                customer.Name
                
            }));
        }

        public async Task<DatabaseExecuteResult> DeleteCustomer(int id)
        {
            return (await new Query().Execute("EXEC CustomerCrud @operation = 3,@id", new { id }));
        }









    }
}

