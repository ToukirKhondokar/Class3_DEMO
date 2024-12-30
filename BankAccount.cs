using System.ComponentModel;

public class BankAccount
{
    public string AccountNumber { get; private set; }
    public string AccountName { get; private set; }

    public decimal AccountBalance { get; private set; }
    private int zero = 0;


    public BankAccount(string AccountNumber, string AccountName)
    {
        this.AccountNumber = AccountNumber;
        this.AccountName = AccountName;
    }



    //method for zero amount
    private void AmountNotZero(decimal amount)
    {
        if (amount <= zero)
        {
            throw new InvalidEnumArgumentException($"amount can not be zero or negative");
        }
    }



    //withdraw
    public void Withdraw(decimal amount)
    {
        AmountNotZero(amount);
        AccountBalance -= amount;
    }

    //deposit
    public void Deposit(decimal amount)
    {
        AmountNotZero(amount);
        AccountBalance += amount;

    }




    //if not possible to transfer the amount
    private void AmountTransferProblem(BankAccount AnotherAccount, decimal amount)
    {

        AmountNotZero(amount);
        if (amount > AccountBalance)
        {
            throw new InvalidEnumArgumentException($"Amount is greater then Account Balance.. ");
        }
        if (AccountBalance == zero)
        {
            throw new InvalidEnumArgumentException($"Account balance is zero..");
        }
    }

    //transfer the amount
    public void Transfer(BankAccount AnotherAccount, decimal amount)
    {
        AmountTransferProblem(AnotherAccount, amount);
        Withdraw(amount);
        AnotherAccount.Deposit(amount);


    }




}