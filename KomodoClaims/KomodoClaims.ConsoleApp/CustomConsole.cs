using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoClaims.Repository;

namespace KomodoClaims.ConsoleApp
{
    public class CustomConsole
    {
        ClaimsRepository _claimsRepo = new ClaimsRepository();

        public void PrintMainMenu()
        {
            Console.WriteLine("1. See all claims\n" +
                                    "2. Take care of next claim\n" +
                                    "3. Enter a new claim");
        }

        public void PrintClaimsHeadings()
        {
            Console.WriteLine("ClaimID" + " " + "Type" + " " + "Description" + " " + "Amount" + " " + "DateOfAccident" + " " + "DateOfClaim" + " " + "IsValid");
        }

        public string AgentInput()
        {
            return Console.ReadLine();
        }

        // public int AgentInputInt()
        // {
        //     return int.Parse(Console.ReadLine());
 
        // }

        // public ClaimType AgentInputClaimType()
        // {
        //     return 
        // }

        // public decimal AgentInputDecimal()
        // {
        //     decimal inputAsDecimal = Console.ReadLine();
        //     return inputAsDecimal;
        // }
        // public DateTime AgentInputDateTime()
        // {
        //     DateTime inputAsDateTime = Console.ReadLine();
        //     return inputAsDateTime.ToShortDateString();
        // }
        // public bool AgentInputBool()
        // {
        //     decimal inputAsBool = Console.ReadLine();
        //     return inputAsBool;
        
        public void PrintClaim(Claim claim)
        {
            Console.WriteLine($"{claim.ClaimID} {claim.TypeOfClaim} {claim.Description} ${claim.ClaimAmount} {claim.DateOfIncident.ToShortDateString()}  {claim.DateOfClaim.ToShortDateString()} {claim.IsValid}"); 
        }

        public bool ValidClaim(Claim claim)
        {
            long x = long.Parse(claim.DateOfClaim).ToString("yyyyMMddHHmmss");
            long y = long.Parse(claim.DateOfIncident).ToString("yyyyMMddHHmmss");
            int result = int.Parse(x - y);
            if(x >= 30)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}