using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Model;
using Persistanse;
using System.Linq;

namespace Services.Auth
{
    public class ApplicationRoleManager : RoleManager<ApplicationRol>
    {
        public ApplicationRoleManager(IRoleStore<ApplicationRol, string> roleStore)
            : base(roleStore) { }

        public static ApplicationRoleManager Create(
                IdentityFactoryOptions<ApplicationRoleManager> options,
            IOwinContext context)
        {
            var manager = new ApplicationRoleManager(
                new RoleStore<ApplicationRol>(context.Get<ApplicationDbContext>()));

            var db = context.Get<ApplicationDbContext>();

            //le agregamos el rol de admin al admin
            if (!db.ApplicationUserRoles.Any())
            {
                db.ApplicationUserRoles.Add(new ApplicationUserRole
                {
                    UserId = db.ApplicationUsers.Where(u => u.Email == "admin@admin.com").Single().Id,
                    RoleId = db.Roles.Where(r => r.Name == "Admin").Single().Id
                });
                db.SaveChanges();
            }
            return manager;
        }
    }
}
