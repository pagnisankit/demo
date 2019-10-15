using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoDLL
{
    public class Class1
    {
        public string demoMethod()
        {
            return "This is a msg from dll";
        }

        //internal string myProp = "Is it Visible?";
        internal protected string checkInternal()
        {
            return "This is internal";
        }
    }
}
