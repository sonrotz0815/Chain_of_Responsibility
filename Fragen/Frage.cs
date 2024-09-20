using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Fragen
{
    internal abstract class Frage
    {
        protected string _text;

        public string GetText()
        {
            return _text;
        }
    }
}
