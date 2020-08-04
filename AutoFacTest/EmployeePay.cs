namespace AutoFacTest
{
    public class EmployeePay
    {
        public ICalculator _calculator;

        public EmployeePay(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public double GenerateMonthlyPaid(double payPerMont)
        {
            return _calculator.Multiply(payPerMont, 30);
        }
    }
}