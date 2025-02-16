using Microsoft.AspNetCore.Identity;

namespace ELearning.Data
{
    public class Role:IdentityRole
    {
        public Role()
        {
           Id=Guid.CreateVersion7().ToString();
        }
    }
}
