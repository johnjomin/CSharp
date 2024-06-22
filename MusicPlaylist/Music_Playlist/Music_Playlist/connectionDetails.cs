using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Playlist
{
    class connectionDetails
    {
        public static readonly string establish_Connection  = "Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data Source =Music_Playlist.accdb";

    
        // ok this will deal with the EXIT of 
        // the WHOLE SYSTEM!
       // static bool curret_state = false; // the system has not exited yet

        //YOU ARE  WARNED  DO NOT SET this UNLESS the user QUITS!!! AT ALLLLL!

        public static bool get_System_State ()   {
                 return system_State;
            }
        public static bool system_State = false;
    }
}
