using System;
using System.Collections.Generic;
using System.Linq;

namespace heist2
{
    public class Bank{
    public int CashOnHand {get; set;}

    public int AlarmScore {get; set;}

    public int VaultScore {get; set;}

    public int SecurityGuardScore {get; set;}

    //A computerd boolean property called IsSEcure. If all the scores are less than or equal to 0, this should be false.

    public bool IsSecure() {
        
        return CashOnHand <= 0 && AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0 ? false : true;
        
        // if(CashOnHand <= 0 && AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0 ){
        //     return false;
        // } else {
        //     return true;
        // }
    }

    //make a method to give a bank report
    public void Report() {
        List<KeyValuePair<string, int>> stats = new List<KeyValuePair<string, int>>();
        stats.Add(new KeyValuePair<string, int>("Alarm", AlarmScore));
        stats.Add(new KeyValuePair<string, int>("Vault", VaultScore));
        stats.Add(new KeyValuePair<string, int>("Security Guards", SecurityGuardScore));

        var orderStats = stats.OrderBy(n => n.Value).ToList();

        Console.WriteLine("Here's some intel on the bank we're hitting");
        Console.WriteLine($"Most Secure: {orderStats[2].Key}");
        Console.WriteLine($"Lease Secure: {orderStats[0].Key}");
        Console.WriteLine("                ");
        
    }
    }
}
