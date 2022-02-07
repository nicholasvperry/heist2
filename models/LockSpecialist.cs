using System;
namespace heist2
{
    public class LockSpecialist : IRobber
    {
        public string name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

         public void PerformSkill(Bank bank)
        { 
            int reducedSkill = bank.VaultScore - SkillLevel;
            
            Console.WriteLine($"{name} is picking the locks. Decreased security by {SkillLevel} points.");

            if(reducedSkill <= 0)
            {
                Console.WriteLine($"{name} has picked the lock!");
            }         
        }
    }
}