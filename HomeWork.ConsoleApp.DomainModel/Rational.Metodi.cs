namespace HomeWork.ConsoleApp.DomainModel
{
    public partial class Rational
    {

        /// <summary>
        /// Overload dell'operando somma per i razionali
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static Rational operator +(Rational r1, Rational r2)
        {
            int nuovoNumeratore = (r1.Numerator * r2.Denominator) + (r2.Numerator * r1.Denominator);
            int nuovoDenominatore = r1.Denominator * r2.Denominator;

            Rational result = new Rational(nuovoNumeratore, nuovoDenominatore);
            result.Reduce();
            return result;

        }

        /// <summary>
        /// Override del metodo ToString per l'output
        /// dell'oggetto rational
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Numerator == Denominator ? $"1" : $"{Numerator}/{Denominator}";
        }

        /// <summary>
        /// Overload dell'Operando sottrazione per i razionali
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static Rational operator -(Rational r1, Rational r2)
        {
            int nuovoNumeratore = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
            int nuovoDenominatore = r1.Denominator * r2.Denominator;

            Rational result = new Rational(nuovoNumeratore, nuovoDenominatore);
            result.Reduce();
            return result;
        }

        /// <summary>
        /// Calcolo del minimo comune multiplo (Least Common Multiple)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int LCM(int a, int b)
        {
            return a / GCD(a, b) * b;
        }

        /// <summary>
        /// Calcolo del il massimo comune divisore 
        /// tra il numeratore e il denominatore del razionale
        /// (Greatest Common Divisor)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int GCD(int a, int b)
        {
            //Se b = 0 allora ritorna 'a' sennò esegue una
            //chiamata ricorsiva con secondo parametro
            //il risultato del modulo tra 'a' e 'b'
            return b == 0 ? a : GCD(b, a % b);
        }
        /*
        Versione iterativa del GCD
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
    
            return a;
        }
        */

        /// <summary>
        /// Riduce ai minimi termini denominatore
        /// e numeratore
        /// </summary>
        private void Reduce()
        {
            int gcd = GCD(Math.Abs(Numerator), Denominator);
            Numerator /= gcd;
            Denominator /= gcd;

        }

        /// <summary>
        /// Override dell'operatore moltiplicazione
        /// per i razionali
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static Rational operator *(Rational r1, Rational r2)
        {

            int nuovoNumeratore = r1.Numerator * r2.Numerator;
            int nuovoDenominatore = r1.Denominator * r2.Denominator;

            Rational result = new Rational(nuovoNumeratore, nuovoDenominatore);

            result.Reduce();
            return result;

        }

        /// <summary>
        /// Override dell'operazione divisione
        /// per i razionali
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        public static Rational operator /(Rational r1, Rational r2)
        {

            if (r2.Numerator == 0)
                throw new DivideByZeroException("Non si puo avere un denominatore nullo");

            int nuovoNumeratore = r1.Numerator * r2.Denominator;
            int nuovoDenominatore = r1.Denominator * r2.Numerator;

            Rational result = new Rational(nuovoNumeratore, nuovoDenominatore);

            result.Reduce();
            return result;

        }

        /// <summary>
        /// Parsa una stringa nel formato "numeratore/denominatore" e restituisce un oggetto Rational corrispondente.
        /// </summary>
        /// <param name="input">La stringa da parsare</param>
        /// <returns>L'oggetto Rational parsato</returns>
        public static Rational Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("La stringa di input non può essere vuota o composta solo da spazi vuoti.");

            string[] parts = input.Split('/');
            if (parts.Length != 2)
                throw new ArgumentException("La stringa di input non è nel formato corretto.");

            if (!int.TryParse(parts[0], out int numerator) || !int.TryParse(parts[1], out int denominator))
                throw new ArgumentException("La stringa di input contiene valori non validi per numeratore o denominatore.");

            return new Rational(numerator, denominator);
        }

        /// <summary>
        /// Ritorna il valore in decimale del numero razionale
        /// </summary>
        public void ValueOf()
        {
            Console.WriteLine("Il valore del razionale è: "+((float)Numerator/(float)Denominator));
        }

        /// <summary>
        /// Ritorna il numeratore
        /// </summary>
        /// <returns></returns>
        public int GetNumerator()
        {
            return Numerator;
        }

        /// <summary>
        /// Ritorna il denominatore
        /// </summary>
        /// <returns></returns>
        public int GetDenominator()
        {
            return Denominator;
        }

        /// <summary>
        /// Override del metodo Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Rational other = (Rational)obj;
            return Numerator == other.Numerator && Denominator == other.Denominator;
        }

        /// <summary>
        /// Prende l'hashcode della variabile
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Numerator.GetHashCode();
                hash = hash * 23 + Denominator.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Ovveride dell'operatore ==
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static bool operator ==(Rational r1, Rational r2)
        {
            if (ReferenceEquals(r1, r2))
                return true;
            
            if (ReferenceEquals(r1, null) || ReferenceEquals(r2, null))
                return false;
            
            return r1.Equals(r2);
        }

        /// <summary>
        /// Ovveride dell'operatore !=
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1 == r2);
        }



    }

}
