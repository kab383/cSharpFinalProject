using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoClaims.Repository
{
    public class ClaimsRepository
    {
        // CRUD
        private List<Claim> _claims = new List<Claim>();
        // CREATE
        public void AddClaim(Claim claim)
        {
            _claims.Add(claim);
        }
        
        // READ
        public List<Claim> GetClaims()
        {
            return _claims;
        }

        //UPDATE

        
        // DELETE


        // SEED DATA
        public void SeedClaimsData()
        {
            Claim claimOne = new Claim(1, "Car", "Car accident on 465.", 400.00m, 04/25/18, 04/27/18, true);

            Claim claimTwo = new Claim(2, "Home", "House fire in Kitchen.", 4000.00m, 04/11/18, 04/12/18, true);

            Claim claimThree = new Claim(3, "Theft", "Stolen pancakes.", 4.00m, 04/27/18, 06/01/18, false);

            Claim[] claimsArr = {claimOne, claimTwo, claimThree};

            foreach (Claim claim in claimsArr)
            {
                AddClaim(claim);
            }
        }
    }
}