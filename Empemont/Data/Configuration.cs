using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Empemont
{
    public static class Configuration
    {
        static Configuration()
        {
            AnnounceDir = ConfigurationSettings.AppSettings["AnnounceDir"].ToString();
            IconDir = ConfigurationSettings.AppSettings["IconDir"].ToString();
            AudioDir = "";
            AnnouncementMaxDuration = new TimeSpan(0, 20, 0);
        }

        public static string AnnounceDir { get; set; }
        public static string IconDir { get; set; }
        public static string AudioDir { get; set; }
        public static TimeSpan AnnouncementMaxDuration { get; set; }
    }
}
