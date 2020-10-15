using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesign.Context
{
    public class MailStrategyContext
    {
        private IMailStrategy _mailStrategy;

        public MailStrategyContext(IMailStrategy mailStrategy)
        {
            _mailStrategy = mailStrategy;
        }

        public string SendEmail()
        {
            return _mailStrategy.SendEmail();
        }
    }
}
