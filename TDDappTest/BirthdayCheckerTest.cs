using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDapp;

namespace TDDappTest
{
    [TestClass]
    public class BirthdayCheckerTest
    {
        [TestMethod]
        public void IsTodayBirthday_09112021_expectedTrue()
        {
            bool actual = BirthdayChecker.IsBirthdayToday(new DateTime(2021, 11, 9));
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsTodayBirthday_02112021_expectedFalse()
        {
            bool actual = BirthdayChecker.IsBirthdayToday(new DateTime(2021, 11, 2));
            Assert.IsFalse(actual);
        }
    }
}
