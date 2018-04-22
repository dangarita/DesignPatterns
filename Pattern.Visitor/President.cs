using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Visitor
{
    public class President : Employee
    {
        // Constructor

        public President()
          : base("Dick", 45000.0, 21)
        {
        }
    }
}
