using System.ComponentModel.DataAnnotations;

namespace Class3_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var Account_1 = new BankAccount("1423-5743", "Toukir");

                Account_1.Deposit(1000);
                Account_1.Withdraw(500);

                var Account_2 = new BankAccount("8735-6729", "Arnab");
                Account_1.Transfer(Account_2, 500);


                System.Console.WriteLine($"Account 1 balance is:{Account_1.AccountBalance}");
                System.Console.WriteLine($"Account 2 balance is:{Account_2.AccountBalance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");

            }

        }
    }
}
