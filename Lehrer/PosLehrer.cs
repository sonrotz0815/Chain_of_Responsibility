using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chain_of_Responsibility.Fragen;

namespace Chain_of_Responsibility.Lehrer
{
    internal class PosLehrer : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request is PosFrage)
            {
                return "POS Antwort";
            }

            return base.Handle(request);
        }


    }
}
