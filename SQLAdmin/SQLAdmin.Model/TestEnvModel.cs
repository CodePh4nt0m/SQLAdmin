using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLAdmin.Model
{
    public class TestEnvModel
    {
        public string ServerID { get; set; }
        public string ServerName { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool bSelected { get; set; }
    }
}