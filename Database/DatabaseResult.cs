using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Database
{
    public class DatabaseResult<T>
    {
        public bool HasError = false;
        public IEnumerable<T> Result = Enumerable.Empty<T>();
        public string ErrorMessage = string.Empty;
        public int Count => this.Result == null ? 0 : this.Result.Count();

        internal object AsEnumerable()
        {
            throw new NotImplementedException();
        }
    }
}