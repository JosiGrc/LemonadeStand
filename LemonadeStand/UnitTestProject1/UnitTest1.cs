using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace TestingHowMuchMOneyThePlayerSpent
{
    [TestClass]
    public class TestingHowMuchMOneyThePlayerSpent
    {   //The outcome should be 9.50 since im buying 2 lemons at the price of .25 each
        [TestMethod]
        public void MoneyLostFromBuyingLemons_SubtractingFromPlayerMoney_Money()
        {
            //Arrange(Member Variables)
            Store store = new Store();
            Player player = new Player();
            double money = 10;
            double moneyExpected = 9.50;
            double actual;
            int lemonsBought = 2;
            
            //Act(Ctor)
            actual = store.MoneyLostFromBuyingLemons(money, lemonsBought);


            //Assert(Methods)
            Assert.AreEqual(moneyExpected, actual);
        }
    }
}
