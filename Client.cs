using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chain_of_Responsibility.Fragen;

namespace Chain_of_Responsibility
{
    internal class Client
    {
        private List<Frage> _inputs;
        
        public Client(List<Frage> inputs) { 
            _inputs = inputs;
        }

        public void Frage(AbstractHandler handler)
        {

            foreach (Frage input in _inputs) {

                var temp = handler.Handle(input);

                if (temp != null)
                {
                    Console.WriteLine($"\t{temp}\t");
                }
                else
                {
                    Console.WriteLine("Frage konnte nicht beantwortet werden da kein Lehrer vorhanden ist");

                }
            }
        }
    
    }
}
