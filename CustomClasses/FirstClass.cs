using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.CustomClasses
{
    public class FirstClass :UserError
    {

        public override string UEMessage()
        {
            return "This is an error in the custom first class!";
        }



    }
}
