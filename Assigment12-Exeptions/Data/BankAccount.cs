using Assigment12_Exeptions.Exeptions;

namespace Assigment12_Exeptions.Data;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public double Balance { get; set; }

    public void WithdrawAmount(double amount)
    {
        if (amount > Balance) throw new InsufficientBalanceException("არასაკმარისი თანხა ანგარიშზე");

        Balance -= amount;
    }
}