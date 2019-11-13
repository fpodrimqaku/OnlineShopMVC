using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Custom.Models
{
    public class Customer
    {
        public Customer()
        {

        }
       public Customer(int id1,string name1) {
            id = id1;
            name = name1;
        }
       public int id { get; set; }
       public string name { get; set; }
        public int age { get; set; }
        public string status { get; set; }

    }
}