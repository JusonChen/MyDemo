using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class QueryResultTest
    {
        public string UserName { get; set; }

        public string RoleName { get; set; }

        public string DepartmentName { get; set; }
    }
}
