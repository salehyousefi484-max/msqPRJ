using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace msqPRJ.forms
{
    public static class AppPaths
    {
        public static readonly string ConnString =
       @"Data Source=.;Initial Catalog=msqPRJ;Integrated Security=True";

        public static string DbName
        {
            get { return new SqlConnectionStringBuilder(ConnString).InitialCatalog; }
        }

        public static string MasterConnString
        {
            get
            {
                var b = new SqlConnectionStringBuilder(ConnString);
                b.InitialCatalog = "master";
                return b.ConnectionString;
            }
        }
    }
}
