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
        /// COstruttore dell'oggetto Monomio che prende
        /// in input il valore del coefficente, l'incognita,
        /// e il valore dell'esponente
        /// </summary>
        /// <param name="coef"></param>
        /// <param name="var"></param>
        /// <param name="exp"></param>
        public Monomial(int? coef, string var = "x", int exp = 0)
        {

            Coefficient = coef;
            Exponent = exp;
            Variable = var;
             

        }

        public Monomial(Rational r, string var = "x", int exp = 0)
        {

            Rational = r;
            Variable = var;
            Exponent=exp;


        }

        private Rational Rational;
        private int? Coefficient;
        private string Variable;
        private int Exponent;
        
    }
}
