namespace HomeWork.ConsoleApp.DomainModel
{
    public class DifferentVariableException : Exception
    {
        /////////////////////////////////////
        ///ECCEZIONE NON ANCORA IMPLEMENTATA
        /// PER COME SONO STRUTTURATE LE OPERAZIONE
        /// NEL MAIN (PROGRAM.CS)
        ///
        public Monomial M1 { get; }
        public Monomial M2 { get; }

        /// <summary>
        /// Eccezione per operazioni (somma o sottrazione)
        /// non consetite
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        public DifferentVariableException(Monomial m1, Monomial m2)
        {
            M1 = m1;
            M2 = m2;
        }

        public override string Message
        {
            get
            {
                return $"{M1.ToString()} + {M2.ToString()}";
            }
        }

    }
}
