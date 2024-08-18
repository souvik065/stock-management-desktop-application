using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalProject
{
    class SQLQueryClass
    {
        public static SqlConnection con = new SqlConnection(FinalProject.Properties.Settings.Default.DBcon);


    }
}
