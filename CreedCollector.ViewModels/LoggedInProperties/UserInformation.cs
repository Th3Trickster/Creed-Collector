using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreedCollector.ViewModels.LoggedInProperties
{
    // Properties to be used by class after user is logged in.
    public class UserInformation
    {
        public static string FirstName { get; set; }
        public static string XboxLiveGamertag { get; set; }
        public static string SteamUsername { get; set; }
        public static string PsnName { get; set; }
    }
}
