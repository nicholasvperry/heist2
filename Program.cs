using System;
using System.Collections.Generic;
using System.Linq;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> roladex = new List<IRobber>()
            {
            new Hacker()
            {
                Name = "Jordan",
                SkillLevel = 39,
                PercentageCut = 20
            },
            new Hacker()
            {
                Name = "Jonah",
                SkillLevel = 32,
                PercentageCut = 25
            },
            new LockSpecialist()
            {
                Name = "Aki",
                SkillLevel = 45,
                PercentageCut = 18
            },
            new LockSpecialist()
            {
                Name = "Heaven",
                SkillLevel = 41,
                PercentageCut = 33
            },
            new Muscle()
            {
                Name = "Nick",
                SkillLevel = 25,
                PercentageCut = 15
            },
            new Muscle()
            {
                Name = "Gary",
                SkillLevel = 37,
                PercentageCut = 22
            }
            };

                
            //Print each name on the list
            //roladex.ForEach(x => Console.WriteLine(x.Name));
            
            Console.WriteLine("We're planning another heist!");
            Bank bank = new Bank(){
            AlarmScore = new Random().Next(0, 100),
            VaultScore = new Random().Next(0, 100),
            SecurityGuardScore = new Random().Next(0, 100),
            CashOnHand = new Random().Next(50000, 1000000)
            };

            while(true){
                Console.WriteLine($"You have {roladex.Count} contacts in our roladex.");
                Console.Write("New contact name : ");
                string Name = Console.ReadLine();
                 //breaks loop if no Name is inserted
                if (Name == "") {
                    break;
                }
                Console.WriteLine("Please enter a number for the type of member they will be:");
                Console.WriteLine("1) Hacker (Disarms alarms)");
                Console.WriteLine("2) Muscle (Disarms guards");
                Console.WriteLine("3) Lock Specialist (Cracks vault)");
                int skill = int.Parse(Console.ReadLine());
                
            
                
            
                Console.WriteLine($"Please enter {Name}'s skill level between 1 and 100:");
                int SkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine($"What % is the cut {Name} requires?");
                int PercentageCut = int.Parse(Console.ReadLine());

                if(skill == 1){
                    Hacker newGuy = new Hacker()
                {
                    Name = Name,
                    SkillLevel = skill,
                    PercentageCut = PercentageCut
                };
                roladex.Add(newGuy);
                } else if(skill == 2){
                    Muscle newGuy = new Muscle()
                {
                    Name = Name,
                    SkillLevel = skill,
                    PercentageCut = PercentageCut
                }; 
                roladex.Add(newGuy);
                }else if(skill == 3) {
                    LockSpecialist newGuy = new LockSpecialist()
                {
                    Name = Name,
                    SkillLevel = skill,
                    PercentageCut = PercentageCut
                    
                };
                roladex.Add(newGuy);
                }
                
                
            }

            
            List<IRobber> crew = new List<IRobber>();

            Console.WriteLine("Time to get busy. Choose your crew.");
            while(true){
            bank.Report();
            for(int i=0; i<roladex.Count;i++){
                if(!crew.Any(x => x.Name == roladex[i].Name)){

                Console.WriteLine($"Choose {i + 1} for: ");
                Console.WriteLine($"Name: {roladex[i].Name} ");
                Console.WriteLine($"Speciality: {roladex[i].Type}");
                Console.WriteLine($"Skill Level: {roladex[i].SkillLevel}");
                Console.WriteLine($"Cut: {roladex[i].PercentageCut}");
                Console.WriteLine($"----------------");
                
                }
                
            }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            Console.WriteLine("Choose a member:");
            string choice = Console.ReadLine();
            if(choice == ""){
                break;
            }
            else{
                int currentPercent = crew.Sum(x => x.PercentageCut);
                if(currentPercent + roladex[Int32.Parse(choice)-1].PercentageCut <= 100){
                crew.Add(roladex[Int32.Parse(choice)-1]);
                }
                else{
                    Console.WriteLine("Sorry can't add'em... too expensive");
                    Console.WriteLine("                  ");
                }
            }
            // Allow the user to select as many crew members as they'd like from the rolodex. Continue to print out the report after each crew member is selected, but the report should not include operatives that have already been added to the crew, or operatives that require a percentage cut that can't be offered.



            }
            Console.WriteLine("----------------");

            Console.WriteLine("                  ");

            Console.WriteLine("----------------");

            Console.WriteLine("Let the heist begin!");
            crew.ForEach(x => x.PerformSkill(bank));
            if(bank.IsSecure()) {
                Console.WriteLine("Too bad ya got busted. Enjoy your new life in prison.");
            }
            else{
                Console.WriteLine("Enjoy your hard earned stolen cash");
                crew.ForEach(x => {
                    Console.WriteLine($"{x.Name}'s cut is ${bank.CashOnHand*x.PercentageCut/100}");
                });

            }
            // Once the user enters a blank value for a crew member, we're ready to begin the heist. Each crew member should perform his/her skill on the bank. Afterwards, evaluate if the bank is secure. If not, the heist was a success! Print out a success message to the user. If the bank does still have positive values for any of its security properties, the heist was a failure. Print out a failure message to the user.
        }
    }
}