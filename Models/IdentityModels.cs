using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace LewisList.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //  [Key]
        //  public int LLUserId { get; set; }

        public virtual ApplicationUser RealUser { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [RegularExpression(@"^[a-zA-Z\d]+[-_a-zA-Z\d]{0,2}[a-zA-Z\d]+")]
        public string UserLoginName { get; set; }

        public string Picture { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }

        public string State { get; set; }
        public string ZipCode { get; set; }


        public int CompareTo(object obj)
        {
            ApplicationUser other_user = obj as ApplicationUser;
            int answer = this.UserName.CompareTo(other_user.UserName);
            return answer;
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; } 

        // public DbSet<Post> Messages { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

}