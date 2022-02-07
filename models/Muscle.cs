using System;

namespace heist2 
{
    public class Muscle : IRobber
    {
        public string name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

         public void PerformSkill(Bank bank)
        { 
            int reducedSkill = bank.SecurityGuardScore - SkillLevel;
            
            Console.WriteLine($"{name} is tying up the guards. Decreased security by {SkillLevel} points.");

            if(reducedSkill <= 0)
            {
                Console.WriteLine($"{name} has disabled the security guards!");
            }         
        }
    }
}