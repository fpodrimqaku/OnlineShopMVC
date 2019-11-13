using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class Environment
    {
        // private string ConnectionString = "data source=10.41.16.104;initial catalog=BDMS;user id=BDMS_USER;password=BDMS@USER;MultipleActiveResultSets=True;";
        // private string ConnectionString = "data source=192.168.5.82;initial catalog=BDMS;user id=BDMS_USER;password=BDMS@USER;MultipleActiveResultSets=True;";
        // private string ConnectionString = "data source=192.168.5.9;initial catalog=BDMS;user id=BDMS_USER;password=BDMS@USER;MultipleActiveResultSets=True;";

        //public static string Development = "data source=192.168.5.9;initial catalog=BDMS;user id=BDMS_USER;password=BDMS@USER;MultipleActiveResultSets=True;";
        //public static string Development = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=fatoni;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public static string Development = "Data Source=192.168.5.9;User ID=TestingUser;Password=TestingUser1313#;Connect Timeout=30;Encrypt=False;MultiSubnetFailover=False";
        public static string Production = "data source=10.41.16.104;initial catalog=BDMS;user id=BDMS_USER;password=BDMS@USER;MultipleActiveResultSets=True;";
    }
}
