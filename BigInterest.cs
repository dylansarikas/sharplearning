static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) {
            return 3.213f;
        } else if (balance >= 0 && balance < 1000) {
            return .5f;
        } else if (balance >= 1000 && balance < 5000){
            return 1.621f;
        } else {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance) => balance * (decimal) InterestRate(balance) * .01m;

    public static decimal AnnualBalanceUpdate(decimal balance) => Interest(balance) + balance;

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
