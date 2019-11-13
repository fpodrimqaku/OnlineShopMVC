using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Custom.Repositories
{
    public class BaseCrudRepository
    {
        protected BaseCrudRepository(
            string createProc,
            string readProc,
            string updateProc,
            string deleteProc
            ) { }
        
    }
}