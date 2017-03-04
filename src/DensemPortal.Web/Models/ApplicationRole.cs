using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DensemPortal.Core.Domain.Main
{
    public sealed class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public string Description { get; set; }
    }
}
