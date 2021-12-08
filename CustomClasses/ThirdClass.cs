using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.CustomClasses
{
    public class ThirdClass :UserError
    {
        public override string UEMessage()
        {
            return "This is an error from the custom third class!";
        }


    }
}
