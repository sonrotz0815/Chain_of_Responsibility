using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Fragen
{
    internal class MathFrage : Frage
    {
        public MathFrage(string text)
        {
            _text = text;
        }

    }
}
