using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17_Ex01_Gal_203628763_Guy_308121383
{
    class AppSettings
    {
        // App setting file
        private const string k_FileLocation = "";

        // App setting members
        public Size WindowSize { get; set; }
        public Point WindowsStart { get; set; }
        public bool RememberUser { get; set; }
        public string UserAccessToken { get; set; }

        public void SaveSettingsToFile()
        {
        }

        public void LoadSettingsFromFile()
        {
            
        }
    }
}
