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

        public async Task<DatabaseResult<Customer>> getAllCustomers() {
            return (await new Query().Select<Customer>("EXEC CustomerCrud @operation = 1"));
        }
        



        }
}

