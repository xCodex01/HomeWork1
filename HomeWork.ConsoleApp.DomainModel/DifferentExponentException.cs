namespace HomeWork.ConsoleApp.DomainModel
{
    public class DifferentExponentException : Exception
    {

        public Monomial M1 { get; }
        public Monomial M2 { get; }

        public DifferentExponentException(Monomial m1, Monomial m2)
        {

            M1 = m1;
            M2 = m2;

        }

        public override string Message
        {

            get
            {
                return $"{M1} + {M2}";
            }

        }

    }
}
