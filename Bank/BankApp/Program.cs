namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args) {
            //Create account object
            BankAccount bankAccount = new BankAccount(1123581321, "Fib O'Nacci", 1000.00);
            
            //Ask the user for an amount to deposit then show the new balance
            Console.Write("Deposit Amount - $");
            double promptMonies = Double.Parse(Console.ReadLine());
            bankAccount.Deposit(promptMonies);
            Console.WriteLine($"Your new balance is {bankAccount.Balance.ToString("C")}");

            //Ask the user for an amountto withdraw then show new balance
            Console.Write("Withdrawal Amount - $");
            promptMonies = Double.Parse(Console.ReadLine());
            bankAccount.Withdraw(promptMonies);
            Console.WriteLine($"Your new balance is {bankAccount.Balance.ToString("C")}");

        }
    }
}