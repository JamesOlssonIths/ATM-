namespace WestcoastBank;

public class SavingsAccount(string accountNo, string fName, string lname)
: Account(accountNo, fName, lname)
{
    const double INTEREST_RATE = 0.05;
    public override int Balance => 
        Convert.ToInt32(base.Balance * (1 + INTEREST_RATE));

 
    public override void Deposit(int amount)
    {
        Balance += amount;
        AddTransaction(amount, TransactionTypeEnum.Insättning);
    }
 



}
