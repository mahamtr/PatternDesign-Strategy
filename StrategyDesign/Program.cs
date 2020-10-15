using StrategyDesign.Context;
using StrategyDesign.Strategies;
using System;

namespace StrategyDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MailStrategyContext context;
                var input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        context = new MailStrategyContext(new SMTPService());
                        break;
                    case 2:
                        context = new MailStrategyContext(new SendGridService());
                        break;

                    default:
                        context = new MailStrategyContext(new SMTPService());
                        break;
                }
                Console.WriteLine(context.SendEmail());

            }
        }
    }
}
