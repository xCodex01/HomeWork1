namespace HomeWork.ConsoleApp.DomainModel
{
    public partial class Rational
    {

        /// <summary>
        /// Costruttore del razionale che accetta due parametri
        /// per definire numeratore e denominatore
        /// </summary>
        /// <param name="num"></param>
        /// <param name="den"></param>
        public Rational(int? num, int? den) 
        {

            Numerator = num;
            if (den == 0)
                 throw new DivideByZeroException("Non si può avere un denominatore nullo");
            Denominator = den;

        }

        /// <summary>
        /// Costruttore del razionale che accetta un parametro
        /// per il denominatore e setta a 1 il numeratore
        /// </summary>
        /// <param name="den"></param>
        public Rational(int den)
        {
            Numerator = 1;
            if (den == 0) 
                throw new DivideByZeroException("Non si può avere un denominatore nullo");
            Denominator = den;
            
        }

        //Definisce il numeratore dell'oggetto
        private int? Numerator;
        //Definisce il denominatore dell'oggetto
        private int? Denominator;

        





    }
}
