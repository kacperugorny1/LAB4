using Microsoft.AspNetCore.Identity;

namespace LAB4_2.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? RatingId {  get; set; }
        public string? Rating { get; set; }
    }

}
