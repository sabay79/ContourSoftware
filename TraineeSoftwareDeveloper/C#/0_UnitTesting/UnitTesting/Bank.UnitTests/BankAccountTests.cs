namespace Bank.UnitTests
{
    [TestClass]
    public class BankAccountTests
    {
        /// <summary>
        /// Created a test method to confirm that a valid amount is correctly deducted in the Debit method. 
        /// </summary>

        [TestMethod]
        public void Debit_WithValidAmount_UpdateBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            BankAccount account = new("Mr. Bryan", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        /// <summary>
        /// Now, verify that the method throws an ArgumentOutOfRangeException if the debit amount is either:
        /// - greater than the balance, or
        /// - less than zero.
        /// </summary>

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;

            BankAccount account = new("Mr. Bryan", beginningBalance);

            // Act & Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 100.00;

            BankAccount account = new("Mr. Bryan", beginningBalance);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
    }
}