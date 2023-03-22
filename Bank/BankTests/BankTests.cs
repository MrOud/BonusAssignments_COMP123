using BankApp;

namespace BankTests
{
    [TestClass]
    public class BankTests
    {
        [TestMethod]
        [Owner("Kris Oud")]
        [TestCategory("Important")]
        public void Deposit_ValidAmount_UpdatesBalance() {

            //arrange
            double startingBalance = 100;
            double depositAmount = 50;
            double expectedBalance = 150;
           

            //act
            BankAccount bankAccount = new BankAccount(127, "Test E. McTestface", startingBalance);
            bankAccount.Deposit(depositAmount);

            //assert
            Assert.AreEqual(bankAccount.Balance, expectedBalance);
        }

        [TestMethod]
        [Owner("Kris Oud")]
        [TestCategory("Important")]
        public void Withdraw_ValidAmount_UpdatesBalance() {

            //arrange
            double startingBalance = 100;
            double withdrawAmount = 50;
            double expectedBalance = 50;


            //act
            BankAccount bankAccount = new BankAccount(127, "Test E. McTestface", startingBalance);
            bankAccount.Withdraw(withdrawAmount);

            //assert
            Assert.AreEqual(bankAccount.Balance, expectedBalance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Amount cannot be greater than the Balance")]
        [Owner("Kris Oud")]
        [TestCategory("Very Important")]
        public void Withdraw_WithException_WithdrawGreaterThanBalance() {

            //arrange
            double startingBalance = 100;
            double withdrawAmount = 150;


            //act
            BankAccount bankAccount = new BankAccount(127, "Test E. McTestface", startingBalance);
            bankAccount.Withdraw(withdrawAmount);

            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Amount cannot be 0 or negative")]
        [Owner("Kris Oud")]
        [TestCategory("Very Important")]
        public void Withdraw_WithException_WithdrawAmountZero() {

            //arrange
            double startingBalance = 100;
            double withdrawAmount = 0;

            //act
            BankAccount bankAccount = new BankAccount(127, "Test E. McTestface", startingBalance);
            bankAccount.Withdraw(withdrawAmount);

            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Amount cannot be 0 or negative")]
        [Owner("Kris Oud")]
        [TestCategory("Very Important")]
        public void Deposit_WithException_DepositAmountNegative() {

            //arrange
            double startingBalance = 100;
            double depositAmount = -1;

            //act
            BankAccount bankAccount = new BankAccount(127, "Test E. McTestface", startingBalance);
            bankAccount.Deposit(depositAmount);

            //assert
        }
    }
}