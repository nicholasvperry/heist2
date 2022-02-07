using System;

namespace heist2 
{
    public class Hacker : IRobber
    {
        public string name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        { 
            int reducedSkill = bank.AlarmScore - SkillLevel;
            
            Console.WriteLine($"{name} is hacking the alarm system. Decreased security by {SkillLevel} points.");

            if(reducedSkill <= 0)
            {
                Console.WriteLine($"{name} has disabled the alarm system!");
            }         
        }

    }
}