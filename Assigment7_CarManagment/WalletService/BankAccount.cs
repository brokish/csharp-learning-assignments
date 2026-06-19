namespace Assigment7_CarManagment.WalletService;

public class BankAccount
{


    private double balance;
   
    public void Deposit(double amount)
    {
        balance = balance + amount;
    }

    public  void ShowBalance()
    {
        Console.WriteLine(balance);  
      
    }
    
 
}