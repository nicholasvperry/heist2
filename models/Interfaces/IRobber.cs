using System;
using System.Collections.Generic;

namespace heist2 
{
    public interface IRobber
    {
        string Name {get; set;}
        int SkillLevel {get; set;}
        public string Type {get;}
        int PercentageCut {get; set;}

        void PerformSkill(Bank bank)
        {
            
        }
    }
}