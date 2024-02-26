using System;

public class Deposit
{
    public virtual int Id { get; set; }
    public virtual string OwnerFullName { get; set; }
    public virtual decimal DepositAmount { get; set; }
    public virtual int DepositTermMonths { get; set; }
    public virtual decimal InterestRate { get; set; }
    public virtual DateTime DepositDate { get; set; }

    public virtual void GetInformation()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Owner's Full Name: {OwnerFullName}");
        Console.WriteLine($"Deposit Amount: {DepositAmount}");
        Console.WriteLine($"Deposit Term (months): {DepositTermMonths}");
        Console.WriteLine($"Interest Rate: {InterestRate}");
        Console.WriteLine($"Deposit Date: {DepositDate}");
    }

    public virtual decimal CloseDeposit()
    {
        return 0;
    }
}

public class Credit : Deposit
{
    public override decimal InterestRate
    {
        get
        {
           return 10;
        }
    }

    public override decimal CloseDeposit()
    {
        return base.DepositAmount * (1 + InterestRate / 100);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Deposit deposit = new Deposit
        {
            Id = 1,
            OwnerFullName = "gg",
            DepositAmount = 1599999999,
            DepositTermMonths = 999999999,
            InterestRate = 0,
            DepositDate = DateTime.Now
        };

        deposit.GetInformation();

        decimal amount = deposit.CloseDeposit();
        Console.WriteLine($"Returned amount: {amount}");

        Console.WriteLine();

        Credit credit = new Credit
        {
            Id = 2,
            OwnerFullName = "ggg",
            DepositAmount = 2999999999999,
            DepositTermMonths = 999999,
            DepositDate = DateTime.Now
        };

        credit.GetInformation();

        amount = credit.CloseDeposit();
        Console.WriteLine($"Returned amount: {amount}");
    }
}