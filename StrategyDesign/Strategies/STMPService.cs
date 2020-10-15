using StrategyDesign.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesign.Strategies
{
    public class SMTPService : IMailStrategy
    {
        public string SendEmail()
        {
            return "Sent email via SMTP";
        }
    }
}
