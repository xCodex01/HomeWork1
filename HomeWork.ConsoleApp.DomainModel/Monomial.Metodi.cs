using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ConsoleApp.DomainModel
{
    public partial class Monomial
    {
        /// <summary>
        /// Override del metodo ToString per poter
        /// printare l'oggetto Monomio
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Coefficient == 1)
                return $"{Variable}^{Exponent}";

            else if (Coefficient == null)
                return $"";

            else if (Exponent == 1)
                return $"{Coefficient}{Variable}";

            return $"{Coefficient}{Variable}^{Exponent}";
        }

        /// <summary>
        /// Overload dell'operando addizione,
        /// lancia eccezione se hanno esponente o
        /// incognità diverse
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        /// <exception cref="DifferentExponentException"></exception>
        public static Monomial operator +(Monomial m1, Monomial m2)
        {
            if (m1.Exponent == m2.Exponent)
                return new Monomial((m1.Coefficient + m2.Coefficient), m1.Variable, m2.Exponent);

            else if (m1.Variable != m2.Variable)
                throw new DifferentVariableException(m1, m2);

            throw new DifferentExponentException(m1, m2);
        }

        /// <summary>
        /// Overload dell'operando sottrazione,
        /// lancia eccezione se hanno esponente
        /// o incognite diverse
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        /// <exception cref="DifferentExponentException"></exception>
        /// <exception cref="DifferentVariableException"></exception>
        public static Monomial operator -(Monomial m1, Monomial m2)
        {

            if (m1.Exponent != m2.Exponent) 
                throw new DifferentExponentException(m1, m2);

            else if(m1.Variable != m2.Variable)
                throw new DifferentVariableException(m1, m2);
        
            return new Monomial((m1.Coefficient - m2.Coefficient), m1.Variable, m2.Exponent);

        }


        /// <summary>
        /// Overload delloperando moltiplicazione
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Monomial operator *(Monomial m1, Monomial m2) => new((m1.Coefficient * m2.Coefficient), (m1.Variable+m2.Variable), (m1.Exponent*m2.Exponent));

        


        

    }

}
