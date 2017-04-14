using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class MyError:Exception
    {
        public string MyErrorMsg { get; set; }

        public MyError(string testErr)
        {
            MyErrorMsg = testErr;
        }
       
    }
}
