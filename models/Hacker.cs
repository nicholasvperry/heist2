using System;

namespace heist2 
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public string Type {get{return "Hacker";}}

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        { 
            bank.AlarmScore -= SkillLevel;
            
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel} points.");

            if(bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }         
        }

    }
}