using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    public interface Observer
    {
        void Updated(Subject subject);
    }
}
