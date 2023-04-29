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
                return $"{M1.ToString()} + {M2.ToString()}";
            }
        }

    }
}
