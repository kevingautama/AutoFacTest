using Autofac;

namespace AutoFacTest
{
    public static class ContainerRegister
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Calculator>().As<ICalculator>();
            builder.RegisterType<EmployeePay>();

            return builder.Build();
        }
    }
}