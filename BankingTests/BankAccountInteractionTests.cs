﻿using BankingDomain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class BankAccountInteractionTests
    {
        [Fact]
        public void DepositUsesTheBonusCalculator()
        {
            // Given
            var stubbedCalculator = new Mock<ICanCalculateBankAccountBonuses>();
            var account = new BankAccount(stubbedCalculator.Object);
            var openingBalance = account.GetBalance();
            var amountToDeposit = 10M;
            stubbedCalculator
                .Setup(c => c.For(openingBalance, amountToDeposit))
                .Returns(42);


            // When
            account.Deposit(amountToDeposit);
            /// Then
            Assert.Equal(
                openingBalance +
                amountToDeposit +
                42, account.GetBalance());
            
        }
    }

  
}
