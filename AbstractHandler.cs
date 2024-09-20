using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    abstract class AbstractHandler : IHandler
    {
        private IHandler _next;

        public IHandler SetNext(IHandler next)
        {
            _next = next;
            return _next;
        }


        public virtual object Handle(object request)
        {
            if (_next != null) {
                return _next.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
