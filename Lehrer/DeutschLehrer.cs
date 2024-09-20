using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chain_of_Responsibility.Fragen;

namespace Chain_of_Responsibility.Lehrer
{
    internal class DeutschLehrer : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request is DeFrage)
            {
                return "Deutsch Antwort";
            }

            return base.Handle(request);
        }

    }
}
