using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Visitor
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    public abstract  class Element 
    {
        public abstract void Accept(IVisitor visitor);
    }


}
