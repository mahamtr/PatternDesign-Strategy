using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesign.Context
{
   public interface IMailStrategy
    {
        string SendEmail();
    }
}
