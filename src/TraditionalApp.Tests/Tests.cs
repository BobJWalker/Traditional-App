using NUnit.Framework;
using TraditionalApp.Web.Models;

namespace TraditionalApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Quote.Initialize();
        }

        [Test]
        public void Test1()
        {
            Assert.That(Quote.GetRandomQuote().QuoteText != "Something went wrong");
        }
    }
}