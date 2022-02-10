using System;
namespace heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public string Type {get{return "Lock Pick";}}

        public int PercentageCut { get; set; }

         public void PerformSkill(Bank bank)
        { 
            bank.VaultScore -= SkillLevel;
            
            Console.WriteLine($"{Name} is picking the locks. Decreased security by {SkillLevel} points.");

            if(bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has picked the lock!");
            }         
        }
    }
}