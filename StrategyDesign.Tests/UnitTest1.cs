using NUnit.Framework;
using StrategyDesign.Context;
using StrategyDesign.Strategies;

namespace StrategyDesign.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldSuccedWithSendGridStrategy()
        {
            //arrange
            var context = new MailStrategyContext(new SendGridService());

            //act
            var result = context.SendEmail();

            //asert
            Assert.AreEqual(result, "Sent email via SENDGRID");
        }

        [Test]
        public void ShouldSuccedWithSMTPStrategy()
        {
            //arrange
            var context = new MailStrategyContext(new SMTPService());

            //act
            var result = context.SendEmail();

            //asert
            Assert.AreEqual(result, "Sent email via SMTP");
        }


    }
}