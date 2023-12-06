using System;
using System.Runtime.InteropServices;

class Account
{
    string accountName;
    string accountNumber;
    int accountTotal;
    int accountChecking;
    int accountSavings;
    int myMoney;
    int Bills;
    public Account(string accName)
    {
        int fourdigit = 0;
        Random randomNums = new Random();
        while (fourdigit != 4)
        {
            int accID = randomNums.Next(1,10);
            accountNumber += accID;
            fourdigit++;
        }
        accountName = accName;

    }
    public void checking()
    {

    }

    public void savings()
    {

    }

    public void deposite()
    {

    }

    public void withdraw()
    {

    }

    public void smartDeposite()
    {

    }

    public string WriteToFile()
    {
        string saveAccount = ($"{accountName}*^*{accountNumber}*^*{accountTotal}*^*{accountChecking}*^*{accountSavings}*^*{myMoney}*^*{Bills}*^*(<ENDACC>)\n");
        
        return saveAccount;
    }





}