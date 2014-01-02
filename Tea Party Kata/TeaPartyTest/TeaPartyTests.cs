using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tea_Party_Kata;


namespace TeaPartyTest
{
    [TestClass]
    public class TeaPartyTests
    {
        [TestMethod]
        public void TestWelcomeForMales()
        {
            TeaPartyWelcome teaPartyWelcome = new TeaPartyWelcome();
            string actualWelcome = teaPartyWelcome.Welcome("Doe", "Male", false);

            Assert.AreEqual("Hello Mr. Doe", actualWelcome, true, "Males not greeted correctly");
        }

        [TestMethod]
        public void TestWelcomeForFemales()
        {
            TeaPartyWelcome teaPartyWelcome = new TeaPartyWelcome();
            string actualWelcome = teaPartyWelcome.Welcome("Doe", "Female", false);

            Assert.AreEqual("Hello Ms. Doe", actualWelcome, true, "Females not greeted correctly");
        }

        [TestMethod]
        public void TestWelcomeForKnights()
        {
            TeaPartyWelcome teaPartyWelcome = new TeaPartyWelcome();
            string actualWelcome = teaPartyWelcome.Welcome("Doe", "Male", true);

            Assert.AreEqual("Hello Sir Doe", actualWelcome, true, "Knights not greeted correctly");
        }
    }
}
