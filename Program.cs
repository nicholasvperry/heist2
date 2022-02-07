using System;
using System.Collections.Generic;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();

            Hacker jordan = new Hacker()
            {
                name = "Jordan",
                SkillLevel = 39,
                PercentageCut = 20
            };
            Hacker jonah = new Hacker()
            {
                name = "Jonah",
                SkillLevel = 32,
                PercentageCut = 25
            };
            LockSpecialist aki = new LockSpecialist()
            {
                name = "Aki",
                SkillLevel = 45,
                PercentageCut = 18
            };
            LockSpecialist heaven = new LockSpecialist()
            {
                name = "Heaven",
                SkillLevel = 41,
                PercentageCut = 33
            };
            Muscle nick = new Muscle()
            {
                name = "Nick",
                SkillLevel = 25,
                PercentageCut = 15
            };
            Muscle gary = new Muscle()
            {
                name = "Gary",
                SkillLevel = 37,
                PercentageCut = 22
            };

            rolodex.Add(jordan);
            rolodex.Add(jonah);
            rolodex.Add(aki);
            rolodex.Add(heaven);
            rolodex.Add(nick);
            rolodex.Add(gary);

            string specialty = "";
            Console.WriteLine($"You have {rolodex.Count} members on your list.");
            while(true){
                Console.Write("Please add a name for a possible team member to add to the list: ");
                string name = Console.ReadLine();
                 //breaks loop if no name is inserted
                if (name == "") {
                    break;
                }
                Console.WriteLine("Please enter a number for the type of member they will be:");
                Console.WriteLine("1) Hacker (Disarms alarms)");
                Console.WriteLine("2) Muscle (Disarms guards");
                Console.WriteLine("3) Lock Specialist (Cracks vault)");
                int skill = int.Parse(Console.ReadLine());
                if(skill == 1){
                    specialty = "Hacker";
                } else if(skill == 2){
                    specialty = "Muscle";
                } else if(skill == 3) {
                    specialty = "LockSpecialist";
                }
            
            
                Console.WriteLine($"Please enter {name}'s skill level between 1 and 100:");
                int SkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine($"What % is the cut {name} requires?");
                int PercentageCut = int.Parse(Console.ReadLine());

                if(skill == 1){
                    Hacker newGuy = new Hacker()
                {
                    name = name,
                    SkillLevel = skill,
                    PercentageCut = PercentageCut
                };
                } else if(skill == 2){
                    Muscle newGuy = new Muscle()
                {
                    name = name,
                    SkillLevel = skill,
                    PercentageCut = PercentageCut
                }; 
                }else if(skill == 3) {
                    LockSpecialist newGuy = new LockSpecialist()
                {
                    name = name,
                    SkillLevel = skill,
                    PercentageCut = PercentageCut
                    
                };
                }
                
                
            }

            Bank bankToRob = new Bank()
                {
                    AlarmScore =  new Random().Next(0, 100),
                    VaultScore = new Random().Next(0, 100),
                    SecurityGuardScore = new Random().Next(0, 100),
                    CashOnHand = new Random().Next(50000, 1000000000)
                };
                int[] bankStats = new int[] {bankToRob.AlarmScore, bankToRob.VaultScore, bankToRob.SecurityGuardScore};
                Array.Sort(bankStats);
                Console.WriteLine($"Most Secure: {bankStats[0]}");
                Console.WriteLine($"Lease Secure: {bankStats[2]}");


            // foreach(IRobber person in rolodex)
            // {
            //     Console.WriteLine(person.name);
            // }
            
        }
    }
}
