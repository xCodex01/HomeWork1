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
        /// Costruttore dell'oggetto Monomio che prende
        /// in input il valore del coefficente, l'incognita,
        /// e il valore dell'esponente
        /// </summary>
        /// <param name="coef"></param>
        /// <param name="var"></param>
        /// <param name="exp"></param>
        public Monomial(int? coef, string var = "x", int exp = 0)
        {

            if (coef == null)
                Coefficient = 0;
            else
                Coefficient = (int)coef;
            Exponent = exp;
            Variable = var;
             

        }

        /// <summary>
        /// Costruttore dell'oggetto Monomio
        /// che prende in input un razionale
        /// da rappresentare come coefficiente,
        /// l'incognita e l'esponente
        /// </summary>
        /// <param name="r"></param>
        /// <param name="var"></param>
        /// <param name="exp"></param>
        public Monomial(Rational r, string var = "x", int exp = 0)
        {

            Rational = r;
            Variable = var;
            Exponent=exp;


        }

        //Tipo razionale per il coefficiente razionale
        private Rational Rational;

        //Intero usato per rappresentare il coefficiente
        private int Coefficient;

        //Stringa usata per rappresnetare l'incognita
        private string Variable;

        //intero usato per rappresentare l'esponente
        private int Exponent;
        
    }
}
