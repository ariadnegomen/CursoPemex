using Microsoft.AspNetCore.Identity;

namespace CursoPemex.Data
{
    public class employee : IdentityUser
    {
        public string? FirthsName { get; set; }
        public string? LastName { get; set; }
        public string? TaxID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }


    }
}
