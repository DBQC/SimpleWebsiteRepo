using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public static class Class1
    {        
        public static string something()
        {
            using (var usingdb = new AdventureWorks3017Entities1())
            {
                var query = from p in usingdb.People
                            select p;
                List<Person> products = query.ToList();
                StringBuilder sb = new StringBuilder();
                foreach (Person p in query)
                {
                    sb.Append(p.FirstName);
                    sb.AppendLine();
                }
                return sb.ToString();
            }
        }
    }
}
