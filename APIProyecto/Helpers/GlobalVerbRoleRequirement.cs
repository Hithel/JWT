
using Microsoft.AspNetCore.Authorization;

namespace APIProyecto.Helpers;
    public class GlobalVerbRoleRequirement : IAuthorizationRequirement
    {
        public bool IsAllowed(string role, string verb)
        {
            if(string.Equals("Administrator", role, StringComparison.OrdinalIgnoreCase)) return true;
            if(string.Equals("Gerente", role, StringComparison.OrdinalIgnoreCase)) return true;

            if(string.Equals("empleado", role, StringComparison.OrdinalIgnoreCase) && string.Equals("GET", verb, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if(string.Equals("camper", role, StringComparison.OrdinalIgnoreCase) && string.Equals("GET", verb, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if(string.Equals("cliente", role, StringComparison.OrdinalIgnoreCase) && string.Equals("GET", verb, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }
    }
