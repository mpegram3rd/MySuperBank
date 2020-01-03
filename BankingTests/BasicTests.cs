using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void DemoTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void MakeWithdrawal_OverDrawn()
        {
            var account = new BankAccount("Macon", 10000);

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw")
            );
        }

        [Fact]
        public void MakeWithdrawal_NegativeInitialBalance()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("Macon", -55)
            );
        }
    }
}
