using System;

namespace heist2 
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public string Type {get{return "Muscle";}}
        public int PercentageCut { get; set; }

         public void PerformSkill(Bank bank)
        { 
            bank.SecurityGuardScore -= SkillLevel;
            
            Console.WriteLine($"{Name} is tying up the guards. Decreased security by {SkillLevel} points.");
            
            if(bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the security guards!");
            }
        }
    }
}