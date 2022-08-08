using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab9
{
    class RoleBuilder
    {
        /// <summary>
        /// Method to get role description for a given role id
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns>Description of a role id</returns>
        public static string GetRoleDescription(int RoleId)
        {
            switch (RoleId)
            {
                case 1:
                    return "DEVELOPER";
                case 2:
                    return "TEST_ENGINEER";
                case 3:
                    return "SR_DEVELOPER";
                case 4:
                    return "DESIGNER";
                default: 
                    return "UNDEFINED";
            }
        }
    }
}
