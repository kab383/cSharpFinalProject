using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoClaims.Repository;

namespace KomodoClaims.ConsoleApp
{
    public class UserInterface
    {
        private bool isRunning = true;

        ClaimsRepository _claimsRepo = new ClaimsRepository();
        CustomConsole _customConsole = new CustomConsole();

        public void Run()
        {
            _claimsRepo.SeedClaimsData();

            while(isRunning)
            {
                _customConsole.PrintMainMenu();

                string input = _customConsole.AgentInput();

                MainMenuSelectionSwitchCase(input);
            }
        }

        private void MainMenuSelectionSwitchCase(string input)
        {
            switch(input)
            {
                case "1":
                    ViewAllClaims();
                    break;
                case "2":
                    TakeCareOfNextClaim();
                    break;
                case "3":
                    EnterNewClaim();
                default:
                    Console.WriteLine("Please try again by selecting one of the above options.");
                    break;
            }
        }

        private void ViewAllClaims()
        {
            List<Claim> allClaims = _claimsRepo.GetClaims();
            _customConsole.PrintClaimsHeadings();
            foreach(Claim claim in allClaims)
            {
                _customConsole.PrintClaim(claim);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void TakeCareOfNextClaim()
        {
            Queue<Claim> allClaims = new Queue<Claim>(_claimsRepo.GetClaims());
            foreach(Claim claim in allClaims)
            {
                _customConsole.PrintClaimsHeadings();
                _customConsole.PrintClaim(claim);
                Console.Write("Do you want to deal with this claim right now?(y/n): ");
                string input = Console.ReadLine();
                if(input.ToUpper() == "Y")
                {
                    Console.WriteLine("The claim will now be removed from the queue");
                    allClaims.Dequeue();
                }
                else if(input.ToUpper() == "N")
                {
                    _customConsole.PrintMainMenu();
                }
                else
                {
                    Console.WriteLine("I'm sorry, we didn't understand. You are now being redirected to the main menu. Please try again.");
                }
            }
        }

        public void EnterNewClaim()
        {
            Console.WriteLine("Please answer the following prompts to add a new claim to the working list.");

            Console.Write("\nEnter the claim ID: ");
            string claimID = _customConsole.AgentInput();
            
            Console.Write("\nEnter the claim type: ");
            string claimType = _customConsole.AgentInput();

            Console.Write("\nEnter a claim description: ");
            string claimDescription = _customConsole.AgentInput();

            Console.Write("\nAmount of Damage: $ ");
            string description = _customConsole.AgentInput();

            Console.Write("\nDate Of Accident: ");
            string dateOfAccident = _customConsole.AgentInput();

            Console.Write("\nDate Of Claim: ");
            string dateOfClaim = _customConsole.AgentInput();

            if(_customConsole.ValidClaim() == true)
            {
                Console.Write("This is a valid claim");
            }
            else
            {
                Console.Write("This is not a valid claim");
            }

        }
    }
}