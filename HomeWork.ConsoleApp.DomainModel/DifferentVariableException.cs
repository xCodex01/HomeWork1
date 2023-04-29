using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ConsoleApp.DomainModel
{
    public class DifferentVariableException : Exception
    {

        public Monomial M1 { get; }
        public Monomial M2 { get; }

        public DifferentVariableException(Monomial m1, Monomial m2)
        {
            M1 = m1;
            M2 = m2;
        }

        public override string Message
        {
            get
            {
                return $"Impossibile combinare monomi con incognitè diverse. Monomi: {M1} + {M2}";
            }
        }

    }
}
