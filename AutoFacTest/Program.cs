using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            //Calculator calculatorService = new Calculator();
            //EmployeePay employeePayService = new EmployeePay(calculatorService);

            var container = ContainerRegister.Configure();
            var pay = Console.ReadLine();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<EmployeePay>();
                var monthlyPay = app.GenerateMonthlyPaid(Convert.ToDouble(pay));
                Console.WriteLine("The monthly pay are " + monthlyPay.ToString());
            }

            //var monthlyPay = employeePayService.GenerateMonthlyPaid(Convert.ToDouble(pay));
            //Console.WriteLine("The monthly pay are " + monthlyPay.ToString());
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
