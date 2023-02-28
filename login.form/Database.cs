using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.form
{
    public class Database
    {
        public static string ConnectionString
        {
            get { return ConfigurationManager.AppSettings["LoginUserConnectionString"].ToString(); }
        }
    }
}
